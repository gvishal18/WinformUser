namespace UserWindows
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmailId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReenter = new System.Windows.Forms.TextBox();
            this.lblReenter = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.cbxModify = new System.Windows.Forms.CheckBox();
            this.cbxDelete = new System.Windows.Forms.CheckBox();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(175, 64);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(199, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(175, 36);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(199, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(175, 120);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(199, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmailId
            // 
            this.txtEmailId.Location = new System.Drawing.Point(176, 92);
            this.txtEmailId.Name = "txtEmailId";
            this.txtEmailId.Size = new System.Drawing.Size(199, 22);
            this.txtEmailId.TabIndex = 3;
            this.txtEmailId.Leave += new System.EventHandler(this.txtEmailId_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email ID:";
            // 
            // txtReenter
            // 
            this.txtReenter.Location = new System.Drawing.Point(175, 148);
            this.txtReenter.Name = "txtReenter";
            this.txtReenter.Size = new System.Drawing.Size(199, 22);
            this.txtReenter.TabIndex = 5;
            this.txtReenter.UseSystemPasswordChar = true;
            this.txtReenter.Leave += new System.EventHandler(this.txtReenter_Leave);
            // 
            // lblReenter
            // 
            this.lblReenter.AutoSize = true;
            this.lblReenter.Location = new System.Drawing.Point(59, 151);
            this.lblReenter.Name = "lblReenter";
            this.lblReenter.Size = new System.Drawing.Size(114, 14);
            this.lblReenter.TabIndex = 10;
            this.lblReenter.Text = "Re-Enter Password :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(299, 221);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 25);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(175, 221);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(75, 25);
            this.btnRest.TabIndex = 8;
            this.btnRest.Text = "Reset";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // cbxModify
            // 
            this.cbxModify.AutoSize = true;
            this.cbxModify.Location = new System.Drawing.Point(176, 176);
            this.cbxModify.Name = "cbxModify";
            this.cbxModify.Size = new System.Drawing.Size(95, 18);
            this.cbxModify.TabIndex = 13;
            this.cbxModify.Text = "Can Modify ?";
            this.cbxModify.UseVisualStyleBackColor = true;
            this.cbxModify.Visible = false;
            // 
            // cbxDelete
            // 
            this.cbxDelete.AutoSize = true;
            this.cbxDelete.Location = new System.Drawing.Point(277, 176);
            this.cbxDelete.Name = "cbxDelete";
            this.cbxDelete.Size = new System.Drawing.Size(135, 18);
            this.cbxDelete.TabIndex = 13;
            this.cbxDelete.Text = "Can Change Status ?";
            this.cbxDelete.UseVisualStyleBackColor = true;
            this.cbxDelete.Visible = false;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Location = new System.Drawing.Point(104, 177);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(66, 14);
            this.lblUserRole.TabIndex = 14;
            this.lblUserRole.Text = "User Role :";
            this.lblUserRole.Visible = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(461, 258);
            this.Controls.Add(this.lblUserRole);
            this.Controls.Add(this.cbxDelete);
            this.Controls.Add(this.cbxModify);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.txtReenter);
            this.Controls.Add(this.lblReenter);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmailId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmailId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReenter;
        private System.Windows.Forms.Label lblReenter;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.CheckBox cbxModify;
        private System.Windows.Forms.CheckBox cbxDelete;
        private System.Windows.Forms.Label lblUserRole;
    }
}