using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RadivojeBjelic_DeltaDrive_Delta.Interfaces;
using RadivojeBjelic_DeltaDrive_Delta.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RadivojeBjelic_DeltaDrive_Delta.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : Controller
    {
        private readonly IPassengerInterface _passengerInterface;
        private readonly IMapper _mapper;

        public PassengerController(IPassengerInterface passengerRepository, IMapper mapper)
        {
            _passengerInterface = passengerRepository;
            _mapper = mapper;
        }
        // GET: api/values
        [HttpGet]
        public IActionResult GetPassengers()
        {
            return Ok(_passengerInterface.GetAll().ProjectTo<PassengerDTO>(_mapper.ConfigurationProvider).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetPassenger(Guid id)
        {
            var passenger = _passengerInterface.GetById(id);
            if (passenger == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PassengerDTO>(passenger));
        }

        [HttpPost]
        public IActionResult PostPassenger(Passenger passenger)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _passengerInterface.Add(passenger);
            return CreatedAtAction("GetPassenger", new { id = passenger.PassengerId }, passenger);
        }

        [HttpPut("{id}")]
        public IActionResult PutPassenger(Guid id, Passenger passenger)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != passenger.PassengerId)
            {
                return BadRequest();
            }

            try
            {
                _passengerInterface.Update(passenger);
            }
            catch
            {
                return BadRequest();
            }

            return Ok(passenger);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var passenger = _passengerInterface.GetById(id);
            if (passenger == null)
            {
                return NotFound();
            }
            _passengerInterface.Delete(passenger);
            return NoContent();
        }
    }
}

