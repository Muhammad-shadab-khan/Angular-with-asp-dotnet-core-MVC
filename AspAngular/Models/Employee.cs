using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NuGet.Protocol.Plugins;

namespace AspAngular.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime age { get; set; }
        public DateTime dateofjoing { get; set; }
        public string gender { get; set; }
        public string isMarried { get; set; }
        public string isActive { get; set; }
        [NotMapped]
        public  string  designations { get; set; }
        [Required]
        [ForeignKey("Designation")]
        public int designationID { get; set; }
        public virtual designation Designation { get; set; }
    }
}
