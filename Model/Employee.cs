using System.ComponentModel.DataAnnotations;

namespace BlazorCrudCDx.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }    
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string? Gender { get; set; }
        public int? Age { get; set; }
    }
}
