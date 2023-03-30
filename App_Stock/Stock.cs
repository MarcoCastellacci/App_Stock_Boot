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
        public float Cantidad { set; get; }


        public float StockValorizado()
        {
            return this.Cantidad * this.ArticuloEnDeposito.CalcularPrecio();
    }
    }
}
