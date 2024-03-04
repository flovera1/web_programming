using Microsoft.AspNetCore.Mvc;

namespace test.controller{
[ApiController]
[Route("[controller]")]
public class SongsController : ControllerBase
{

    static private List<Song> songslist = new List<Song>();


  [HttpGet]
  public ActionResult<IEnumerable<Song>> Get()
  {
    return Ok(songslist);
  }

  [HttpPost]
  public ActionResult Post([FromBody] Song song)
  { 
    songslist.Add(song);
    return Ok("Hooray");
  }
}

}