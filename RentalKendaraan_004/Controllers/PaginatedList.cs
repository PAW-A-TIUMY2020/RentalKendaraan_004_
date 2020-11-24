using System;
using System.Linq;
using System.Threading.Tasks;

namespace RentalKendaraan_004.Controllers
{
    internal class PaginatedList<T>
    {
        internal static Task<string> CreateAsync<TEntity>(IQueryable<TEntity> queryable, int v, int pageSize) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}