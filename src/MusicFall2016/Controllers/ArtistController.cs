using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicFall2016.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicFall2016.Controllers
{
    public class ArtistController : Controller
    {
        private readonly MusicDbContext _context;

        public ArtistController(MusicDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Details()
        {
            var artist = _context.Artists.ToList();
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Retrieve()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

    }
}
