using Odysseycs.Application.Interfaces;
using Odysseycs.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odysseycs.Infra.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IUniversityDbContext _databaseContext;
        private bool _disposed;

        public UnitOfWork(IUniversityDbContext databaseContext)
        {
            _databaseContext = databaseContext;
            //_IstockExchangeRepo = new StockExchangeRepo(this._databaseContext);
            //_IstockOrderRepo = new StockOrderRepo(this._databaseContext);
            //_IstockPriceRepo = new StockPriceRepo(this._databaseContext);
        }

        //public IstockExchangeRepo _IstockExchangeRepo { get; private set; }

        //public IstockOrderRepo _IstockOrderRepo { get; private set; }

        //public IstockPriceRepo _IstockPriceRepo { get; private set; }

        public async Task<int> CommitAsync()
        {
            return await _databaseContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
      
       

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    _databaseContext.Dispose();
            _disposed = true;
        }
    }
}
