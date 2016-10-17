using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicFall2016.Models
{
    public class Album
    {
        
        public int AlbumID { get; set; }
        public string Title { get; set; }
        //[Required(ErrorMessage = "Please type in a price!")]
        //[Range(typeof(Decimal), ".01", "100.0")(ErrorMessage = "Invalid input!"]
        public decimal Price { get; set; }

        // Foreign key
        public int ArtistID { get; set; }
        // Navigation property
        public Artist Artist { get; set; }

        public int GenreID { get; set; }
        public Genre Genre { get; set; }

       
    }
}
