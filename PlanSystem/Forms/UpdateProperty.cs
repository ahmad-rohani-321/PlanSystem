using DevExpress.XtraEditors;
using PlanSystem.Entity;

namespace PlanSystem.Forms
{
    public partial class UpdateProperty : XtraForm
    {
        private readonly Controllers.Property _prop;
        private readonly Controllers.Settings _settings;
        private readonly RegistrationInfo _registrationInfo;
        public UpdateProperty(RegistrationInfo info)
        {
            InitializeComponent();
            _prop = new();
            _settings = new();
            _registrationInfo = info;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validated() && ValidatedRegistration())
            {

                _registrationInfo.Property.District = int.Parse(txtDistrict.Text);
                _registrationInfo.Property.Gozar = int.Parse(txtGozar.Text);
                _registrationInfo.Property.Block = int.Parse(txtBlock.Text);
                _registrationInfo.Property.PropertyNo = int.Parse(txtPropertyNo.Text);
                _registrationInfo.Property.Unit = int.Parse(txtUnit.Text);
                _registrationInfo.Property.Remarks = txtRemarks.Text;


                _registrationInfo.CategoryId = (int)txtCategory.EditValue;
                _registrationInfo.TypeId = (int)txtPropertyType.EditValue;
                _registrationInfo.AwazNo = int.Parse(txtAwazeNo.Text);
                _registrationInfo.Floars = int.Parse(txtFloorNums.Text);
                _registrationInfo.  MapVisa = txtMapWaze.Text;
                _registrationInfo.Percentage = int.Parse(txtTaxPercentage.Text);
                _registrationInfo.PlanNo = int.Parse(txtPlanNo.Text);
                _registrationInfo.SquareMeter = float.Parse(txtSquareMeter.Text);
                _registrationInfo.Tax = int.Parse(txtTax.Text);

                bool updated = _prop.UpdatePropety(_registrationInfo.Property, _registrationInfo);
                if (updated)
                {
                    Defaults.SuccessMessageBox();
                    Close();
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