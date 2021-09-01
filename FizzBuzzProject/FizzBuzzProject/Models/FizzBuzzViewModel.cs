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
        
        [Range(1,1000,ErrorMessage ="Value should be between 1 and 1000")]
        [Required(ErrorMessage = "Please Enter a Value")]
        public int? User_Input { get; set; }
        public IList<String> FizzBuzzNumbers { get; set; }
        //public IPagedList<string> FizzBuzzNumbers { get; set; }

    
    }
}
