using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationUniversity.Data;
using System;
using System.Linq;
using WebApplicationUniversity.Models;

namespace MvcMovie.Models
    {
    public static class SeedData
        {
        public static void Initialize (IServiceProvider serviceProvider)
            {
            using ( var context = new BooksShopContext (
                serviceProvider.GetRequiredService<
                    DbContextOptions<BooksShopContext>> ()) )
                {
                // Look for any movies.
                if ( context.Book.Any () )
                    {
                    return;   // DB has been seeded
                    }

                context.Book.AddRange (
                    new Book
                        {
                        Title = "The Daughter's Tale: A Novel",
                        Description = "Armando Lucas Correa is an award-winning journalist",
                        ReleaseDate = DateTime.Parse ("2019-5-7"),
                        Rating = 4,
                        Price = 26.65M,
                        Genre = "Romantic Comedy"
                        },

                    new Book
                        {
                        Title = "Unfaithful",
                        Description = "An absolutely gripping psychological thriller",
                        ReleaseDate = DateTime.Parse ("2020-11-24"),
                        Rating = 3,
                        Price = 9.89M,
                        Genre = "Drama"
                        },

                    new Book
                        {
                        Title = "The Song of Achilles",
                        Description = "An absolutely gripping psychological thriller",
                        ReleaseDate = DateTime.Parse ("2012-3-6"),
                        Rating = 5,
                        Price = 25.19M,
                        Genre = "Comedy"
                        },

                    new Book
                        {
                        Title = "Red, White & Royal Blue: A Novel",
                        Description = " Instant NEW YORK TIMES and USA TODAY bestseller ",
                        ReleaseDate = DateTime.Parse ("2019-5-14"),
                        Rating = 2,
                        Price = 29.4M,
                        Genre = "Thriller"
                        }
                );
                context.SaveChanges ();

                if ( context.Book.Any () )
                    {
                    return;  // DB has been seeded.
                    }
                }
            }
        }
    }