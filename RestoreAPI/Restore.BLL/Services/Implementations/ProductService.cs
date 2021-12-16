using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Restore.BLL.Dtos;
using Restore.BLL.Services.Interfaces;
using Restore.DLL.DataContext;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restore.BLL.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly DBContext context;
        private readonly IMapper mapper;
        public ProductService(DBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<ProductDto> GetProductById(int id)
        {
            var product = await context.Products.FindAsync(id);

            if (product != null)
            {
                return mapper.Map<ProductDto>(product);
            }

            return null;
        }

        public async Task<List<ProductDto>> GetProducts()
        {
            return await context.Products
                .ProjectTo<ProductDto>(mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
