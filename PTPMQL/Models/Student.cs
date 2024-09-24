using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTPMQL.Models{
    [Table("Student")]
    public class Student{
        [Key]
        [Required]
        public string StudentId {get; set; }
         [Required]

        public string FullName {get; set; }
         [Required]

        public string Address {get; set; }
    }
}