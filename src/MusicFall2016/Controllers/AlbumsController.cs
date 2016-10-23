using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicFall2016.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicFall2016.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly MusicDbContext _context;

        public AlbumsController(MusicDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Details()
        {
            var albums = _context.Albums.Include(a => a.Artist).Include(a => a.Genre).ToList();
            return View(albums);
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

        public IActionResult Delete()
        {
            return View();
        }

        
/*
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var album = _context.Albums
                .Include(a => a.Artist)
                .Include(a => a.Artist)
                .SingleOrDefault(a => a.AlbumID == id);

            if (album == null)
            {
                return NotFound();
            }
            return View(album);
        }
*/
    }
}
