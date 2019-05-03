using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserWindows
{
    public partial class Login : Form
    {
        public DataTable dtUserRole{ get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.ShowDialog();
        }

        private  void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic dynamicResponse = APIRequest.GetDynamicResponse($"user/login?email_id={txtEmailId.Text}&password={txtPassword.Text}");

                if (dynamicResponse.result.ToString() == "success")
                {
                    string payload = dynamicResponse.payload.ToString();
                    dtUserRole = (DataTable)JsonConvert.DeserializeObject(payload, (typeof(DataTable)));

                    string role = dtUserRole.Rows[0]["user_role"].ToString();
                    if (!string.IsNullOrEmpty(role))
                    {
                        string[] test = Regex.Split(role, string.Empty);
                        Session.UserModify = test[1] == "1" ? true : false;
                        Session.UserDelete = test[2] == "1" ? true : false;

                    }                    txtEmailId.Clear();
                    txtPassword.Clear();
                    UserList userList = new UserList();
                    userList.ShowDialog();
                }
                else
                {
                    MessageBox.Show(dynamicResponse.message.ToString());
                    txtEmailId.Clear();
                    txtPassword.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
