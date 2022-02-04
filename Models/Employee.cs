using Microsoft.AspNetCore.Mvc.Localization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Globalization.Controllers;
using Microsoft.Extensions.Logging;

namespace Globalization.Models
{
    public class Employee
    {
        

        //[DisplayName("Employee Name")]
        [Required(ErrorMessage ="Enter your name")]
       
        public string Name { get; set; }

        //[DisplayName("Employee City Name")]
        [Required(ErrorMessage = "Enter your City name")]
        
        public string CityName { get; set; }
    }
}
