using ApiFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiFirst.Data;

public class CarRepository : ICarInterface
{
    private readonly CarDbContext _carDbContext;

    public CarRepository(CarDbContext carDbContext)
    {
        _carDbContext = carDbContext;
    }
    public async Task AddCarAsync(CarDto carDto)
    {
        _carDbContext.Cars.Add(new Car()
        {
            Brand = carDto.Brand,
            Name = carDto.Name,
            Price = carDto.Price,
            ImageUrl = carDto.ImageUrl,
        });
        await _carDbContext.SaveChangesAsync();
    }

    public async Task DeleteByIdAsync(int id)
    {
        var curCar = await GetByIdAsync(id);
        _carDbContext.Cars.Remove(curCar);
        await _carDbContext.SaveChangesAsync();
    }

    public Task<List<Car>> GetAllAsync()
        => _carDbContext.Cars.ToListAsync();

    public async Task<Car> GetByIdAsync(int id)
        => await _carDbContext.Cars.FirstOrDefaultAsync(i => i.Id == id);

    public void Update(Car car)
    {
        _carDbContext.Cars.Update(car);
        _carDbContext.SaveChanges();
    }
}
