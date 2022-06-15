using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppClark.Models
{
    public class FutureAgeModel
    {
        [Required (ErrorMessage = "Please enter your name")]
        public String Name { get; set; }

        [Required (ErrorMessage = "Please enter your birth year")]
        [Range (1900, 2022, ErrorMessage ="Please enter a year between 1900 and 2022")]
        public int? BirthYear { get; set; }

        public FutureAgeModel (string Name, int? BirthYear)
        {
            this.Name = Name;
            this.BirthYear = BirthYear;
        }

        public int? AgeThisYear()
        {
            const int CURRENT_YEAR = 2022;
            int? age = CURRENT_YEAR - BirthYear;
            return age;
        }
    }
}
