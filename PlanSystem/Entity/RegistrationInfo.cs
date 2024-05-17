using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanSystem.Entity
{
    public class RegistrationInfo
    {
        // 17 districts
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int TypeId { get; set; }
        public int PropertyId { get; set; }
        public int Floars { get; set; }
        public float SquareMeter { get; set; }
        public string MapVisa { get; set; }
        public int Percentage { get; set; }
        public int Tax { get; set; }
        public int PlanNo { get; set; }
        public int AwazNo { get; set; }

        // references
        [ForeignKey(nameof(CategoryId))]
        public PropertyCategories Category { get; set; }
        [ForeignKey(nameof(TypeId))]
        public PropertyType Type { get; set; }
        [ForeignKey(nameof(PropertyId))]
        public PropertyInfo Property { get; set; }
    }
}
