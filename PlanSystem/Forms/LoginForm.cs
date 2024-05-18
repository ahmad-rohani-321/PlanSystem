using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanSystem.Forms
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Controllers.Users user = new Controllers.Users();
            if (txtUserName.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                byte result = user.Login(txtUserName.Text, txtPassword.Text);
                if (result == 0)
                {
                    MainForm form = new MainForm();
                    Hide();
                    form.ShowDialog();
                }
                else if(result == 1) 
                {
                    Defaults.WarningMessageBox("یوزر نه سو پیدا");
                }
                else
                {
                    Defaults.WarningMessageBox("په ډاټابېس کي کوم مشکل سته");
                }
            }
            user.Dispose();
        }
    }
}