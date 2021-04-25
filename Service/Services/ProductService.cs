using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepositoryGeneric<Product> repository) : base(unitOfWork, repository)
        {
        }

        public Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
