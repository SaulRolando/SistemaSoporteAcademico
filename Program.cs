using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SOPORTE ACADÉMICO ===");
        Console.WriteLine("Registro de solicitud");
        Console.WriteLine();

        Console.Write("Código de estudiante: ");
        string codigo = Console.ReadLine() ?? "";

        Console.Write("Nombre del estudiante: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Tipo de consulta: ");
        string tipoConsulta = Console.ReadLine() ?? "";

        Console.Write("Descripción: ");
        string descripcion = Console.ReadLine() ?? "";

        Console.WriteLine();
        Console.WriteLine("=== SOLICITUD REGISTRADA ===");
        Console.WriteLine($"Código: {codigo}");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Tipo de consulta: {tipoConsulta}");
        Console.WriteLine($"Descripción: {descripcion}");
    }
}