using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanSystem.Entity
{
    public class PropertyInfo
    {
        [Key]
        public int id { get; set; }
        public int District { get; set; }
        public int Gozar { get; set; }
        public int Block { get; set; }
        public int PropertyNo { get; set; }
        public int Unit { get; set; }
        public string Remarks { get; set; }
    }
}
