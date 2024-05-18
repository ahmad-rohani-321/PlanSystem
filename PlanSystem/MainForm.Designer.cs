namespace PlanSystem
{
    partial class MainForm
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
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation1 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnNew = new DevExpress.XtraBars.BarButtonItem();
            btnPrint = new DevExpress.XtraBars.BarButtonItem();
            btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            btnPropertyTypes = new DevExpress.XtraBars.BarButtonItem();
            btnPropertyCategories = new DevExpress.XtraBars.BarButtonItem();
            btnDeleteProperty = new DevExpress.XtraBars.BarButtonItem();
            btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            btnUsers = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            gridProperties = new DevExpress.XtraGrid.GridControl();
            viewProperties = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewProperties).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.AutoSizeItems = true;
            ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            ribbon.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.ItemPanelStyle = DevExpress.XtraBars.Ribbon.RibbonItemPanelStyle.Skin;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, btnNew, btnPrint, btnUpdate, btnPropertyTypes, btnPropertyCategories, btnDeleteProperty, btnRefresh, btnUsers });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 14;
            ribbon.Name = "ribbon";
            ribbon.OptionsStubGlyphs.CornerRadius = 1;
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowSearchItem = true;
            ribbon.ShowToolbarCustomizeItem = false;
            ribbon.Size = new Size(951, 171);
            ribbon.StatusBar = ribbonStatusBar;
            ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // btnNew
            // 
            btnNew.Caption = "نوی ملکیت";
            btnNew.Id = 1;
            btnNew.Name = "btnNew";
            btnNew.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnNew.ItemClick += btnNew_ItemClick;
            // 
            // btnPrint
            // 
            btnPrint.Caption = "چاپ";
            btnPrint.Id = 2;
            btnPrint.Name = "btnPrint";
            btnPrint.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnUpdate
            // 
            btnUpdate.Caption = "ملکیت تغیر";
            btnUpdate.Id = 4;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnUpdate.ItemClick += btnUpdate_ItemClick;
            // 
            // btnPropertyTypes
            // 
            btnPropertyTypes.Caption = "ملکیت سیمي ډولونه";
            btnPropertyTypes.Id = 9;
            btnPropertyTypes.Name = "btnPropertyTypes";
            btnPropertyTypes.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnPropertyTypes.ItemClick += btnPropertyTypes_ItemClick;
            // 
            // btnPropertyCategories
            // 
            btnPropertyCategories.Caption = "ملکیت کټیګوري";
            btnPropertyCategories.Id = 10;
            btnPropertyCategories.Name = "btnPropertyCategories";
            btnPropertyCategories.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnPropertyCategories.ItemClick += btnPropertyCategories_ItemClick;
            // 
            // btnDeleteProperty
            // 
            btnDeleteProperty.Caption = "ملکیت حذف";
            btnDeleteProperty.Id = 11;
            btnDeleteProperty.Name = "btnDeleteProperty";
            btnDeleteProperty.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnDeleteProperty.ItemClick += btnDeleteProperty_ItemClick;
            // 
            // btnRefresh
            // 
            btnRefresh.Caption = "صفحه تازه کول";
            btnRefresh.Id = 12;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnRefresh.ItemClick += btnRefresh_ItemClick;
            // 
            // btnUsers
            // 
            btnUsers.Caption = "یوزران";
            btnUsers.Id = 13;
            btnUsers.Name = "btnUsers";
            btnUsers.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnUsers.ItemClick += btnUsers_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.Single;
            reduceOperation1.GroupName = null;
            reduceOperation1.ItemLinkIndex = 0;
            reduceOperation1.ItemLinksCount = 0;
            reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.LargeButtons;
            ribbonPage1.ReduceOperations.Add(reduceOperation1);
            ribbonPage1.Text = "ملکیت";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(btnNew);
            ribbonPageGroup1.ItemLinks.Add(btnUpdate);
            ribbonPageGroup1.ItemLinks.Add(btnPrint);
            ribbonPageGroup1.ItemLinks.Add(btnPropertyTypes);
            ribbonPageGroup1.ItemLinks.Add(btnPropertyCategories);
            ribbonPageGroup1.ItemLinks.Add(btnDeleteProperty);
            ribbonPageGroup1.ItemLinks.Add(btnUsers);
            ribbonPageGroup1.ItemLinks.Add(btnRefresh);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 507);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(951, 35);
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "barButtonItem1";
            barButtonItem1.Id = 7;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "barButtonItem2";
            barButtonItem2.Id = 8;
            barButtonItem2.Name = "barButtonItem2";
            // 
            // gridProperties
            // 
            gridProperties.Dock = DockStyle.Fill;
            gridProperties.Location = new Point(0, 171);
            gridProperties.MainView = viewProperties;
            gridProperties.MenuManager = ribbon;
            gridProperties.Name = "gridProperties";
            gridProperties.Size = new Size(951, 336);
            gridProperties.TabIndex = 2;
            gridProperties.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { viewProperties });
            // 
            // viewProperties
            // 
            viewProperties.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn7, gridColumn16, gridColumn15, gridColumn8, gridColumn9, gridColumn10, gridColumn11, gridColumn12, gridColumn13, gridColumn14 });
            viewProperties.GridControl = gridProperties;
            viewProperties.Name = "viewProperties";
            viewProperties.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "ګذر";
            gridColumn1.FieldName = "Property.Gozar";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "ناحیه";
            gridColumn2.FieldName = "Property.District";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "id";
            gridColumn3.FieldName = "Id";
            gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "بلاک";
            gridColumn4.FieldName = "Property.Block";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "ملکیت شمېره";
            gridColumn5.FieldName = "Property.PropertyNo";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "واحد";
            gridColumn6.FieldName = "Property.Unit";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "تبصره";
            gridColumn7.FieldName = "Property.Remarks";
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn16
            // 
            gridColumn16.Caption = "کټیګوري";
            gridColumn16.FieldName = "Category.Name";
            gridColumn16.Name = "gridColumn16";
            gridColumn16.Visible = true;
            gridColumn16.VisibleIndex = 7;
            // 
            // gridColumn15
            // 
            gridColumn15.Caption = "سیمي ډول";
            gridColumn15.FieldName = "Type.Name";
            gridColumn15.Name = "gridColumn15";
            gridColumn15.Visible = true;
            gridColumn15.VisibleIndex = 9;
            // 
            // gridColumn8
            // 
            gridColumn8.Caption = "منازلو تعداد";
            gridColumn8.FieldName = "Floars";
            gridColumn8.Name = "gridColumn8";
            gridColumn8.Visible = true;
            gridColumn8.VisibleIndex = 6;
            // 
            // gridColumn9
            // 
            gridColumn9.Caption = "متر مربع";
            gridColumn9.FieldName = "SquareMeter";
            gridColumn9.Name = "gridColumn9";
            gridColumn9.Visible = true;
            gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            gridColumn10.Caption = "نقشې وېزه";
            gridColumn10.FieldName = "MapVisa";
            gridColumn10.Name = "gridColumn10";
            gridColumn10.Visible = true;
            gridColumn10.VisibleIndex = 10;
            // 
            // gridColumn11
            // 
            gridColumn11.Caption = "ټکس فیصدي";
            gridColumn11.FieldName = "Percentage";
            gridColumn11.Name = "gridColumn11";
            gridColumn11.Visible = true;
            gridColumn11.VisibleIndex = 11;
            // 
            // gridColumn12
            // 
            gridColumn12.Caption = "ټکس";
            gridColumn12.FieldName = "Tax";
            gridColumn12.Name = "gridColumn12";
            gridColumn12.Visible = true;
            gridColumn12.VisibleIndex = 12;
            // 
            // gridColumn13
            // 
            gridColumn13.Caption = "د پلان په اساس شمېره";
            gridColumn13.FieldName = "PlanNo";
            gridColumn13.Name = "gridColumn13";
            gridColumn13.Visible = true;
            gridColumn13.VisibleIndex = 13;
            // 
            // gridColumn14
            // 
            gridColumn14.Caption = "آوېز نمبر";
            gridColumn14.FieldName = "AwazNo";
            gridColumn14.Name = "gridColumn14";
            gridColumn14.Visible = true;
            gridColumn14.VisibleIndex = 14;
            // 
            // MainForm
            // 
            AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            Appearance.Options.UseFont = true;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(951, 542);
            Controls.Add(gridProperties);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Font = new Font("Calibri", 8.25F);
            Name = "MainForm";
            Ribbon = ribbon;
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            StatusBar = ribbonStatusBar;
            Text = "عمومي صفحه";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewProperties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnPropertyTypes;
        private DevExpress.XtraBars.BarButtonItem btnPropertyCategories;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraGrid.GridControl gridProperties;
        private DevExpress.XtraGrid.Views.Grid.GridView viewProperties;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraBars.BarButtonItem btnDeleteProperty;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnUsers;
    }
}