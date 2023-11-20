using ApiFirst.Models;

namespace ApiFirst.Data;

public interface ICarInterface
{
    Task<List<Car>> GetAllAsync();
    Task<Car> GetByIdAsync(int id);
    Task AddCarAsync(CarDto carDto);
    void Update(Car car);
    Task DeleteByIdAsync(int id);

}
