

using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo.Models
{
    public class Standard
    {
        [Key]
        public int StandardId { get; set; }
        public string StandardName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
