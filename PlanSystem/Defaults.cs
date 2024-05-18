using DevExpress.XtraEditors;
using PlanSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanSystem
{
    internal static class Defaults
    {
        public static Users LoggedInUser { get; set; }
        public static void SuccessMessageBox()
        {
            XtraMessageBox.Show("عملیه تکمیل سوه", "خبرتیا", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void WarningMessageBox()
        {
            XtraMessageBox.Show("عملیه تکمیل نه سوه", "خبرتیا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void WarningMessageBox(string message)
        {
            XtraMessageBox.Show(message, "خبرتیا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult YesNoMessageBox()
        {
            return XtraMessageBox.Show("ایا مطمئن یاست!", "خبرتیا", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
