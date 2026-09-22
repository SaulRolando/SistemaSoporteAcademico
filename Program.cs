using System;

class Program
{
    static void Main()
    {
        MostrarMenu();

        Console.Write("Seleccione una opción: ");
        string opcion = Console.ReadLine() ?? "";

        if (opcion == "1")
        {
            Console.WriteLine();
            Console.WriteLine("=== REGISTRO DE SOLICITUD ===");
            Console.WriteLine();

            // R2: Validación del código
            string codigo;

            do
            {
                Console.Write("Código de estudiante: ");
                codigo = Console.ReadLine() ?? "";

                if (!ValidarCodigo(codigo))
                {
                    Console.WriteLine(
                        "Error: el código debe tener al menos 6 caracteres."
                    );
                }

            } while (!ValidarCodigo(codigo));

            // R1: Registro del nombre
            Console.Write("Nombre del estudiante: ");
            string nombre = Console.ReadLine() ?? "";

            // R3: Validación del tipo de consulta
            string tipoConsulta;

            do
            {
                Console.Write("Tipo de consulta: ");
                tipoConsulta = Console.ReadLine() ?? "";

                if (!ValidarTipoConsulta(tipoConsulta))
                {
                    Console.WriteLine("Error: tipo de consulta no válido.");
                    Console.WriteLine(
                        "Opciones: matrícula, pagos, constancia, plataforma u otro."
                    );
                }

            } while (!ValidarTipoConsulta(tipoConsulta));

            // R1: Registro de la descripción
            Console.Write("Descripción: ");
            string descripcion = Console.ReadLine() ?? "";

            // R5: Asignación de prioridad
            string prioridad = CalcularPrioridad(tipoConsulta);

            // Resumen de la solicitud
            Console.WriteLine();
            Console.WriteLine("=== SOLICITUD REGISTRADA ===");
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Tipo de consulta: {tipoConsulta}");
            Console.WriteLine($"Descripción: {descripcion}");
            Console.WriteLine($"Prioridad: {prioridad}");
        }
        else if (opcion == "2")
        {
            Console.WriteLine();
            Console.WriteLine("Gracias por utilizar el sistema.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Opción no válida.");
        }
    }

    // R4: Muestra el menú principal.
    // No devuelve ningún valor.
    static void MostrarMenu()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("        SOPORTE ACADÉMICO");
        Console.WriteLine("=================================");
        Console.WriteLine("1. Registrar solicitud");
        Console.WriteLine("2. Salir");
        Console.WriteLine("=================================");
    }

    // R2: Valida que el código no esté vacío
    // y tenga una longitud mínima de 6 caracteres.
    static bool ValidarCodigo(string codigo)
    {
        return !string.IsNullOrWhiteSpace(codigo)
               && codigo.Trim().Length >= 6;
    }

    // R3: Valida que el tipo de consulta
    // pertenezca a las opciones permitidas.
    static bool ValidarTipoConsulta(string tipoConsulta)
    {
        string tipo = tipoConsulta.Trim().ToLower();

        return tipo == "matrícula" ||
               tipo == "pagos" ||
               tipo == "constancia" ||
               tipo == "plataforma" ||
               tipo == "otro";
    }

    // R5: Asigna una prioridad según el tipo de consulta.
    // Devuelve Alta, Media o Baja.
    static string CalcularPrioridad(string tipoConsulta)
    {
        string tipo = tipoConsulta.Trim().ToLower();

        if (tipo == "plataforma" || tipo == "pagos")
        {
            return "Alta";
        }
        else if (tipo == "matrícula")
        {
            return "Media";
        }
        else
        {
            return "Baja";
        }
    }
}