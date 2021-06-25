using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using THLTWLAB3.Models;

namespace THLTWLAB3.Controllers
{
    public class BookController : Controller
    {
        Model1 context = new Model1();
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListBook()
        {
            Model1 context = new Model1();
            var listBook = context.Books.ToList();
            return View(listBook);
        }
        [Authorize]
        public ActionResult Buy(int id)
        {
            Model1 context = new Model1();
            Book book = context.Books.SingleOrDefault(p => p.id == id);
            if(book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Create(Book book)
        {
            context.Books.AddOrUpdate(book);
            context.SaveChanges();
            
            return RedirectToAction("ListBook");


        }
        public ActionResult Edit(int id)
        {
            Book book = context.Books.SingleOrDefault(p => p.id == id);
            if(book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        [HttpPost]
        [Authorize]

        public ActionResult Edit(Book book/*int id,string name, string title, string author, string img,int price*/)
        {
            //var books = new List<Book>();
            //if (id == null)
            //{
            //    return HttpNotFound();
            //}
            //foreach (Book b in books)
            //{
            //    if (b.id == book.id)
            //    { 
            //        b.id = id;          
            //        b.description = description;
            //        b.title = title;
            //        b.author = author;
            //        b.img = img;
            //        b.price
            //        break;
            //    }
            //}

            Book Edit = context.Books.FirstOrDefault(p => p.id == book.id);
            if(Edit != null)
            {
                context.Books.AddOrUpdate(book);
                context.SaveChanges();
            }
            return RedirectToAction("ListBook");


        }
        public ActionResult Delete(int id)
            
        {
            Book book = context.Books.SingleOrDefault(p => p.id == id);
            if(book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        [HttpPost]
        [Authorize]
        public ActionResult DeleteBook( int id)
        {
           
            Book Delete = context.Books.SingleOrDefault(p => p.id == id);
           
            if(Delete != null)
            {
                context.Books.Remove(Delete);
                context.SaveChanges();
            }
            return RedirectToAction("ListBook");
        }


    }
}