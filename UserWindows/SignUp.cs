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
    public partial class SignUp : Form
    {
        public int user_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool is_modify { get; set; }
        public bool is_delete { get; set; }

        public enum Action { signup,update}

        public Action PerformAction { get; set; }

        public SignUp()
        {
            InitializeComponent();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmailId.Clear();
            txtPassword.Clear();
            txtReenter.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string modify = cbxModify.Checked ? "1" : "0";
            string delete = cbxDelete.Checked ? "1" : "0";
            UserData userData = new UserData()
            {
                user_id = user_id,
                first_name = txtFirstName.Text.Trim(),
                last_name = txtLastName.Text.Trim(),
                email = txtEmailId.Text.Trim(), 
                password = txtPassword.Text.Trim(),
                user_role = $"{modify}{delete}"
            };
            string api = "";
            if (PerformAction == Action.signup)
            {
                api = "user/create";    
            } else
            {
                api = "user/update";
            }
            dynamic dynamicResponse = APIRequest.GetDynamicResponse(api, RestSharp.Method.POST, userData);

            if (dynamicResponse.result?.ToString() == "success")
            {
                if (PerformAction == Action.signup)
                {
                    MessageBox.Show("Signup Successfully!!!");
                }
                else
                {
                    MessageBox.Show("Updated Successfully!!!");
                }
                this.Close();
            }
        }

        private void txtReenter_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                if (txtPassword.Text.Trim() != txtReenter.Text.Trim())
                {
                    MessageBox.Show("Please check the password!!!");
                    txtPassword.Clear();
                    txtReenter.Clear();
                    txtPassword.Focus();
                }
            }
        }

        public bool IsValidEmailAddress(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;
            else
            {
                var regex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                return regex.IsMatch(s) && !s.EndsWith(".");
            }
        }

        private void txtEmailId_Leave(object sender, EventArgs e)
        {
          bool check = IsValidEmailAddress(txtEmailId.Text.Trim());
            if (!check)
            {
                MessageBox.Show("Please enter a valid email address!!!");
                txtEmailId.Focus();
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = !string.IsNullOrEmpty(first_name) ? first_name : "";
            txtLastName.Text = !string.IsNullOrEmpty(last_name) ? last_name: "";
            txtEmailId.Text = !string.IsNullOrEmpty(email) ? email: "";
            txtPassword.Text = !string.IsNullOrEmpty(password) ? password : "";
            cbxModify.Checked = is_modify == true ? true : false;
            cbxDelete.Checked = is_delete == true ? true : false;
            if (PerformAction == Action.update)
            {
                lblReenter.Visible = false;
                txtReenter.Visible = false;
                lblUserRole.Visible = true;
                cbxDelete.Visible = true;
                cbxModify.Visible = true;
                btnSubmit.Text = "Update";
                btnRest.Visible = false;
            }
        }
    }
}
