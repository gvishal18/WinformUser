namespace UserWindows
{
    partial class UserList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVUserList = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modify = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BW = new System.ComponentModel.BackgroundWorker();
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUserList)).BeginInit();
            this.CMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVUserList
            // 
            this.DGVUserList.AllowUserToAddRows = false;
            this.DGVUserList.AllowUserToDeleteRows = false;
            this.DGVUserList.AllowUserToResizeColumns = false;
            this.DGVUserList.AllowUserToResizeRows = false;
            this.DGVUserList.BackgroundColor = System.Drawing.Color.White;
            this.DGVUserList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.first_name,
            this.last_name,
            this.email,
            this.modify,
            this.delete,
            this.status,
            this.password});
            this.DGVUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVUserList.Location = new System.Drawing.Point(0, 0);
            this.DGVUserList.MultiSelect = false;
            this.DGVUserList.Name = "DGVUserList";
            this.DGVUserList.ReadOnly = true;
            this.DGVUserList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVUserList.RowHeadersVisible = false;
            this.DGVUserList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVUserList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DGVUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGVUserList.Size = new System.Drawing.Size(604, 369);
            this.DGVUserList.TabIndex = 0;
            this.DGVUserList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUserList_CellDoubleClick);
            this.DGVUserList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DGVUserList_MouseDown);
            // 
            // user_id
            // 
            this.user_id.HeaderText = "Sr No.";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Visible = false;
            // 
            // first_name
            // 
            this.first_name.HeaderText = "First Name";
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            // 
            // last_name
            // 
            this.last_name.HeaderText = "Last Name";
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email Id";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // modify
            // 
            this.modify.HeaderText = "Modify";
            this.modify.Name = "modify";
            this.modify.ReadOnly = true;
            this.modify.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modify.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // BW
            // 
            this.BW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_DoWork);
            this.BW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_RunWorkerCompleted);
            // 
            // CMS
            // 
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.CMS.Name = "CMS";
            this.CMS.Size = new System.Drawing.Size(151, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Status Change";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 369);
            this.Controls.Add(this.DGVUserList);
            this.Name = "UserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserList_FormClosing);
            this.Load += new System.EventHandler(this.UserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUserList)).EndInit();
            this.CMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVUserList;
        private System.ComponentModel.BackgroundWorker BW;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn modify;
        private System.Windows.Forms.DataGridViewCheckBoxColumn delete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}