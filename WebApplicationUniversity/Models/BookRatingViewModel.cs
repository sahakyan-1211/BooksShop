using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationUniversity.Models
    {
    public class BookRatingViewModel
        {
        public List<Book> Books { get; set; }
        public SelectList Ratings { get; set; }
        public int BookRating { get; set; }
        public string SearchString { get; set; }

        }
    }
