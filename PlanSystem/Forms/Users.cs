namespace PlanSystem.Forms
{
    public partial class Users : DevExpress.XtraEditors.XtraForm
    {
        private readonly Controllers.Users _user;
        public Users()
        {
            InitializeComponent();
            _user = new();
        }
        private void Users_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }
        private void RefreshForm()
        {
            gridUsers.DataSource = _user.GetList();
            gridUsers.RefreshDataSource();
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtIsReadOnly.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validated())
            {
                bool added = _user.AddUser(txtUserName.Text, txtPassword.Text, txtIsReadOnly.Checked);
                if (added)
                {
                    Defaults.SuccessMessageBox();
                    RefreshForm();
                }
                else
                {
                    Defaults.WarningMessageBox();
                }
            }
        }

        private new bool Validated()
        {
            bool result = true;
            if (txtUserName.Text.Length == 0)
            {
                txtUserName.ErrorText = "یوزر نوم حتمی دی";
                result = false;
            }
            else
            {
                txtUserName.ErrorText = string.Empty;
            }
            if (txtPassword.Text.Length == 0)
            {
                txtPassword.ErrorText = "پاسورډ حتمی دی";
                result = false;
            }
            else
            {
                txtPassword.ErrorText = string.Empty;
            }
            return result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (viewUsers.SelectedRowsCount > 0)
            {
                Entity.Users id = (Entity.Users)viewUsers.GetFocusedRow();
                bool deleted = _user.DeleteUser(id);
                if (deleted)
                {
                    RefreshForm();
                }
                else
                {
                    Defaults.WarningMessageBox();
                }
            }
        }
    }
}