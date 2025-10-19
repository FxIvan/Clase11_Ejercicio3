using Clase11_Ejercicio3;
using System;

class Program
{
    static void Main()
    {
        Empleado Clonacion1 = new Empleado()
        {
            Provincia = "Buenos Aires",
            Ciudad = new Municipalidad { NombreMunicipalidad = "La Plata" }
        };

        // Clon superficial
        Empleado Clonacion2 = (Empleado)Clonacion1.Clone();

        // Clon profundo
        Empleado Clonacion3 = Clonacion1.CloneDeep();

        // Modificamos las propiedades de los clones
        Clonacion2.Ciudad.NombreMunicipalidad = "Berazategui";
        Clonacion3.Ciudad.NombreMunicipalidad = "Mar del Plata";

        Console.WriteLine("Original:");
        Console.WriteLine($"Provincia: {Clonacion1.Provincia}");
        Console.WriteLine($"Ciudad: {Clonacion1.Ciudad.NombreMunicipalidad}");
        Console.WriteLine("---------------------------------------");

        Console.WriteLine("Clon superficial:");
        Console.WriteLine($"Provincia: {Clonacion2.Provincia}");
        Console.WriteLine($"Ciudad: {Clonacion2.Ciudad.NombreMunicipalidad}");
        Console.WriteLine("---------------------------------------");

        Console.WriteLine("Clon profundo:");
        Console.WriteLine($"Provincia: {Clonacion3.Provincia}");
        Console.WriteLine($"Ciudad: {Clonacion3.Ciudad.NombreMunicipalidad}");
    }
}
