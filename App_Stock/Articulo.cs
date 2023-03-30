using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseObjetos
{
    public class Articulo
    {
        //Propiedades de un Objeto
        public int Numero { set; get; }
        public string Nombre { set; get; }
        public string Tipo { set; get; }
        public string Marca { set; get; }
        public string Proveedor { set; get; }
        public decimal MinStock { set; get; }
        public decimal Costo { set; get; }
        public decimal Precio { set; get; }
        public decimal Margen { set; get; }
        public List<Categoria> Categorias;

        public Articulo()
        {
            Categorias = new List<Categoria>();
        }

        // Creando el constructor
        public Articulo(int numero, string nombre)
        {
            this.Numero = numero;
            this.Nombre = nombre;

        }
        public Articulo(int numero, string nombre, string tipo, string marca, string proveedor, decimal minstock, decimal costo, decimal margen)
        {
            this.Nombre = nombre;
            this.Numero = numero;
            this.Tipo = tipo;
            this.Marca = marca;
            this.Proveedor = proveedor;
            this.MinStock = minstock;
            this.Costo = costo;
            this.Margen = margen;
        }

        public string MostrarDatosPrincipales()
        {
            return "Id Producto:" + " " + this.Numero + " " + "Nombre:" + this.Nombre + " " + "Marca:" + this.Marca;
        }

        public string MostrarDatos()
        {
            return "Id Producto:" + " " + this.Numero + " " + "Nombre:" + this.Nombre + " " + "Marca:" + " " + this.Marca + " "
                 + "Categoria:" + this.Tipo + " " + "Proveedor:" + this.Proveedor + " " + "Precio:" + " " + this.Precio;
        }

        public decimal CalcularPrecio()
        {
          return  this.Precio = (this.Costo * this.Margen) + this.Costo;
        }

        public decimal CalcularDescuento()
        {
            if (this.Precio > 10000)
            {
                return this.Precio = ((this.Costo * this.Margen) + this.Costo) -(1500);
            }
            else
            {
                return this.Precio = (this.Costo * this.Margen) + this.Costo;
            }

        }
    }

}
