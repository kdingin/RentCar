using Core.Untilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
     public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<Car>> GetCarsByDailyPrice(decimal min, decimal max);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetCarsByBrandIdWithDetails(int brandId);
        IDataResult<List<CarDetailDto>> GetCarsByColorIdWithDetails(int colorId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
