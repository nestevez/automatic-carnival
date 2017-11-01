using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RESTauranter.Models;

namespace RESTauranter.Controllers
{
    public class HomeController : Controller
    {
        RestContext _context;
        public HomeController(RestContext context)
        {
            _context = context;
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/review/create/")]
        public IActionResult AddReview(ReviewViewModel incoming)
        {
            TryValidateModel(incoming);
            if(ModelState.IsValid)
            {
                Reviews review = new Reviews();
                review.reviewer = incoming.reviewer;
                review.restaurant = incoming.restaurant;
                review.reviewtext = incoming.reviewtext;
                review.stars = incoming.stars;
                review.visitdate = incoming.visitdate;
                _context.reviews.Add(review);
                _context.SaveChanges();
            }
            else
            {
                return View("Index");
            }
            return RedirectToAction("AllReviews");
        }

        [HttpGet]
        [Route("/review/all/")]
        public IActionResult AllReviews()
        {
            ViewBag.reviews = "";
            ViewBag.reviews = _context.reviews.OrderByDescending(rev => rev.visitdate).ToList();
            // System.Console.WriteLine(ViewBag.reviews);
            return View();
        }
    }
}
