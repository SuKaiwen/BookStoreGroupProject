using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Business.Components.Interfaces
{
    public interface IStockProvider
    {
        void SellStock(Business.Entities.Stock pStock, int pQuantity);
    }
}
