using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication75.Models;
namespace WebApplication75.ViewModel
{
    public class NewMovieModel
    {
        public IEnumerable<Genre> GenreType { get; set; }
        public Movies Movie { get; set; }        
    }
}