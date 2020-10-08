using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ten_minutes_aspnetcore.Domain.Models;
using ten_minutes_aspnetcore.Domain.Repositories;

namespace ten_minutes_aspnetcore.Controllers
{
    [Route("api/seatings")]
    [ApiController]
    public class SeatingsController : ControllerBase
    {
        private readonly ISeatingRepository _seatingRepository;

        public SeatingsController(ISeatingRepository seatingRepository)
        {
            _seatingRepository = seatingRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var seatings = _seatingRepository.GetAll();

            return Ok(seatings);
        }
    }
}