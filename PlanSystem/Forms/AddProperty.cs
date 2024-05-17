using DevExpress.XtraEditors;
namespace PlanSystem.Forms
{
    public partial class AddProperty : XtraForm
    {
        public AddProperty()
        {
            InitializeComponent();
            this.Text = DateTime.Now.ToString();
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
            if (txtLantutude.Text.Length < 0)
            {
                txtLantutude.ErrorText = "عرض البلد حتمي دی";
                result = false;
            }
            else
            {
                txtLantutude.ErrorText = "";
            }
            if (txtLongtitude.Text.Length < 0)
            {
                txtLongtitude.ErrorText = "طول البلد حتمي دی";
                result = false;
            }
            else
            {
                txtLongtitude.ErrorText = "";
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

        }
    }
}