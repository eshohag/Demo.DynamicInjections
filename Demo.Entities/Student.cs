using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Entities
{
    [Table("Students")]
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
