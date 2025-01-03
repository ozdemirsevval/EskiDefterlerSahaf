﻿using EskiDefterler.BusinessLogic.Abstract;
using EskiDefterler.Core.Entities.Abstract;
using EskiDefterler.DataAccess.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.BusinessLogic.Concrete
{
    public class Manager<T> : Repository<T>, IManager<T> where T : BaseEntity
    {
        public Task GetByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
