using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace FizzBuzzProject.Models
{
    public class FizzBuzzViewModel
    {

        [Range(1, 1000, ErrorMessage = "Value should be between 1 and 1000")]
        [Required(ErrorMessage = "Please Enter a Value")]
        public int? UserInput { get; set; }
        public IPagedList<String> FizzBuzzNumbers { get; set; }
    }
}
