using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Garage.Common.Interfaces;
using Garage.Common.Repositories;
using Garage.Data.Contexts;
using Garage.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Garage.Common
{
    public class UnitOfWork: IUnitOfWork 
    {
        private readonly ApplicationContext _context;
        private IRepository<Product> _productRepo;
        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
        }

        public virtual IRepository<Product> ProductRepository => _productRepo ??= new Repository<Product, ApplicationContext>(_context);
        
        public async void Dispose()
        {
           await _context.DisposeAsync();
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
