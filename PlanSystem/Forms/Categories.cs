namespace PlanSystem.Forms
{
    public partial class Categories : DevExpress.XtraEditors.XtraForm
    {
        private readonly Controllers.Settings _settings;
        private Entity.PropertyCategories _cat;
        public Categories()
        {
            InitializeComponent();
            _settings = new();
        }

        private void girdCategories_DoubleClick(object sender, EventArgs e)
        {
            if (viewCategories.SelectedRowsCount > 0)
            {
                _cat = (Entity.PropertyCategories)viewCategories.GetFocusedRow();
            }
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtName.ErrorText = string.Empty;
            if (txtName.Text.Length == 0)
            {
                txtName.ErrorText = "نوم حتمي دی";
            }
            else
            {
                if (_cat != null)
                {
                    var updated = _settings.UpdateCategory(_cat);
                    if (updated)
                    {
                        Defaults.SuccessMessageBox();
                        _cat = null;
                        txtName.Text = string.Empty;
                        LoadData();

                    }
                    else
                    {
                        Defaults.WarningMessageBox();
                    }
                }
                else
                {
                    var added = _settings.AddCategory(txtName.Text);
                    if (added)
                    {
                        Defaults.SuccessMessageBox();
                        txtName.Text = string.Empty;
                        LoadData();
                    }
                    else
                    {
                        Defaults.WarningMessageBox();
                    }
                }
            }
        }
        void LoadData()
        {
            girdCategories.DataSource = _settings.GetCategories();
            girdCategories.RefreshDataSource();
        }

        private void Categories_FormClosing(object sender, FormClosingEventArgs e)
        {
            _settings.Dispose();
        }
    }
}