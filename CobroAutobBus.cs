// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

class Bus
{
    public string Nombre { get; set; }
    public int Capacidad { get; set; }
    public int AsientosOcupados { get; set; }
    public int PrecioPasaje { get; set; }

    public Bus(string nombre, int capacidad, int precioPasaje)
    {
        Nombre = nombre;
        Capacidad = capacidad;
        PrecioPasaje = precioPasaje;
        AsientosOcupados = 0;
    }

    public int AsientosDisponibles()
    {
        return Capacidad - AsientosOcupados;
    }

    public int VentasTotales()
    {
        return AsientosOcupados * PrecioPasaje;
    }

    public void RegistrarPasajeros(int cantidad)
    {
        if (AsientosOcupados + cantidad <= Capacidad)
        {
            AsientosOcupados += cantidad;
        }
        else
        {
            Console.WriteLine($"No hay suficientes asientos disponibles en {Nombre}.");
        }
    }

    public void MostrarResumen()
    {
        Console.WriteLine($"{Nombre} {AsientosOcupados} Pasajeros Ventas {VentasTotales()} quedan {AsientosDisponibles()} asientos disponibles");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bus busPlatinum = new Bus("Auto Bus Plantinum", 22, 1000);
        Bus busGold = new Bus("Auto Bus Gold", 15, 1333);

        // Simulación de registro de pasajeros
        busPlatinum.RegistrarPasajeros(5);
        busGold.RegistrarPasajeros(3);

        // Mostrar resumen
        Console.WriteLine("Resumen de ventas:");
        busPlatinum.MostrarResumen();
        busGold.MostrarResumen();
    }
}