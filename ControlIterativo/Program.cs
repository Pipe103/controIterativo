using System.Security.Claims;

namespace ControlIterativo;

class Program
{
    static void Main(string[] args)
    {
        String entrada = "";
        //Sección 1 — For y Foreach: Registro y análisis de calificaciones
        Console.WriteLine("=== REGISTRO DE CALIFICACIONES ===");
        int[] calificaciones = {72, 85, 91, 60, 43, 78, 95, 55, 88, 67};
        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.WriteLine($"Estudiantes {i + 1} : {calificaciones[i]}");
        }

        Console.WriteLine("=== ORDEN DESCENDENTE ===");
        for (int i = calificaciones.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"Estudiantes {i + 1} : {calificaciones[i]}");
        }
         
        Console.WriteLine("=== PROMEDIO DEL GRUPO ===");

         int sumaTotal = 0;
        foreach (int suma in calificaciones)
        {
            sumaTotal += suma;   
        }
        double promedio = (double)sumaTotal / calificaciones.Length;
        Console.WriteLine($"suma total :  {sumaTotal}");
        Console.WriteLine($"Pormedio : {promedio}");

        Console.WriteLine("");

        Console.WriteLine("=== POSICIONES PARES ===");
        for (int i = 0; i < calificaciones.Length; i += 2)
        {
            Console.WriteLine($"Posicion par :  {calificaciones[i]}");
        }
        Console.WriteLine("");
        Console.WriteLine("");

        //Sección 2 — While y Do-While: Validación y juego interactivo
        int intentos = 0;
        String clave = "sena2025";
        Console.WriteLine("=== CONTROL DE ACCESO ===");
        while (intentos < 3)
        {
            Console.WriteLine("ingresa la clave");
            entrada = Console.ReadLine();

            if (clave == entrada)
            {
                Console.WriteLine("Acceso concedido.");
                break;
            }else
            {
                intentos ++;
                Console.WriteLine("clave incorrecta");
            }
        }
        if (intentos >= 3)
        {
            Console.WriteLine("Acceso bloqueado.");
        }

        

        Console.WriteLine("=== MENÚ PRINCIPAL ===");
        int opcionMenu = 0;
        int numeroAlto = 0;
        do
        {
            
            Console.WriteLine("1. Ver promedio del grupo");
            Console.WriteLine("2. Ver calificación más alta");
            Console.WriteLine("3. Salir");
            opcionMenu = int.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1: Console.WriteLine($"opcion 1 \nPromedio del grupo : {promedio}");
                    Console.WriteLine("");
                    break;

                    case 2: numeroAlto = calificaciones.Max();
                    Console.WriteLine($"opcion 2 \ncalificaciones mas altas {numeroAlto}");
                    Console.WriteLine("");
                    break;

                    case 3: Console.WriteLine("hasta luego");
                    Console.WriteLine("");
                    break;
                    default: Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    Console.WriteLine("");
                    break;
                }
            
        }while(opcionMenu !=3 );
        Console.WriteLine("");


//Sección 3 — Break y Continue: Filtrado y búsqueda eficiente

        Console.WriteLine("=== PRIMERA CALIFICACIÓN REPROBATORIA ===");
        for (int i = 0; i<calificaciones.Length; i++)
        {
            if (calificaciones[i] < 60)
            {
                Console.WriteLine($"encontrada en posicion {i} : {calificaciones[i]}");
                break;
            }
        }
            Console.WriteLine("");

            
            Console.WriteLine("=== ESTUDIANTES APROBADOS ===");
            int contadorAprobados = 0;

            foreach(int aprobados in calificaciones)
            {
                if (aprobados < 60)
                {
                    continue;
                }
                contadorAprobados++;
                Console.WriteLine($"aprobado : {aprobados}");
                
            }
            Console.WriteLine($"total aprobados {contadorAprobados}");
            Console.WriteLine("");

            Console.WriteLine("=== FILTRO COMBINADO ===");
            for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] < 70)
            {
                continue;
            }
            if (calificaciones[i] >= 95)
            {
                Console.WriteLine($"busqueda detenida al encontrar : {calificaciones[i]}");
                break;
            }
            Console.WriteLine($"Calificacion procesada {calificaciones[i]}");
        }
        }

    }

