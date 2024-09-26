using System;
using concessionaria.Repositories;
using Concessionaria.Models;
using Microsoft.AspNetCore.Mvc;

namespace concessionaria.Controllers;

[ApiController]
[Route("[Controller]")]
public class CarController : ControllerBase
{
    private readonly IRepository<Car> _carRepository;

    public CarController(IRepository<Car> carRepository)
    {
        _carRepository = carRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Car>>> GetCars()
    {
        var cars = await _carRepository.GetAllAsync();
        return Ok(cars);
    }
}
