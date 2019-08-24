using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNetCoreWebApi.Model
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "{0} field is required!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "{0} field is required!")]
        public string Genre { get; set; } 

        [Required(ErrorMessage = "{0} field is required!")]
        [StringLength(500, ErrorMessage = "{0} field must be longer than 100 characters")]
        public string Synopsis { get; set; }
    }
}
