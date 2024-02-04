using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore;
using AutoMapper;
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
    public class RideController : Controller
    {
        private readonly IRideService _rideService;
        private readonly IMapper _mapper;

        public RideController(IRideService rideRepository, IMapper mapper)
        {
            _rideService = rideRepository;
            _mapper = mapper;
        }
        //ubaceno zbog CreatedAtAction za vracanje 201 created
        [HttpGet("{id}")]
        public IActionResult GetRide(Guid id)
        {
            try
            {
                var ride = _rideService.GetById(id);
                if (ride == null)
                {
                    return NotFound();
                }

                return Ok(_mapper.Map<RideDTO>(ride));

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //Bukiranje voznje
        [HttpPost("bookRide")]
        public IActionResult BookARide([FromBody]RideDTO rideDTO, [FromQuery] Guid driverId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var ride = _mapper.Map<Ride>(rideDTO);
                var result= _rideService.BookARide(ride, driverId);
                return CreatedAtAction("GetRide", new { id = result.RideId }, result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("nearestDrivers/{passengerLatitude}/{passengerLongitude}")]
        public IActionResult GetNearestDrivers(double passengerLatitude, double passengerLongitude)
        {
            try
            {
                var selectedDrivers = _rideService.GetNearestTenDrivers(passengerLatitude,passengerLongitude);
                if (selectedDrivers == null)
                {
                    return NotFound();
                }

                return Ok(_mapper.Map<IEnumerable<DriverDTO>>(selectedDrivers));

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //simulacija same voznje, doduse uradjena je za linearno kretanje, u realnom scenariju bi trebalo da se ukljuci neki google maps API ili tako nesto
        [HttpPost("simulateRide")]
        public async Task<IActionResult> SimulateRide([FromQuery] Guid rideId)
        {
            try
            {
                await _rideService.SimulateRide(rideId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //metoda za ocenu
        [HttpPost("rating")]
        public IActionResult AddRating(Rating rating)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                _rideService.AddRating(rating);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

