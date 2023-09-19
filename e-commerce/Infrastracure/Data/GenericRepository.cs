using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastracure.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly StoreContext _context;
        public GenericRepository(StoreContext storeContext)
        {
            _context = storeContext;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> GetEntityWithSpec(ISpecification<T> spac)
        {
            return await ApplySpecifications(spac).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spac)
        {
            return await ApplySpecifications(spac).ToListAsync();
        }

        private IQueryable<T> ApplySpecifications(ISpecification<T> specifications)
        {
            return SpecificationsEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), specifications);
        }
    }
}
