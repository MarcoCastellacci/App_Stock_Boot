using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseObjetos
{
    public class Stock
    {
        public Articulo ArticuloEnDeposito { set; get; }
        public Deposito DepositoDeGuarda { set; get; }
        public decimal Cantidad { set; get; }


        public decimal StockValorizado()
        {
            return this.Cantidad * this.ArticuloEnDeposito.CalcularPrecio();
    }
    }
}
