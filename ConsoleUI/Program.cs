using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManagerTest3();
           // CarManagerTest2();

            // ColorTest2();

            //ColorTest();

            //BrandTest2();

        }

        private static void CarManagerTest3()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.Id + "--" + car.DailyPrice + "--" + car.Description + "--" + car.ModelYear);
            }
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetByBrandId(1))
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarManagerTest2()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine(carManager.GetById(2).DailyPrice);
        }

        private static void ColorTest2()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color colors = new Color { ColorId = 3, ColorName = "Maroon" };

            colorManager.Update(colors);
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetByColorId(3))
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetByBrandId(2))
            {
                Console.WriteLine(brand.BrandName);
            }
        }
        private static void BrandTest2()
        {
            BrandManager brandManager2 = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager2.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }
    }
}
