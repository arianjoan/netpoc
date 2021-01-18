using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Persistance.Repositories
{
    public interface IProductRepository
    {
         Task<IEnumerable<Product>> ListAsync();
    }
}