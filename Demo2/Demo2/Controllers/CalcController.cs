using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        [HttpGet("Add")]
        public ActionResult<double> AddValues(double num, double number)
        {
            var result = num + number;
            return result;
        }

        [HttpGet("Substract")]
        public ActionResult<double> SubstractValues(double num, double number)
        {
            var result = num - number;
            return result;
        }

        [HttpGet("Divide")]
        public ActionResult<double> DivideValues(double num, double number)
        {
            var result = num / number == 0 ? 1: number;
            return result;
        }


        [HttpGet("Multiply")]
        public ActionResult<double> MultiplyValues(double num, double number)
        {
            var result = num * number;
            return result;
        }
    }
}
