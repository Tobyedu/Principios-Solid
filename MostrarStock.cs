using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    class MostrarStock
    {
        public MostrarStock()
        {

        }
        public void Stocksito(StockProductos stockProductos)
        {

            //principio Openclosed 
            
            stockProductos.ImprimirStockProductos();

        }
    }
}
