﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer, ReCapContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (ReCapContext context=new ReCapContext())
            {
                var result = from c in context.Customers
                             join b in context.Users
                             on c.UserId equals b.Id
                             select new CustomerDetailDto
                             {
                                 CustomerId = b.Id,
                                 CompanyName = c.CompanyName,
                                 FirstName = b.FirstName,
                                 LastName = b.LastName,
                             };
                return result.ToList();
            }
            
        }
    }
}
