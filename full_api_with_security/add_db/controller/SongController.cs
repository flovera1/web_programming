using add_db.Data;
using add_db.model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace add_db.controller
{
  
  [ApiController]
  [Route("[controller]")]
  public class SongsController : ControllerBase
{	
  private IAnonymousEurosongDataContext _data;
  
  public SongsController(IAnonymousEurosongDataContext data)
  {
    _data = data;
  }
 
  [HttpGet]
  [EnableCors("MyPolicy")]

  public ActionResult<IEnumerable<Song>> Get()
  {
    return Ok(_data.GetSongs());
  }
 
	
[HttpPost]
[Authorize(Policy = "BasicAuthentication")]
public ActionResult Post(Song song)
{
    _data.AddSong(song);
    return Ok("Song posted");
}

[HttpGet("{id}")]
   
 public ActionResult<Song> Get(int id)
 {
   return Ok(_data.GetSongById(id));
 }  
}
}