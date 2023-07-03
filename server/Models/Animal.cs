using Microsoft.OpenApi.Extensions;
using System.ComponentModel;

namespace server.Models
{
   
    public enum GenderType
    {
        [Description("Male")]
        Male,
        [Description("Female")]
        Female,
    }
    public class Animal
    {
        public string AnimalNumber { get; set; }
        public string Gender { get; set; } 
        public List<Animal>? Children { get; set; }

        public Animal(string animalNumber, string gender, List<Animal>? children)
        {
            AnimalNumber = animalNumber;
            Gender = gender;
            Children = children;
        }
    }

}
