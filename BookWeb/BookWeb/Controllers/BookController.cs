using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BookWeb.Entities;
using BookWeb.Enums;
using BookWeb.Interfaces;
using BookWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookWeb.Controllers
{
    //[Route("api/book")]
    //[ApiController]
    public class BookController : BaseController
    {
        private IBook _book;
        private IAuthor _author;
        private IGenre _genre;
        private readonly UserManager<ApplicationUser> _userManager;
        public BookController(IBook book, IAuthor author, IGenre genre, UserManager<ApplicationUser> userManager)
        {
            _book = book;
            _author = author;
            _genre = genre;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _book.GetAll();

            if (model != null)
                return View(model);
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var author = await _author.GetAll();
            var genre = await _genre.GetAll();
            
            var authorList = author.Select(a => new SelectListItem()
            {
                Value = a.Id.ToString(),
                Text = a.Title + " " + a.Name
            });

            var genreList = genre.Select(g => new SelectListItem()
            {
                Value = g.Id.ToString(),
                Text = g.Name
            });

            ViewBag.genre = genreList;
            ViewBag.author = authorList;
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            book.CreatedBy = _userManager.GetUserName(User);
            book.DateCreated = DateTime.Now;
            var createBook = await _book.AddAsync(book);

            if (createBook)
            {
                Alert("Book created successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Book not created!", NotificationType.error);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editBook = await _book.GetById(id);

            if (editBook == null)
            {
                
                return RedirectToAction("Index");
            }
            
            return View(editBook);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Book book)
        {
            var updateBook = await _book.Update(book);

            if (updateBook)
            {
                Alert("Book edited successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("An error occured while trying to edit this book", NotificationType.error);
            }
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var deleteBook = await _book.Delete(id);
            if (deleteBook)
            {
                Alert("Book deleted", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Book not deleted", NotificationType.error);
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
