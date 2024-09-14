using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Data
    {
        [Key]
        public int Id { get; set; }

        [Column("NAME", TypeName = "varchar(100)")]
        public string Name { get; set; } = string.Empty;  
        [Column("standard", TypeName = "int")]  
        public int Standard { get; set; }

        [Column("dob", TypeName = "varchar(100)")]
        public string DOB { get; set; } = string.Empty;  

        [Column("Address", TypeName = "varchar(100)")]
        public string Address { get; set; } = string.Empty;  
    }
}
