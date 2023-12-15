using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
               var result = from c in context.Customers
                             join r in context.Rentals
                             on c.UserId equals r.CustomerId
                             join u in context.Users
                             on c.UserId equals u.Id
                             join cc in context.Cars
                             on r.CarId equals cc.Id
                             join b in context.Brands
                             on cc.BrandId equals b.BrandId
                             select new RentalDetailDto
                             {
                                 CarId = cc.Id,
                                 CustomerId = c.UserId,
                                 CustomerFullName=$"{u.FirstName} {u.LastName}",
                                 ModelFullName=$"{b.BrandName} {cc.CarName}",
                                 RentalId = r.Id,
                                 RentDate = r.RentDate,
                                 ReturnDate = (DateTime)r.ReturnDate,
                                 CarName=cc.CarName
                                    
                                 
                             };
                             return result.ToList();
        
            }

        }
    }
}
