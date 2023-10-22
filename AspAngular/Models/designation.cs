using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspAngular.Models
{
    public class designation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int designationID { get; set; }

        public string mydesignation { get; set; }

      
    }
}
