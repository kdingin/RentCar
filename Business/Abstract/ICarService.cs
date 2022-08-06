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
        List<Car> GetAll();
        Car GetById(int id);
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        List<Car> GetCarsByDailyPrice(decimal min, decimal max);
        List<CarDetailDto> GetCarDetails();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
