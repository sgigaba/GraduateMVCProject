using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Graduate_Project.Models
{
    public class ProfileModel
    {
        [Key]
        public int ID { get; set; }
        public String Name { get; set; } 
        public String Surname { get; set; } 

        public DateTime DateOfBirth { get; set; } 
        public int Age { get; set; }
        public String Country { get; set; }
        public String City { get; set; }
    }
}
