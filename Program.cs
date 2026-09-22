using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SOPORTE ACADÉMICO ===");
        Console.WriteLine("Registro de solicitud");
        Console.WriteLine();

        string codigo;

        do
        {
            Console.Write("Código de estudiante: ");
            codigo = Console.ReadLine() ?? "";

            if (!ValidarCodigo(codigo))
            {
                Console.WriteLine("Error: el código debe tener al menos 6 caracteres.");
            }

        } while (!ValidarCodigo(codigo));

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

    static bool ValidarCodigo(string codigo)
    {
        return !string.IsNullOrWhiteSpace(codigo) && codigo.Trim().Length >= 6;
    }
}