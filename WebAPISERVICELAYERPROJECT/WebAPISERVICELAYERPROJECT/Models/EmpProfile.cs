using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPISERVICELAYERPROJECT.Models
{
    [Table("EmpProfile")]
    public class EmpProfile
    {
        [Key]
        public int EmpCode { get; set; }
        public string? EmpName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string? Email { get; set; }
        public int DeptCode { get; set; }
    }
}

