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
        public float MinStock { set; get; }
        public double Costo { set; get; }
        public float Precio { set; get; }
        public float Margen { set; get; }
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
        public Articulo(int numero, string nombre, string tipo, string marca, string proveedor, float minstock, float costo, float margen)
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

        public float CalcularPrecio()
        {
          return  this.Precio = ((float)((float)(this.Costo * this.Margen) + this.Costo));
        }

        public float CalcularDescuento()
        {
            if (this.Precio > 10000)
            {
                return this.Precio = ((float)((float)(this.Costo * this.Margen) + this.Costo)) - 1500;
            }
            else
            {
                return this.Precio = ((float)((float)(this.Costo * this.Margen) + this.Costo));
            }

        }
    }

}
