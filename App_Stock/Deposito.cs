using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseObjetos
{
    public class Deposito
    {
        public int Numero { set; get; }
        public string Direccion { set; get; }
        public string Nombre { set; get; }
        public string Telefono { set; get; }
        public float Capacidad { set; get; }
        public string Horario { set; get; }
        public List<Articulo> ArticuloPermitido;

        public Deposito()
        {
            ArticuloPermitido = new List<Articulo>();
        }

        public Deposito(int numero, string nombre, string direccion)
        {
            this.Nombre = nombre;
            this.Numero = numero;
            this.Direccion = direccion;
        }
        public Deposito(int numero, string nombre, string direccion, string telefono, float capacidad, string horario)
        {
            this.Nombre = nombre;
            this.Numero = numero;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Capacidad = capacidad;
            this.Horario = horario;
        }

        public string MostrarDatosPrincipales()
        {
            return "Id Deposito" + " " + this.Numero + " " + "Nombre:" + this.Nombre + " " + "Direccion:" + this.Direccion;
        }

        public string MostrarDatos()
        {
            return "Id Deposito:" + " " + this.Numero + " " + "Nombre:" + this.Nombre + " " + "Direccion:" + this.Direccion
                + " " + "Capacidad:" + this.Capacidad + " " + "Horario:" + this.Horario;

        }

        public string MostrarArticulos()
        {
            string ArticulosEnDeposito = "";
            for (int i = 0; i < this.ArticuloPermitido.Count; i++)
            {
                ArticulosEnDeposito += ArticuloPermitido[i].Nombre + " " + ArticuloPermitido[i].Numero + " ";
            }
            return "Deposito: " + this.Nombre + " Direccion: " + this.Direccion + " Numero ID: " + this.Numero + " Y los Articulos Permitidos son:" + ArticulosEnDeposito;
        }
    }
}
