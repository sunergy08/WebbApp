using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebbApp.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int StudentId { get; set; }
        public string FirstName { get; set; }   
        public string MiddleName { get; set; }
        public string LastName { get; set; }    
        public string Department { get; set; }

    }
}
