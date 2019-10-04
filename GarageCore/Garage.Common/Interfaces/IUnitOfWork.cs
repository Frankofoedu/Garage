 using System;
using System.Collections.Generic;
using System.Text;
 using System.Threading.Tasks;

 namespace Garage.Common.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Save();
    }
}
