using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateController : ControllerBase
    {
        

        [HttpGet("Add/{left}/{right}")]
        public int Get(int left,int right)
        {
            var calculater = new Calculator();
            return calculater.Sum(left,right);
        }
    }
}
