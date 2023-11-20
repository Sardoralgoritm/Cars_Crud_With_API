using ApiFirst.Data;
using ApiFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiFirst.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarsController : ControllerBase
{
    private readonly ICarInterface _carInterface;
    public CarsController(ICarInterface carInterface)
    {
        _carInterface = carInterface;
    }


    [HttpGet("GetAllCars")]
    public async Task<ActionResult<List<Car>>> GetCarsAsync()
    {
        var list = await _carInterface.GetAllAsync();
        return Ok(list);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetCar(int id)
    {
        var car = await _carInterface.GetByIdAsync(id);
        if (car == null)
        {
            return NotFound();
        }

        return Ok(car);
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateAsync(CarDto car)
    {
        await _carInterface.AddCarAsync(car);
        return Ok(car);
    }

    [HttpPut("Edit")]
    public IActionResult Edit(Car car)
    {
        _carInterface.Update(car);

        return Ok(car);
    }

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var cars = await _carInterface.GetAllAsync();
        if (!cars.Any(i => i.Id == id))
        {
            return NotFound();
        }

        await _carInterface.DeleteByIdAsync(id);
        cars = await _carInterface.GetAllAsync();
        return Ok(cars);
    }

}
