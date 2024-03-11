using add_db.Data;
using add_db.model;
using Microsoft.AspNetCore.Mvc;

namespace add_db.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VotesController : ControllerBase
    {
        private IAnonymousEurosongDataContext _data;
        public VotesController(IAnonymousEurosongDataContext data)
        {
            _data = data;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Vote>> Get()
        {
            return Ok(_data.GetVote());
        }
        [HttpPost]
        public ActionResult Post([FromBody] Vote vote)
        {
            _data.AddVote(vote);
            return Ok("Hooray!... Added!");
        }
        [HttpGet("{id}")]
        public ActionResult<Vote> Get(int id)
        {
            return Ok(_data.GetVoteBySongId(id));
        }
    }
}