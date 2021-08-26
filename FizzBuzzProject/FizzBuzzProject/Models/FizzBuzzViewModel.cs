using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzProject.Models
{
    public class FizzBuzzViewModel
    {
        [Range(1,1000,ErrorMessage ="Value Should be between 1 to 1000")]
        public int number { get; set; }
        public IList<String> FizzBuzzNumbers { get; set; }
    }
}
