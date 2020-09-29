using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ten_minutes_aspnetcore.Controllers
{
    [Route("api/Seatings")]
    [ApiController]
    public class SeatingsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var seatings = new List<Seating>
            {
                new Seating { User = "Alice", Extension = "3333", CellPhone = "0911222333", Position = "1-1" },
                new Seating { User = "Bob", Extension = "3111", CellPhone = "0922222333", Position = "1-2" }
            };

            return Ok(seatings);
        }
    }

    public class Seating
    {
        public string User { get; set; }
        public string Extension { get; set; }
        public string CellPhone { get; set; }
        public string Position { get; set; }
    }
}
