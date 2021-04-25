using Core.Models;
using Core.Services;
using Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Product> AddAsync(Product entity)
        {
            await _unitOfWork.Product.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<Product>> AddRangeAsync(IEnumerable<Product> entities)
        {
            await _unitOfWork.Product.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            return entities;
        }

        public async Task<IEnumerable<Product>> Where(Expression<Func<Product, bool>> predicate)
        {
            return await _unitOfWork.Product.Where(predicate);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _unitOfWork.Product.GetAllAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _unitOfWork.Product.GetByIdAsync(id);
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            return await _unitOfWork.Product.GetWithCategoryByIdAsync(productId);
        }

        public void Remove(Product entity)
        {
            _unitOfWork.Product.Remove(entity);
            _unitOfWork.Commit();
        }

        public void RemoveRange(IEnumerable<Product> entities)
        {
            _unitOfWork.Product.RemoveRange(entities);
            _unitOfWork.Commit();
        }

        public async Task<Product> SingleOrDefaultAsync(Expression<Func<Product, bool>> predicate)
        {
            return await _unitOfWork.Product.SingleOrDefaultAsync(predicate);
        }

        public Product Update(Product entity)
        {
            var updateProduct = _unitOfWork.Product.Update(entity);
            _unitOfWork.Commit();
            return updateProduct;
        }
    }
}
