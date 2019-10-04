using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Garage.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Garage.Common
{
    public sealed class UnitOfWork<TContext>: IUnitOfWork where TContext : DbContext
    {
        private readonly TContext _context;

        public UnitOfWork(TContext context)
        {
            _context = context;
        }
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
