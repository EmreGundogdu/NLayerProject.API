﻿using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepositoryGeneric<Category> repository) : base(unitOfWork, repository)
        {
        }

        public Task<Category> GetWithProductsByIdAsync(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
