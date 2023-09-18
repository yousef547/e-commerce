﻿using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;
        public ProductRepository(StoreContext storeContext)
        {
            _context = storeContext;
        }
        public async Task<Products> GetProductByIdAsync(int id)
        {
            return await _context.products.FindAsync(id);
        }

        public async Task<IReadOnlyList<Products>> GetProductsAsync()
        {
            return await _context.products.ToListAsync();
        }
    }
}
