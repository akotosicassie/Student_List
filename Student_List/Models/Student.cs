using System.ComponentModel.DataAnnotations;

namespace Student_List.Models
{
    public class Student
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Bio { get; set; }      
    }
}
