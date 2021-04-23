﻿using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public interface IProductRepository
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}
