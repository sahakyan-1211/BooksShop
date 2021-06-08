using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationUniversity.Data;
using WebApplicationUniversity.Models;

namespace BooksShop.Controllers
    {
    public class SearchController : Controller
        {
        private readonly BooksShopContext _context;

        public SearchController (BooksShopContext context)
            {
            _context = context;
            }
        // GET: Movies
        public async Task<IActionResult> Index (int bookRating, string searchString)
            {
            // Use LINQ to get list of genres.
            IQueryable<int> genreQuery = from m in _context.Book
                                         orderby m.Rating
                                         select m.Rating;

            var books = from m in _context.Book
                        select m;

            if ( !string.IsNullOrEmpty (searchString) )
                {
                books = books.Where (s => s.Title.Contains (searchString));
                }

            if ( !string.IsNullOrEmpty (bookRating.ToString ()) )
                {
                books = books.Where (x => x.Rating == bookRating);
                }

            var bookRatingVM = new BookRatingViewModel
                {
                Ratings = new SelectList (await genreQuery.Distinct ().ToListAsync ()),
                Books = await books.ToListAsync ()
                };

            return View (bookRatingVM);
            }
        }
    }
