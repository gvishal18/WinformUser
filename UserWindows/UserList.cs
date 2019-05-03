using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserWindows
{
    public partial class UserList : Form
    {
        //private static readonly HttpClient client = new HttpClient();
        public DataTable dtUserlist { get; set; }
        public UserList()
        {
            InitializeComponent();
        }

        public void GetData()
        {

            dynamic dynamicResponse = APIRequest.GetDynamicResponse("user/user_list");
            if (dynamicResponse.result.ToString() == "success")
            {
                if (dynamicResponse.payload?.Count > 0)
                {
                    string payload = dynamicResponse.payload.ToString();
                    dtUserlist = (DataTable)JsonConvert.DeserializeObject(payload, (typeof(DataTable)));
                }
            }
        }

        public void SetData()
        {
            if (DGVUserList.Rows.Count > 0)
            {
                DGVUserList.Rows.Clear();

            }
            foreach (DataRow item in dtUserlist.Rows)
            {
                string role = item["user_role"].ToString();
                string[] test = Regex.Split(role, string.Empty);
                DGVUserList.Rows.Add(
                                            item["user_id"].ToString(),
                                            item["first_name"].ToString(),
                                            item["last_name"].ToString(),
                                            item["email"].ToString(),
                                            test[1] == "1" ? true : false,
                                            test[2] == "1" ? true : false,
                                            Convert.ToBoolean(item["is_deleted"]) == false ? true : false,
                                            item["password"].ToString()
                                     );
            }
        }

        private void BW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void BW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SetData();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            BW.RunWorkerAsync();
        }

        private void DGVUserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGVUserList.Rows.Count > 0 && e.RowIndex >= 0 && Session.UserModify)
                {
                    SignUp signUp = new SignUp();
                    signUp.user_id = Convert.ToInt32(DGVUserList.CurrentRow.Cells["user_id"].Value);
                    signUp.first_name = DGVUserList.CurrentRow.Cells["first_name"].Value.ToString();
                    signUp.last_name = DGVUserList.CurrentRow.Cells["last_name"].Value.ToString();
                    signUp.email = DGVUserList.CurrentRow.Cells["email"].Value.ToString();
                    signUp.password = DGVUserList.CurrentRow.Cells["password"].Value.ToString();
                    signUp.is_modify = Convert.ToBoolean(DGVUserList.CurrentRow.Cells["modify"].Value);
                    signUp.is_delete = Convert.ToBoolean(DGVUserList.CurrentRow.Cells["delete"].Value);
                    signUp.PerformAction = SignUp.Action.update;
                    signUp.ShowDialog();
                    GetData();
                    SetData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        DataGridView.HitTestInfo hittestinfo;

        private void DGVUserList_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right && Session.UserDelete)
                {
                    hittestinfo = DGVUserList.HitTest(e.X, e.Y);

                    if (hittestinfo != null && hittestinfo.Type == DataGridViewHitTestType.Cell)
                    {
                        DGVUserList.ClearSelection();
                        DGVUserList.Rows[hittestinfo.RowIndex].Cells[hittestinfo.ColumnIndex].Selected = true;
                        CMS.Show(DGVUserList, new Point(e.X, e.Y));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to change the status ?", "Confirmation", MessageBoxButtons.YesNo);
                 if (dialogResult == DialogResult.Yes)
                {

                    int user_id = DGVUserList.Rows[hittestinfo.RowIndex].Cells["user_id"].Value != null ||
                                       DGVUserList.Rows[hittestinfo.RowIndex].Cells["user_id"].Value.ToString() != string.Empty ?
                                       Convert.ToInt32(DGVUserList.Rows[hittestinfo.RowIndex].Cells["user_id"].Value) : 0;
                    bool active = Convert.ToBoolean(DGVUserList.Rows[hittestinfo.RowIndex].Cells["status"].Value) == true ? true : false;
                    string api = "";
                    if (active)
                    {
                        api = "user/status/active";
                    }
                    else
                    {
                        api = "user/status/Inactive";
                    }
                    UserData userData = new UserData()
                    {
                        user_id = user_id,
                    };
                    dynamic dynamicResponse = APIRequest.GetDynamicResponse(api,RestSharp.Method.DELETE,userData);
                    if (dynamicResponse.result?.ToString() == "success")
                    {
                        MessageBox.Show("User Status Changed Successfully!!!");
                        GetData();
                        SetData();
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

