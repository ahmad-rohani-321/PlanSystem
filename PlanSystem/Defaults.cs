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
        private static readonly string _connectionString = $"Server=DESKTOP-HKB55DK; Database=PlanSystem; Trusted_Connection=True; TrustServerCertificate=True";
        public static string ConnectionString { 
            get
            {
                return _connectionString;
            }
        }
        public static string DbPath
        {
            get
            {
                return $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\PlaSystem\";
            }
        }
        public static string DbFilePath
        {
            get
            {
                return $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\PlaSystem\Database.db";
            }
        }

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
