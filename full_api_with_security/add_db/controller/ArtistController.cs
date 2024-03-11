
using add_db.Data;
using add_db.model;
using Microsoft.AspNetCore.Mvc;

namespace add_db.Controllers
{
    [ApiController]
  [Route("[controller]")]
    public class ArtistController : ControllerBase
    {
        private IAnonymousEurosongDataContext _data;
        public ArtistController(IAnonymousEurosongDataContext data)
        {
            _data = data;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Artist>> Get()
        {
            return Ok(_data.GetArtist());
        }

        [HttpPost]
        public ActionResult Post([FromBody] Artist artist)
        {
            _data.AddArtist(artist);
            return Ok("Hooray, we have a new artist!");
        }

        [HttpGet("{id}")]
        public ActionResult<Artist> Get(int id)
        {
            return Ok(_data.GetArtistById(id));
        }
        [HttpGet("{id}/songs")]

        public ActionResult<Song> GetSongsByArtistId(int id)
        {
            return Ok(_data.getSongsByArtistID(id));
        }

    }
}