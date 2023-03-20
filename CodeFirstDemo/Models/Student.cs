
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDemo.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }

        [ForeignKey("Standard")]
        public int StandardRefId { get; set; }
        public Standard Standard { get; set; }
    }
}
