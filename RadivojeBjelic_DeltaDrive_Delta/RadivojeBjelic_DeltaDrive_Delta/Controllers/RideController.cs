using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly IRideInterface _rideRepository;
        private readonly IMapper _mapper;

        public RideController(IRideInterface rideRepository, IMapper mapper)
        {
            _rideRepository = rideRepository;
            _mapper = mapper;
        }
        //ubaceno zbog CreatedAtAction za vracanje 201 created
        [HttpGet("{id}")]
        public IActionResult GetRide(Guid id)
        {
            try
            {
                var ride = _rideRepository.GetById(id);
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
                var result=_rideRepository.BookARide(ride, driverId);
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
                var selectedDrivers = _rideRepository.GetNearestTenDrivers(passengerLatitude,passengerLongitude);
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
        //ova metoda je u kontroleru iz razloga sto bi mozda mogla da postoji opcija da korisnik pre zakazivanja izracuna cenu ukoliko to zeli
        [HttpGet("calculateTotalPrice")]
        public IActionResult CalculateTotalPrice([FromQuery]Guid driverId, [FromQuery] double startLatitude, [FromQuery]double startLongitude, [FromQuery] double EndLatitude,
            [FromQuery] double EndLongitude)
        {
            try
            {
                var totalPrice = _rideRepository.CalculateTotalPrice(driverId, startLatitude, startLongitude, EndLatitude, EndLongitude);
                return Ok(totalPrice);
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
                await _rideRepository.SimulateRide(rideId);
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
                _rideRepository.AddRating(rating);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

