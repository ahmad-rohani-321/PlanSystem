using DevExpress.XtraSplashScreen;
using Microsoft.EntityFrameworkCore;
using System.IO;

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
                else if (result == 1)
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Database.db"))
            {
                MainDbContext db = new MainDbContext();
                db.Database.Migrate();
                if (db.Database.EnsureCreated())
                {
                    Defaults.SuccessMessageBox();
                }
            }
        }
    }
}