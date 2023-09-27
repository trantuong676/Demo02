using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  BTL.Models;

public class Person
{
    [Key]
    public string  StudentID { get; set; }
    [ForeignKey("StudentID")]
        public Student? Student {get; set;}
    public string  PersonID { get; set; }
   
   
}