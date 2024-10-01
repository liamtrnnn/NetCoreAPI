
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PTPMQL.Models{
    [Table("Person")]
    public class Person{
        [Key]
        public string IDCard {get; set; }
        public string HoTen {get; set; }
        public string Address {get; set; }
    }
}