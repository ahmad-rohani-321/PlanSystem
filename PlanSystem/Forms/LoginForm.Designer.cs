namespace PlanSystem.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtUserName = new DevExpress.XtraEditors.TextEdit();
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            btnLogin = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtUserName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(66, 74);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(296, 28);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(66, 133);
            txtPassword.Name = "txtPassword";
            txtPassword.Properties.PasswordChar = '*';
            txtPassword.Size = new Size(296, 28);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(234, 167);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(128, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "داخلېدل";
            btnLogin.Click += btnLogin_Click;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(317, 49);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(45, 19);
            labelControl1.TabIndex = 3;
            labelControl1.Text = "یوزر نوم";
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(325, 108);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(37, 19);
            labelControl2.TabIndex = 4;
            labelControl2.Text = "پاسورډ";
            // 
            // LoginForm
            // 
            Appearance.Options.UseFont = true;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(428, 245);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.Image = (Image)resources.GetObject("LoginForm.IconOptions.Image");
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(430, 275);
            MinimizeBox = false;
            MinimumSize = new Size(430, 275);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "داخلېدل";
            ((System.ComponentModel.ISupportInitialize)txtUserName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}