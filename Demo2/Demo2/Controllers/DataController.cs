using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        // POST api/postexample
        [HttpPost]
        public ActionResult<string> Post([FromBody] string value)
        {

            return Ok($"Отримано значення: {value}");
        }

        // POST api/postexample/data
        [HttpPost("data")]
        public ActionResult<object> PostData([FromBody] DataModel data)
        {

            return Ok(new { Message = "Дані успішно отримано", Data = data });
        }
    }
}
