﻿using DevExpress.XtraEditors;

namespace PlanSystem.Forms
{
    public partial class AddProperty : XtraForm
    {
        private readonly Controllers.Property _prop;
        private readonly Controllers.Settings _settings;
        public AddProperty()
        {
            InitializeComponent();
            _prop = new();
            _settings = new();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validated() && ValidatedRegistration())
            {
                var property = new Entity.PropertyInfo()
                {
                    District = int.Parse(txtDistrict.Text),
                    Gozar = int.Parse(txtGozar.Text),
                    Block = int.Parse(txtBlock.Text),
                    PropertyNo = int.Parse(txtPropertyNo.Text),
                    Unit = int.Parse(txtUnit.Text),
                    Remarks = txtRemarks.Text
                };
                var registration = new Entity.RegistrationInfo()
                {
                    CategoryId = (int)txtCategory.EditValue,
                    TypeId = (int)txtPropertyType.EditValue,
                    AwazNo = int.Parse(txtAwazeNo.Text),
                    Floars = int.Parse(txtFloorNums.Text),
                    MapVisa = txtMapWaze.Text,
                    Percentage = int.Parse(txtTaxPercentage.Text),
                    PlanNo = int.Parse(txtPlanNo.Text),
                    SquareMeter = float.Parse(txtSquareMeter.Text),
                    Tax = int.Parse(txtTax.Text),
                };
                bool added = _prop.AddProperty(property, registration);
                if (added)
                {
                    Defaults.SuccessMessageBox();
                    ClearForm();
                }
                else
                {
                    Defaults.WarningMessageBox();
                }
            }
        }

        private void ClearForm()
        {
            txtCategory.EditValue = null;
            txtPropertyType.EditValue = null;
            txtAwazeNo.Text = 0.ToString();
            txtFloorNums.Text = 0.ToString();
            txtTax.Text = 0.ToString();
            txtTaxPercentage.Text = 0.ToString();
            txtSquareMeter.Text = 0.ToString();
            txtMapWaze.Text = string.Empty;


            txtDistrict.Text = 0.ToString();
            txtGozar.Text = 0.ToString();
            txtBlock.Text = 0.ToString();
            txtPropertyNo.Text = 0.ToString();
            txtUnit.Text = 0.ToString();
            txtRemarks.Text = string.Empty;
        }

        private new bool Validated()
        {
            bool result = true;
            if (int.Parse(txtDistrict.Text) > 17 || int.Parse(txtDistrict.Text) < 1)
            {
                txtDistrict.ErrorText = "دغه ناحیه نه ده موجوده";
                result = false;
            }
            else
            {
                txtDistrict.ErrorText = "";
            }
            if (int.Parse(txtGozar.Text) < 1)
            {
                txtGozar.ErrorText = "صفر ګذر صحت نه لري";
                result = false;
            }
            else
            {
                txtGozar.ErrorText = "";
            }
            if (int.Parse(txtPropertyNo.Text) < 1)
            {
                txtPropertyNo.ErrorText = "صفر ملکیت صحت نه لري";
                result = false;
            }
            else
            {
                txtPropertyNo.ErrorText = "";
            }
            if (int.Parse(txtUnit.Text) < 1)
            {
                txtUnit.ErrorText = "صفر واحد صحت نه لري";
                result = false;
            }
            else
            {
                txtUnit.ErrorText = "";
            }
            return result;
        }
        private bool ValidatedRegistration()
        {
            bool result = true;
            if (txtCategory.EditValue == null)
            {
                txtCategory.ErrorText = "کټیګوري انتخاب کړئ";
                result = false;
            }
            else
            {
                txtCategory.ErrorText = "";
            }
            if (txtPropertyType.EditValue == null)
            {
                txtPropertyType.ErrorText = "د سیمي ډول انتخاب کړئ";
                result = false;
            }
            else
            {
                txtPropertyType.ErrorText = "";
            }
            if (txtPropertyType.EditValue == null)
            {
                txtPropertyType.ErrorText = "د سیمي ډول انتخاب کړئ";
                result = false;
            }
            else
            {
                txtPropertyType.ErrorText = "";
            }
            if (int.Parse(txtFloorNums.EditValue.ToString()) < 0)
            {
                txtFloorNums.ErrorText = "د منازلو تعداد انتخاب کړئ";
                result = false;
            }
            else
            {
                txtFloorNums.ErrorText = "";
            }
            if (float.Parse(txtSquareMeter.EditValue.ToString()) < 0)
            {
                txtSquareMeter.ErrorText = "مترکعب معلوم کړئ";
                result = false;
            }
            else
            {
                txtSquareMeter.ErrorText = "";
            }
            if (txtMapWaze.Text.Length == 0)
            {
                txtMapWaze.ErrorText = "د نقشې وېزه معلوم کړئ";
                result = false;
            }
            else
            {
                txtMapWaze.ErrorText = "";
            }
            if (int.Parse(txtTax.Text) == 0)
            {
                txtTax.ErrorText = "د نقشې ټکس معلوم کړئ";
                result = false;
            }
            else
            {
                txtTax.ErrorText = "";
            }
            return result;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearForm();
        }

        private void AddProperty_Load(object sender, EventArgs e)
        {
            txtCategory.Properties.DataSource = _settings.GetCategories();
            txtPropertyType.Properties.DataSource = _settings.GetTypes();
        }

        private void AddProperty_FormClosing(object sender, FormClosingEventArgs e)
        {
            _settings.Dispose();
            _prop.Dispose();
        }
    }
}