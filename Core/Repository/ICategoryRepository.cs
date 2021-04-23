using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public interface ICategoryRepository:IRepositoryGeneric<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int categoryId);
    }
}
