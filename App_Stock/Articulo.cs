using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClaseObjetos
{
    public class Articulo
    {
        //Propiedades de un Objeto
        public int ID { set; get; }
        public string Nombre { set; get; }
        public string Tipo { set; get; }
        public string Marca { set; get; }
        public string Proveedor { set; get; }
        public decimal MinStock { set; get; }
        public decimal Costo { set; get; }
        public decimal Precio { set; get; }
        public decimal Margen { set; get; }
        public List<Categoria> Categorias;

        private AccesoDatos db;

        public Articulo()
        {
            Categorias = new List<Categoria>();
            db = new AccesoDatos();
        }

        public int AgregarArticulo()
        {
            string query = $"insert into articulos (Nombre, ID, Tipo, Marca, Proveedor, MinStock, Costo, Margen)";
            query += $"values('{this.ID}', '{this.Nombre}' , '{this.Marca}', '{this.Tipo}', '{this.Proveedor}', '{this.MinStock}', '{this.Costo}', '{this.Margen}')";
            try
            {
                SqlCommand command = new SqlCommand(query);
                int r = db.ejecQueryDevuelveInt(command);
                return r;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error en ChangeAddPartidaToProduct actualizando que guarde partida a producto {ex.Message} " );
                return -1;
            }
            finally
            {
                db.DesConectar();
            }
        }

        public int ActualizarArticulo( Articulo articuloActualizado)
        {
            string query = $"update articulos set Nombre = '{articuloActualizado.Nombre}', " +
               $"Tipo='{articuloActualizado.Tipo}', " +
               $"Marca='{articuloActualizado.Marca}', " +
               $"Proveedor = '{articuloActualizado.Proveedor}', " +
               $"Min-Stock = '{articuloActualizado.MinStock}', " +
               $"Costo = {articuloActualizado.Costo}, " +
               $"Margen = '{articuloActualizado.Margen}' " +
               $"where id = {articuloActualizado.ID}";
            try
            {
                SqlCommand command = new SqlCommand(query);
                int r = db.ejecQueryDevuelveInt(command);
                return r;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                db.DesConectar();
            }
        }

        public int EliminarArticulo(int idArticulo)
        {
            string query = $"delete alumnos where id={idArticulo}";
            try
            {
                SqlCommand command = new SqlCommand(query);
                int r = db.ejecQueryDevuelveInt(command);
                return r;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                db.DesConectar();
            }
        }

        public Articulo GetArticuloPorId(int idArticulo)
        {
            try
            {
                string select = $"select * from Alumnos where id={idArticulo}";
                SqlCommand command = new SqlCommand(select);
                DataTable dt = db.execDT(command);


                if (dt.Rows.Count <= 0)
                {
                    //no se encuentra pedido para actualizar estado
                    return null;
                }

                Articulo ArticuloPorId = new Articulo();
                foreach (DataRow dr in dt.Rows)
                {
                    ArticuloPorId.ID = Convert.ToInt32(dr["Id"]);
                    ArticuloPorId.Nombre = dr["Nombre"].ToString();
                    ArticuloPorId.Tipo = dr["Tipo"].ToString();
                    ArticuloPorId.Marca = dr["Marca"].ToString();
                    ArticuloPorId.Proveedor = dr["Proveedor"].ToString();
                    ArticuloPorId.MinStock = Convert.ToDecimal(dr["Min-Stock"]);
                    ArticuloPorId.Costo = Convert.ToDecimal(dr["Costo"]);
                    ArticuloPorId.Margen = Convert.ToDecimal(dr["Margen"]);
                }

                return ArticuloPorId;
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                db.DesConectar();
            }
        }

        public List<Articulo> GetArticulosCompletos()
        {
            try
            {
                string select = $"select * from Alumnos ";
                SqlCommand command = new SqlCommand(select);
                DataTable dt = db.execDT(command);

                if (dt.Rows.Count <= 0)
                {
                    //no se encuentra pedido para actualizar estado
                    return null;
                }

                List<Articulo> articulosFromDataBase = new List<Articulo>();
                foreach (DataRow dr in dt.Rows)
                {
                    Articulo articuloAux = new Articulo();
                    articuloAux.ID = Convert.ToInt32(dr["Id"]);
                    articuloAux.Nombre = dr["Nombre"].ToString();
                    articuloAux.Tipo = dr["Tipo"].ToString();
                    articuloAux.Marca = dr["Marca"].ToString();
                    articuloAux.Proveedor = dr["Proveedor"].ToString();
                    articuloAux.MinStock = Convert.ToDecimal(dr["Min-Stock"]);
                    articuloAux.Costo = Convert.ToDecimal(dr["Costo"]);
                    articuloAux.Margen = Convert.ToDecimal(dr["Margen"]);
                    //agrego a la lista
                    articulosFromDataBase.Add(articuloAux);
                }

                return articulosFromDataBase;
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                db.DesConectar();
            }
        }

        public string MostrarDatosPrincipales()
        {
            return "Id Producto:" + " " + this.ID + " " + "Nombre:" + this.Nombre + " " + "Marca:" + this.Marca;
        }

        public string MostrarDatos()
        {
            return "Id Producto:" + " " + this.ID + " " + "Nombre:" + this.Nombre + " " + "Marca:" + " " + this.Marca + " "
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

        // Creando el constructor
        //public Articulo(int numero, string nombre)
        //{
        //    this.Numero = numero;
        //    this.Nombre = nombre;

        //}
        //public Articulo(int numero, string nombre, string tipo, string marca, string proveedor, decimal minstock, decimal costo, decimal margen)
        //{
        //    this.Nombre = nombre;
        //    this.Numero = numero;
        //    this.Tipo = tipo;
        //    this.Marca = marca;
        //    this.Proveedor = proveedor;
        //    this.MinStock = minstock;
        //    this.Costo = costo;
        //    this.Margen = margen;
        //}