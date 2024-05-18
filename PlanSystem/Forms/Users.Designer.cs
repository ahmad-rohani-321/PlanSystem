namespace PlanSystem.Forms
{
    partial class Users
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
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            txtIsReadOnly = new DevExpress.XtraEditors.CheckEdit();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            txtUserName = new DevExpress.XtraEditors.TextEdit();
            gridUsers = new DevExpress.XtraGrid.GridControl();
            viewUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            userName = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            btnDelete = new DevExpress.XtraEditors.SimpleButton();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtIsReadOnly.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUserName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnDelete);
            layoutControl1.Controls.Add(txtIsReadOnly);
            layoutControl1.Controls.Add(btnSave);
            layoutControl1.Controls.Add(txtPassword);
            layoutControl1.Controls.Add(txtUserName);
            layoutControl1.Controls.Add(gridUsers);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(469, 471);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // txtIsReadOnly
            // 
            txtIsReadOnly.Location = new Point(236, 76);
            txtIsReadOnly.Name = "txtIsReadOnly";
            txtIsReadOnly.Properties.Caption = "یوازي راپور";
            txtIsReadOnly.Size = new Size(221, 23);
            txtIsReadOnly.StyleController = layoutControl1;
            txtIsReadOnly.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(236, 103);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(221, 24);
            btnSave.StyleController = layoutControl1;
            btnSave.TabIndex = 4;
            btnSave.Text = "ثبت";
            btnSave.Click += btnSave_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 44);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(388, 28);
            txtPassword.StyleController = layoutControl1;
            txtPassword.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(12, 12);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(388, 28);
            txtUserName.StyleController = layoutControl1;
            txtUserName.TabIndex = 0;
            // 
            // gridUsers
            // 
            gridUsers.Location = new Point(12, 131);
            gridUsers.MainView = viewUsers;
            gridUsers.Name = "gridUsers";
            gridUsers.Size = new Size(445, 328);
            gridUsers.TabIndex = 6;
            gridUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { viewUsers });
            // 
            // viewUsers
            // 
            viewUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, userName, gridColumn4 });
            viewUsers.GridControl = gridUsers;
            viewUsers.Name = "viewUsers";
            viewUsers.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Id";
            gridColumn1.FieldName = "Id";
            gridColumn1.Name = "gridColumn1";
            // 
            // userName
            // 
            userName.Caption = "یوزر نوم";
            userName.FieldName = "UserName";
            userName.Name = "userName";
            userName.Visible = true;
            userName.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "یوازی کتونکی";
            gridColumn4.FieldName = "IsReadonly";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 1;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem4, layoutControlItem3, emptySpaceItem1, layoutControlItem5, layoutControlItem6, emptySpaceItem2 });
            Root.Name = "Root";
            Root.Size = new Size(469, 471);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gridUsers;
            layoutControlItem1.Location = new Point(0, 119);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(449, 332);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = txtUserName;
            layoutControlItem2.Location = new Point(0, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(449, 32);
            layoutControlItem2.Text = "بوزر نوم";
            layoutControlItem2.TextSize = new Size(45, 19);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = btnSave;
            layoutControlItem4.Location = new Point(224, 91);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(225, 28);
            layoutControlItem4.TextSize = new Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = txtPassword;
            layoutControlItem3.Location = new Point(0, 32);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(449, 32);
            layoutControlItem3.Text = "پاسورډ";
            layoutControlItem3.TextSize = new Size(45, 19);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(112, 64);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(112, 55);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = txtIsReadOnly;
            layoutControlItem5.Location = new Point(224, 64);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(225, 27);
            layoutControlItem5.TextSize = new Size(0, 0);
            layoutControlItem5.TextVisible = false;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 103);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 24);
            btnDelete.StyleController = layoutControl1;
            btnDelete.TabIndex = 5;
            btnDelete.Text = "حذف";
            btnDelete.Click += btnDelete_Click;
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = btnDelete;
            layoutControlItem6.Location = new Point(0, 91);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(112, 28);
            layoutControlItem6.TextSize = new Size(0, 0);
            layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new Point(0, 64);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new Size(112, 27);
            emptySpaceItem2.TextSize = new Size(0, 0);
            // 
            // Users
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(469, 471);
            Controls.Add(layoutControl1);
            MaximizeBox = false;
            MaximumSize = new Size(471, 501);
            MinimizeBox = false;
            MinimumSize = new Size(471, 501);
            Name = "Users";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "یوزران";
            Load += Users_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtIsReadOnly.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUserName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView viewUsers;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn userName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.CheckEdit txtIsReadOnly;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}