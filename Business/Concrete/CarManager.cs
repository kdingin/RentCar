using Business.Abstract;
using Core.Untilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
          

        }
        public IResult Add(Car car)
        {
            if (car.CarName.Length >= 2&&car.DailyPrice>0)
            {
                _carDal.Add(car);
                return new SuccessResult();
            }
            
            else
            {
                return new ErrorResult("ürün ismi minimum 2 karakter olmalıdır.");
            }
            
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.Get(p => p.Id == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(p => p.BrandId == brandId);
        }

        

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(p => p.ColorId == colorId);

        }

        public List<Car> GetCarsByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);

        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult();
        }
    }
}
