using ProductApp.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductViewDto>> GetAllProducts();
    }
}
