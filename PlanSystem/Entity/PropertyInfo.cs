using System.ComponentModel.DataAnnotations;

namespace PlanSystem.Entity
{
    public class PropertyInfo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public string TazkiraNo { get; set; }
        public int District { get; set; }
        public int Gozar { get; set; }
        public int Block { get; set; }
        public int PropertyNo { get; set; }
        public int Unit { get; set; }
        public string Remarks { get; set; }
    }
}
