using System;

namespace ClaseObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Articulo Harina = new Articulo(1, "Harina 0000");
            Articulo Fideos = new Articulo(2, "Tallarines");

            Deposito Lugano = new Deposito(1, "Lugano 1 ", "Av. Roca 4500");
            //Console.WriteLine(Lugano.MostrarDatosPrincipales());
            Lugano = new Deposito(1, "Lugano 1 ", "Av. Roca 4500", "1166022971", 500.5F, "10 a 20hs");
            //Console.WriteLine(Lugano.MostrarDatos());

            //Modicamos Objeto de a un dato
            Harina.Marca = "Blanca Flor";
            Fideos.Marca = "Luchetti";

            Articulo Pure = new Articulo
            {
                Numero = 5,
                Nombre = "Pure Magic",
                Costo = 200,
                Marca = "Magic",
                Margen = .40F,
            };

            //Console.WriteLine(Fideos.MostrarDatosPrincipales());
            //Console.WriteLine(Pure.MostrarDatosPrincipales());

            //Mystification todo el Objeto
            Harina = new Articulo(1, "Harina 0000", "Harinas", "Molinos", "Tres Hermanos", 3.2F, 15000.0F, .50F);

            // Tarea
            Articulo Azucar = new Articulo(1, "Azucar Refinada", "Azucar", "Ledesma", "Ledesma", 5.2F, 10000.0F, .30F);
            Articulo ChocloEnGrano = new Articulo(2, "Choclo Amarillo En Lata", "Enlatados", "Molinos", "Marolio", 10F, 5000.0F, .40F);
            Console.WriteLine(Azucar.CalcularPrecio());
            Console.WriteLine(Azucar.CalcularDescuento());
            Console.WriteLine(Azucar.MostrarDatos());
            Console.WriteLine(ChocloEnGrano.CalcularPrecio());
            Console.WriteLine(ChocloEnGrano.CalcularDescuento());
            Console.WriteLine(ChocloEnGrano.MostrarDatos());

            // Tarea

            Deposito Flores = new Deposito();

            Articulo Yerba = new(4, "Yerba Mate", "Yerba", "Nobleza Gaucha", "Nobleza", 3.2F, 1500.0F, .50F);
            //Articulo GalletitasDeAgua = new (3, "Galletitas de Agua", "Galletitas", "Arcor", "Marolio", 10F, 5000.0F, .40F);

            Flores.ArticuloPermitido.Add(Azucar);
            Flores.ArticuloPermitido.Add(ChocloEnGrano);
            Flores.ArticuloPermitido.Add(Yerba);

            Flores.Nombre = "Flores 1";
            Flores.Numero = 2;
            Flores.Horario = "10 a 20hs";
            Flores.Direccion = "Av. Rivadavia 5300";
            Flores.Capacidad = 650F;
            

            Console.WriteLine(Flores.MostrarArticulos());

        }
    }
}
