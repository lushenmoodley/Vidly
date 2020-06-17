using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication75.Models
{
    public class Movies
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Movie Name")]
        public string MovieName { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<DateTime> ReleaseDate { get; set; }     
        
        [Required]
        [Range(0, 10000)]
        public Nullable<decimal> Price { get; set; }

        [Required]
        [Display(Name = "Total Stock Items")]
        [Range(0, 10000)]
        public Nullable<int> NumberInStock { get; set; } 

        [Required]
        [Display(Name = "Total Stock Items Avaliable")]
        [Range(0, 10000)]
        public Nullable<int> NumberAvaliable { get; set; }

        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}