//Model for putting information into our database

using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDbContext>();

            //first function checks if this information already exsists so it does not add it twice
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            //adds data into database
            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    
                    new Book
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        ClassificationCategory= "Fiction, Classic",
                        Price = 9.95
                    },

                     new Book
                     {
                         Title = "Team of Rivals",
                         Author = "Doris Kearns Goodwin",
                         Publisher = "Simon & Schuster",
                         ISBN = "978-0743270755",
                         ClassificationCategory = "Non-Fiction, Biography",
                         Price = 14.58
                     },

                      new Book
                      {
                          Title = "The Snowball",
                          Author = "Alice Schroeder",
                          Publisher = "Bantam",
                          ISBN = "978-0553384611",
                          ClassificationCategory = "Non-Fiction, Biography",
                          Price = 21.54
                      },

                       new Book
                       {
                           Title = "American Ulysses",
                           Author = "Ronald C. White",
                           Publisher = "Random House",
                           ISBN = "978-0812981254",
                           ClassificationCategory = "Non-Fiction, Biography",
                           Price = 11.61
                       },

                        new Book
                        {
                            Title = "Unbroken",
                            Author = "Laura Hillenbrand",
                            Publisher = "Random House",
                            ISBN = "978-0812974492",
                            ClassificationCategory = "Non-Fiction, Historical",
                            Price = 13.33
                        },

                         new Book
                         {
                             Title = "The Great Train Robbery",
                             Author = "Michael Crichton",
                             Publisher = "Vintage",
                             ISBN = "978-0804171281",
                             ClassificationCategory = "Fiction, Historical Fiction",
                             Price = 15.95
                         },

                          new Book
                          {
                              Title = "Deep Work",
                              Author = "Cal Newport",
                              Publisher = "Grand Central Publishing",
                              ISBN = "978-1455586691",
                              ClassificationCategory = "Non-Fiction, Self-Help",
                              Price = 14.99
                          },

                           new Book
                           {
                               Title = "It's Your Ship",
                               Author = "Michael Abrashoff",
                               Publisher = "Grand Central Publishing",
                               ISBN = "978-1455523023",
                               ClassificationCategory = "Non-Fiction, Self-Help",
                               Price = 21.66
                           },

                            new Book
                            {
                                Title = "The Virgin Way",
                                Author = "Richard Branson",
                                Publisher = "Portfolio",
                                ISBN = "978-1591847984",
                                ClassificationCategory = "Non-Fiction, Business",
                                Price = 29.16
                            },

                             new Book
                             {
                                 Title = "Sycamore Row",
                                 Author = "John Grisham",
                                 Publisher = "Bantam",
                                 ISBN = "978-0553393613",
                                 ClassificationCategory = "Fiction, Thrillers",
                                 Price = 15.03
                             }

               );

               context.SaveChanges();
            }
        }
    }
}
