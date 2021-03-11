//Model holds both session and cart object

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment5.Infrastructure;
using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment5.Pages
{
    public class AddCartModel : PageModel
    {
        private IBookRepository repository;

        public AddCartModel (IBookRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = ReturnUrl ?? "/";
        }

        public IActionResult OnPost(long Id, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(p => p.Id == Id);

            Cart.AddItem(book, 1);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long Id, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Book.Id == Id).Book);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
