
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };

        // ==========================================
        // SECCION 1: FOR Y FOREACH
        // ==========================================

        Console.WriteLine("=== REGISTRO DE CALIFICACIONES ===");

        // 1. Recorrer las calificaciones en orden ascendente
        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
        }

        // 2. Recorrer las calificaciones en orden descendente
        Console.WriteLine("\n=== ORDEN DESCENDENTE ===");

        for (int i = calificaciones.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
        }

        // 3. Calcular la suma y el promedio con foreach
        Console.WriteLine("\n=== PROMEDIO DEL GRUPO ===");

        int suma = 0;

        foreach (int calificacion in calificaciones)
        {
            suma += calificacion;
        }

        double promedio = (double)suma / calificaciones.Length;

        string promedioTexto = promedio.ToString(
            "F1",
            CultureInfo.InvariantCulture
        );

        Console.WriteLine($"Suma total: {suma}");
        Console.WriteLine($"Promedio: {promedioTexto}");

        // 4. Recorrer los indices pares del array
        Console.WriteLine("\n=== POSICIONES PARES ===");

        for (int i = 0; i < calificaciones.Length; i += 2)
        {
            Console.WriteLine($"Posición par: {calificaciones[i]}");
        }


        // ==========================================
        // SECCION 2: WHILE Y DO-WHILE
        // ==========================================

        Console.WriteLine("\n=== CONTROL DE ACCESO ===");

        int intentos = 0;
        string clave = "sena2025";
        string claveIngresada = "";

        // 5. Solicitar la clave hasta acertar o agotar los intentos
        while (claveIngresada != clave && intentos < 3)
        {
            Console.Write("Ingresa la clave: ");
            claveIngresada = Console.ReadLine() ?? "";

            intentos++;

            if (claveIngresada != clave)
            {
                Console.WriteLine(
                    $"Clave incorrecta. Intentos restantes: {3 - intentos}"
                );
            }
        }

        if (claveIngresada == clave)
        {
            Console.WriteLine("Acceso concedido.");
        }
        else
        {
            Console.WriteLine("Acceso bloqueado.");
        }

        // 6. Buscar la calificacion mas alta
        int calificacionMasAlta = calificaciones[0];

        for (int i = 1; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] > calificacionMasAlta)
            {
                calificacionMasAlta = calificaciones[i];
            }
        }

        // 7. Mostrar el menu usando do-while
        int opcion;

        do
        {
            Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Ver promedio del grupo");
            Console.WriteLine("2. Ver calificación más alta");
            Console.WriteLine("3. Salir");

            Console.Write("Elige una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine(
                        $"Promedio del grupo: {promedioTexto}"
                    );
                    break;

                case 2:
                    Console.WriteLine(
                        $"Calificación más alta: {calificacionMasAlta}"
                    );
                    break;

                case 3:
                    Console.WriteLine("Hasta luego.");
                    break;

                default:
                    Console.WriteLine(
                        "Opción no válida. Intenta de nuevo."
                    );
                    break;
            }

        } while (opcion != 3);


        // ==========================================
        // SECCION 3: BREAK Y CONTINUE
        // ==========================================

        Console.WriteLine(
            "\n=== PRIMERA CALIFICACIÓN REPROBATORIA ==="
        );

        // 8. Encontrar la primera calificacion menor a 60
        for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] < 60)
            {
                Console.WriteLine(
                    $"Encontrada en posición {i + 1}: {calificaciones[i]}"
                );

                break;
            }
        }

        // 9. Mostrar las calificaciones aprobatorias con continue
        Console.WriteLine("\n=== ESTUDIANTES APROBADOS ===");

        int aprobados = 0;

        foreach (int calificacion in calificaciones)
        {
            if (calificacion < 60)
            {
                continue;
            }

            Console.WriteLine($"Aprobado: {calificacion}");
            aprobados++;
        }

        Console.WriteLine($"Total aprobados: {aprobados}");

        // 10. Combinar break y continue
        Console.WriteLine("\n=== FILTRO COMBINADO ===");

        for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] < 70)
            {
                continue;
            }

            if (calificaciones[i] >= 95)
            {
                Console.WriteLine(
                    $"Búsqueda detenida al encontrar: {calificaciones[i]}"
                );

                break;
            }

            Console.WriteLine(
                $"Calificación procesada: {calificaciones[i]}"
            );
        }
    }
}
