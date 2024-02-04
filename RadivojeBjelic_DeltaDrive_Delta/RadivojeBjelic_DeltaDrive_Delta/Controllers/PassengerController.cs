using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain;
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
        [HttpGet]
        public IActionResult GetPassengers()
        {
            try
            { 
                return Ok(_passengerInterface.GetAll().ProjectTo<PassengerDTO>(_mapper.ConfigurationProvider).ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("rides")]
        public IActionResult GetPassengersRideHistory([FromQuery]Guid passengerId)
        {
            try
            {
                var passengerRides = _passengerInterface.GetRideHistory(passengerId);
                if (passengerRides == null || !passengerRides.Any())
                {
                    return NotFound("No rides found for this passenger.");
                }
                return Ok(_mapper.Map<IEnumerable<RideDTO>>(passengerRides));
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetPassenger(Guid id)
        {
            try
            {
                var passenger = _passengerInterface.GetById(id);
                if (passenger == null)
                {
                    return NotFound();
                }

                return Ok(_mapper.Map<PassengerDTO>(passenger));

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, Passenger passenger)
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

