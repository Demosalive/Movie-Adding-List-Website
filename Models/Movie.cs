using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Movie
    {
        [Required]
        [RegularExpression(@"[0-9]", ErrorMessage = "Please select a number")]
        public int ID { get; set; }

        [Required]
        [RegularExpression(@"[\W\Sa-zA-Z0-9!@#$%^&*()_+=\[{\]};:<>|./?,\\'""-]+", ErrorMessage = "Choose a valid movie title")]
        [StringLength(50, MinimumLength = 2)]
        public string Title { get; set; }

        [Required]
        [RegularExpression(@"[\Wa-zA-Z0-9!@#$%^&*()_+=\[{\]};:<>|./?,\\'""-]+", ErrorMessage = "Select a valid choice")]
        public string Genre { get; set; }

        [Required]
        [RegularExpression(@"[0-9]{4}", ErrorMessage = "Choose a year between 1880 and the current year")]
        
        public int Year { get; set; }

        //[Required]
        //[RegularExpression(@".{0}[a-zA-Z0-9]+|.{1,50}[a-zA-Z0-9 ]")]
        public List<string> Actors { get; set; }

        //[Required]
        //[RegularExpression(@"[a-zA-Z0-9]")]
        public List<string> Directors { get; set; }
    }
}
