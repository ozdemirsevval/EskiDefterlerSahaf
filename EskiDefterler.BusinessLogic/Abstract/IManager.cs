using EskiDefterler.Core.Entities.Abstract;
using EskiDefterler.DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EskiDefterler.BusinessLogic.Abstract
{
    public interface IManager<T> : IRepository<T> where T : BaseEntity
    {
    }
}
