﻿using Core.Entities.Concrete;
using Core.Untilities.Results;
using Core.Untilities.Security.JWT;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByMail(string email);
    }

}
