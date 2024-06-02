using AutoMapper;
using carRental.Api.Models;
using carRental.core.DTOs;
using carRental.core.Models;
using carRental.core.Services;
using carRental.service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace carRental.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        private readonly IMapper _mapper;
        public CarController(ICarService carService, IMapper mapper)
        {
            _carService = carService;
            _mapper = mapper;
        }

        // GET: api/<CarController>
        // GET: api/<CarsController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var cars = await _carService.GetAllAsync();
            var carsDto = _mapper.Map<IEnumerable<CarDto>>(cars);
            return Ok(carsDto);
        }

        // GET api/<CarsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var car = await _carService.GetByIdAsync(id);
            var carDto = _mapper.Map<CarDto>(car);
            return Ok(carDto);
        }

        // POST api/<CarsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CarPostModel car)
        {
            var carToAdd = new Car { Loc = car.Loc, Status = car.Status };
            var newCar = await _carService.AddAsync(carToAdd);
            return Ok(newCar);
        }

        // PUT api/<CarsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] CarPostModel car)
        {
            var carToAdd = new Car { Loc = car.Loc, Status = car.Status };
            var newCar = await _carService.UpdateAsync(id, carToAdd);
            return Ok(newCar);
        }

        // DELETE api/<CarsController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _carService.DeleteAsync(id);
        }
    }
}
