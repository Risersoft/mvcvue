using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWithVue.Controllers
{
    public class AlbumController : Controller
    {
        private readonly ILogger<AlbumController> _logger;

        public AlbumController(ILogger<AlbumController> logger)
        {
            _logger = logger;
        }

        public IList<AlbumModel> GetAlbums()
        {
            IList<AlbumModel> albList = new List<AlbumModel>()
            {
                new AlbumModel() {
                    AlbumId = 1,
                    Entered = DateTime.Now,
                    albClass = "org.cloudfoundry.samples.music.domain.Album",
                    Artist = "Nirvana",
                    Title = "Nevermind",
                    YearReleased = "1991",
                    Genre= "Rock"
                },
                new AlbumModel() {
                    AlbumId = 2,
                    Entered = DateTime.Now,
                    albClass = "org.cloudfoundry.samples.music.domain.Album",
                    Artist="The Beach Boys",
                    Title="Pet Sounds",
                    YearReleased="1966",
                    Genre="Pop"
                },
                new AlbumModel() {
                    AlbumId = 3,
                    Entered = DateTime.Now,
                    albClass = "org.cloudfoundry.samples.music.domain.Album",
                    Artist = "Marvin Gaye",
                    Title = "What's Going On",
                    YearReleased = "1971",
                    Genre = "Rock"
                },
                new AlbumModel(){
                    AlbumId = 4,
                    Entered = DateTime.Now,
                    albClass = "org.cloudfoundry.samples.music.domain.Album",
                    Artist = "Jimi Hendrix Experience",
                    Title = "Are You Experienced?",
                    YearReleased = "1967",
                    Genre = "Blue",
                },
                new AlbumModel(){
                    AlbumId = 5,
                    Entered = DateTime.Now,
                    albClass = "org.cloudfoundry.samples.music.domain.Album",
                    Artist = "U2",
                    Title = "The Joshua Tree",
                    YearReleased = "1987",
                    Genre = "Rock"
                },
                new AlbumModel(){
                    AlbumId = 6,
                    Entered = DateTime.Now,
                    albClass = "org.cloudfoundry.samples.music.domain.Album",
                    Artist = "The Beatles",
                    Title = "Abbey Road",
                    YearReleased = "1969",
                    Genre = "Blue",
                }
            };

            return albList;
        }

        //[Route("/album")]
        [HttpGet]
        public IActionResult Index()
        {
            IList<AlbumModel> albList = new List<AlbumModel>()
            {
                new AlbumModel() {
                    AlbumId = 1,
                    Entered = DateTime.Now,
                    albClass = "org.cloudfoundry.samples.music.domain.Album",
                    Artist = "Nirvana",
                    Title = "Nevermind",
                    YearReleased = "1991",
                    Genre= "Rock"
                },
                new AlbumModel() {
                    AlbumId = 2,
                    Entered = DateTime.Now,
                    albClass = "org.cloudfoundry.samples.music.domain.Album",
                    Artist="The Beach Boys",
                    Title="Pet Sounds",
                    YearReleased="1966",
                    Genre="Pop"
                },
                new AlbumModel() {
                    AlbumId = 3,
                    Entered = DateTime.Now,
                    albClass = "org.cloudfoundry.samples.music.domain.Album",
                    Artist = "Marvin Gaye",
                    Title = "What's Going On",
                    YearReleased = "1971",
                    Genre = "Rock"
                },
                new AlbumModel(){
                    AlbumId = 4,
                    Entered = DateTime.Now,
                    albClass = "org.cloudfoundry.samples.music.domain.Album",
                    Artist = "Jimi Hendrix Experience",
                    Title = "Are You Experienced?",
                    YearReleased = "1967",
                    Genre = "Blue",
                },
                new AlbumModel(){
                    AlbumId = 5,
                    Entered = DateTime.Now,
                    albClass = "org.cloudfoundry.samples.music.domain.Album",
                    Artist = "U2",
                    Title = "The Joshua Tree",
                    YearReleased = "1987",
                    Genre = "Rock"
                },
                new AlbumModel(){
                    AlbumId = 6,
                    Entered = DateTime.Now,
                    albClass = "org.cloudfoundry.samples.music.domain.Album",
                    Artist = "The Beatles",
                    Title = "Abbey Road",
                    YearReleased = "1969",
                    Genre = "Blue",
                }
            };

            var model = albList.ToList();

            return View(model);
        }       
        
        [Route("/album/{id}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            //var model = _db.Bugs.Find(id);
            var model = this.GetAlbums().Where(x => x.AlbumId == id);
            return Ok(model);
        }

        [Route("/album")]
        [HttpPost]
        public IActionResult Post(AlbumModel model)
        {
            return Ok(model);
        }

        [Route("/album")]
        [HttpPut]
        public IActionResult Put(AlbumModel model)
        {
            return Ok(model);
        }

        [Route("/album")]
        [HttpDelete]
        public IActionResult Delete(AlbumModel model)
        {
            return Ok(model);
        }        
    }
}
