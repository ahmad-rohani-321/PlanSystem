using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports;
using DevExpress.XtraReports.ReportGeneration;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Model;
using PlanSystem.Entity;
using System.IO;

namespace PlanSystem
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Defaults.LoggedInUser.IsReadonly)
            {
                Forms.AddProperty property = new();
                property.ShowDialog();
                property.Dispose();
            }
            else
            {
                Defaults.WarningMessageBox("تاسو د تغیراتو اجازه نه لرئ");
            }
        }

        private void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Defaults.LoggedInUser.IsReadonly)
            {
                if (viewProperties.SelectedRowsCount > 0)
                {
                    RegistrationInfo regInfo = (RegistrationInfo)viewProperties.GetFocusedRow();
                    Forms.UpdateProperty property = new(regInfo);
                    property.ShowDialog();
                    property.Dispose();
                }
            }
            else
            {
                Defaults.WarningMessageBox("تاسو د تغیراتو اجازه نه لرئ");
            }
        }

        private void btnPropertyTypes_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Defaults.LoggedInUser.IsReadonly)
            {
                Forms.Types type = new();
                type.ShowDialog();
                type.Dispose();
            }
            else
            {
                Defaults.WarningMessageBox("تاسو د تغیراتو اجازه نه لرئ");
            }
        }

        private void btnPropertyCategories_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Defaults.LoggedInUser.IsReadonly)
            {
                Forms.Categories cats = new();
                cats.ShowDialog();
                cats.Dispose();
            }
            else
            {
                Defaults.WarningMessageBox("تاسو د تغیراتو اجازه نه لرئ");
            }
        }

        private void btnDeleteProperty_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Defaults.LoggedInUser.IsReadonly)
            {
                Defaults.WarningMessageBox("تاسو د تغیراتو اجازه نه لرئ");
            }
            else if (viewProperties.SelectedRowsCount > 0 && Defaults.YesNoMessageBox() == DialogResult.Yes)
            {
                Controllers.Property _db = new();
                int id = (int)viewProperties.GetFocusedRowCellValue("Id");
                bool deleted = _db.DeletePropety(id);
                if (deleted)
                {
                    Defaults.SuccessMessageBox();
                    RefreshForm();
                }
                else
                {
                    Defaults.WarningMessageBox();
                }
                _db.Dispose();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }
        void RefreshForm()
        {
            Controllers.Property _db = new();
            gridProperties.DataSource = _db.GetList();
            gridProperties.RefreshDataSource();
            _db.Dispose();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshForm();
        }

        private void btnUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Defaults.LoggedInUser.IsReadonly)
            {
                Forms.Users user = new Forms.Users();
                user.ShowDialog();
                user.Dispose();
            }
            else
            {
                Defaults.WarningMessageBox("تاسو د تغیراتو اجازه نه لرئ");
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Defaults.YesNoMessageBox() == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReportGenerationOptions options = new ReportGenerationOptions();
            options.PrintGroupSummaryFooter = DefaultBoolean.False;
            XtraReport report = ReportGenerator.GenerateReport(viewProperties, options, true);
            ReportPrintTool designTool = new ReportPrintTool(report);
            designTool.ShowPreviewDialog();
        }

        private void btnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            string dbPath = @"Database.db";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "db files (*.db)|*.db";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(saveFileDialog.FileName))
                {
                    File.Copy(dbPath, saveFileDialog.FileName);
                    Defaults.SuccessMessageBox();
                }
                else
                {
                    Defaults.WarningMessageBox("یو بک آپ سته");
                }
            }
        }
    }
}