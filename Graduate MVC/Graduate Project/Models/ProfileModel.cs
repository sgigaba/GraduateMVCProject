using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Graduate_Project.Models
{
    public class ProfileModel
    {
        public String Name;
        public String Surname;
        public DateTime DateOfBirth;
        public int Age;
        public String Country;
        public String City;
    }
}
