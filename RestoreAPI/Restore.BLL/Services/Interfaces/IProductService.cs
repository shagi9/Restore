using Restore.BLL.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restore.BLL.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int id);
    }
}
