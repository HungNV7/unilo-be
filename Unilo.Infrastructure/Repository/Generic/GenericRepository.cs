using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Unilo.Infrastructure.Repository.Generic
{
    class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        
    }
}
