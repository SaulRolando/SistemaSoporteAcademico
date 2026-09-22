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

            // R6: Validación del nombre
            string nombre;

            do
            {
                Console.Write("Nombre del estudiante: ");
                nombre = Console.ReadLine() ?? "";

                if (!ValidarTexto(nombre))
                {
                    Console.WriteLine(
                        "Error: este campo es obligatorio."
                    );
                }

            } while (!ValidarTexto(nombre));

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

            // R6: Validación de la descripción
            string descripcion;

            do
            {
                Console.Write("Descripción: ");
                descripcion = Console.ReadLine() ?? "";

                if (!ValidarTexto(descripcion))
                {
                    Console.WriteLine(
                        "Error: este campo es obligatorio."
                    );
                }

            } while (!ValidarTexto(descripcion));

            // R5: Asignación de prioridad
            string prioridad = CalcularPrioridad(tipoConsulta);

            // R7: Mostrar resumen
            MostrarResumen(
                codigo,
                nombre,
                tipoConsulta,
                descripcion,
                prioridad
            );
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
    static void MostrarMenu()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("        SOPORTE ACADÉMICO");
        Console.WriteLine("=================================");
        Console.WriteLine("1. Registrar solicitud");
        Console.WriteLine("2. Salir");
        Console.WriteLine("=================================");
    }

    // R2: Valida el código del estudiante.
    static bool ValidarCodigo(string codigo)
    {
        return !string.IsNullOrWhiteSpace(codigo)
               && codigo.Trim().Length >= 6;
    }

    // R3: Valida el tipo de consulta.
    static bool ValidarTipoConsulta(string tipoConsulta)
    {
        string tipo = tipoConsulta.Trim().ToLower();

        return tipo == "matrícula" ||
               tipo == "pagos" ||
               tipo == "constancia" ||
               tipo == "plataforma" ||
               tipo == "otro";
    }

    // R5 y R8: Asigna una prioridad usando el tipo de consulta recibido como parámetro.
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

    // R6: Valida que un texto obligatorio no esté vacío.
    static bool ValidarTexto(string texto)
    {
        return !string.IsNullOrWhiteSpace(texto);
    }

    // R7 y R8: Muestra el resumen usando parámetros recibidos desde Main.
    static void MostrarResumen(
        string codigo,
        string nombre,
        string tipoConsulta,
        string descripcion,
        string prioridad)
    {
        Console.WriteLine();
        Console.WriteLine("=== SOLICITUD REGISTRADA ===");
        Console.WriteLine($"Código: {codigo}");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Tipo de consulta: {tipoConsulta}");
        Console.WriteLine($"Descripción: {descripcion}");
        Console.WriteLine($"Prioridad: {prioridad}");
    }
}