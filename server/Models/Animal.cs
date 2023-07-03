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
        public string AnimalNumber { get; set; } = string.Empty;
        public string Gender { get; set; } = GenderType.Male.GetDisplayName();

        public List<Animal>? Children { get; set; }   

    }

}
