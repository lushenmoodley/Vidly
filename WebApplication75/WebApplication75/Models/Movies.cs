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
        [Display(Name = "Movie Name")]
        public string MovieName { get; set; }
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }       
        public decimal Price { get; set; }
        [Display(Name = "Total Stock Items")]
        public int NumberInStock { get; set; }
        [Display(Name = "Total Stock Items Avaliable")]
        public int NumberAvaliable { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}