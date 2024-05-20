using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odysseycs.Application.Interfaces
{
    public interface IUnitOfWork
    {
        //IstockExchangeRepo _IstockExchangeRepo { get; }
        //IstockOrderRepo _IstockOrderRepo { get; }
        //IstockPriceRepo _IstockPriceRepo { get; }

        Task<int> CommitAsync();
    }
}
