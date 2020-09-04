using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCRUD.Models
{
    public class Books
    {
        public Guid BooksId { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Name { get; set; }

        [Required]
        [Range(0.01,99999)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
    }
}
