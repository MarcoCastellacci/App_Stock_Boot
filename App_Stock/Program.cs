using ClaseObjetos;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Articulo Harina = new(1, "Harina 0000");
        //Articulo Fideos = new(2, "Tallarines");

        //Console.WriteLine(Lugano.MostrarDatosPrincipales());
        //Deposito Lugano = new(1, "Lugano 1 ", "Av. Roca 4500", "1166022971", 500.5F, "10 a 20hs");
        //Console.WriteLine(Lugano.MostrarDatos());

        //Modicamos Objeto de a un dato
        //Harina.Marca = "Blanca Flor";
        //Fideos.Marca = "Luchetti";

        //Console.WriteLine(Fideos.MostrarDatosPrincipales());
        //Console.WriteLine(Pure.MostrarDatosPrincipales());

        //Mystification todo el Objeto
#pragma warning disable IDE0059 // Unnecessary assignment of a value
        //Harina = new(1, "Harina 0000", "Harinas", "Molinos", "Tres Hermanos", 3.2m, 15000.0m, .50m);
#pragma warning restore IDE0059 // Unnecessary assignment of a value

        // Tarea
        //Articulo Azucar = new(1, "Azucar Refinada", "Azucar", "Ledesma", "Ledesma", 15m, 10000.0m, .30m);
        //Articulo ChocloEnGrano = new(2, "Choclo Amarillo En Lata", "Enlatados", "Molinos", "Marolio", 10m, 5000.0m, .40m);
        // Tarea

        //Deposito Flores = new();

        //Articulo Yerba = Yerba.AgregarArticulo(4, "Yerba Mate", "Yerba", "Nobleza Gaucha", "Nobleza", 3.2m, 1500.0m, .50m);
        //Articulo GalletitasDeAgua = new(3, "Galletitas de Agua", "Galletitas", "Arcor", "Marolio", 10m, 5000.0m, .40m);
        //Flores.Nombre = "Flores 1";
        //Flores.Numero = 2;
        //Flores.Horario = "10 a 20hs";
        //Flores.Direccion = "Av. Rivadavia 5300";
        //Flores.Capacidad = 650F;


        //Console.WriteLine(Flores.MostrarArticulos());

        //Console.WriteLine(Flores.ValidarArticulo(Yerba));

        //Stock StockFloresta = new(Yerba, Flores, 10m);
        //Console.WriteLine(StockFloresta.StockValorizado());


        Console.WriteLine("Genero un Articulo");

        Articulo Harina = new Articulo();
        {
            Harina.Nombre = "Harina para Pizza";
            Harina.Marca = "Luchetti";
            Harina.Tipo = "Harina";
            Harina.Proveedor = "Arcor";
            Harina.Costo = 50m;
            Harina.MinStock = 50m;
            Harina.Margen = .5m;
        }
        Console.WriteLine("Agrego en la DB");
        int resultado = Harina.AgregarArticulo();
        Console.WriteLine(resultado);
            if (resultado != 1)
        {
            Console.WriteLine("No se pudo agregar alumno en DB");
            return;
        }
    }
}