using Business.Concrete;
using Business.Constants;
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
            //CarManagerTest3();
            RentalEvent();
            //CustomerEvent();
            //UserAdded();
            //UserDeleted();
            //Console.WriteLine("**********************");
            //CarManagerTest2();
            //Console.WriteLine("*********************");
            //BrandTest();
            //ColorTest2();

            //ColorTest();

            //BrandTest2();

        }
        private static void UserDeleted()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Delete(new User { Id = 1004});
            
        }
        private static void UserDelete()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Delete(new User {Id=1003});

            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName);
            }

        }
        private static void RentalEvent()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental();
            rental.CarId = 4;
            rental.CustomerId = 5;
            rental.RentDate = new DateTime(2022,08,9);
            rental.ReturnDate = null;

            var result = rentalManager.Add(rental);
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void CustomerEvent()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { UserId = 1004,CompanyName="Erikli"});

            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }

        private static void CarManagerTest3()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine("Kullanıcı Adı Soyadı:{0} {1} {2}", user.FirstName, user.LastName, user.Id);
            }

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(3).Data)
            {
                Console.WriteLine(car.Id +"--"+car.CarName+ "--" + car.DailyPrice + "--" + car.Description + "--" + car.ModelYear);
            }
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetByBrandId(1).Message)
            {
                Console.WriteLine(brand);
            }


            CarManager carManager1 = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName+"/"+car.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        

        private static void ColorTest2()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer {UserId=8,CompanyName="Hepsiburada"});

            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.UserId+"**"+customer.CompanyName+"**");
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetByColorId(3).Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetByBrandId(2).Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }
        private static void BrandTest2()
        {
            BrandManager brandManager2 = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager2.GetByBrandId(3).Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }
    }
}
