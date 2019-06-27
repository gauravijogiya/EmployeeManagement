using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace CRUDcore.Models
{
    public class Employee
    {
        [Key]
        public int EmployeID { get; set; }
        [Required(ErrorMessage ="This field is required")]
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Full Name")]
        public string Fullname { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Emp Code")]
        public string Empcode { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string position { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }
    }
}
