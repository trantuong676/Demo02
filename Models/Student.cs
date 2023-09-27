using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  BTL.Models;

public class Student
{
    [Key]
    public string  StudentID { get; set; }
    public string  StudentName { get; set; }
    public string  adress { get; set; }
   
}