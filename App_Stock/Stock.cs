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

        public Stock(Articulo articuloEnDeposito, Deposito depositoDeGuarda, decimal cantidad)
        {
            ArticuloEnDeposito = articuloEnDeposito;
            DepositoDeGuarda = depositoDeGuarda;
            Cantidad = cantidad;
        }

        public string StockValorizado()
        {
            return "El precio unitario es: " + this.ArticuloEnDeposito.CalcularPrecio() + " Su Stock Actual: " + this.Cantidad + Environment.NewLine +"El Stock Valorizado es : " + this.Cantidad * this.ArticuloEnDeposito.CalcularPrecio();
        }
    }
}
