
using ModeloTarea;
using SpaceGestor;
class Program
{

    static void Main(string[] args)
    {
        GestorTareas gestorTareas = new GestorTareas();
        gestorTareas.GenerarTareasAleatorias(10);
        string? entrada = "";
        int opcion = 0;
        int aux;
        bool respuesta;
        do
        {
            Console.WriteLine("MENU DE TAREAS");
            Console.WriteLine("Presione [1] para crear una tarea");
            Console.WriteLine("Presione [2] para marcar una tarea como finalizada");
            Console.WriteLine("Presione [3] para buscar tareas pendientes por descripcion");
            Console.WriteLine("Presione [4] para mostrar todas las tareas");

            Console.WriteLine("Presione [0] para cerrar el programa");
            do
            {
                Console.Write("Su opcion: ");
                entrada = Console.ReadLine();
            } while (!int.TryParse(entrada, out opcion) || opcion < 0);

            switch (opcion)
            {
                case 1:
                    gestorTareas.CrearTarea();
                    Console.WriteLine("Operacion exitosa");
                    Console.WriteLine("");
                    break;
                case 2:
                    aux = IngresarEntero("Ingrese el ID de la tarea: ");
                    respuesta = gestorTareas.FinalizarTarea(aux);
                    Console.WriteLine(respuesta ? "Operacion exitosa" : "No se pudo realizar la operación");
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.Write("Ingrese una descripcion ");
                    string? entrada1 = Console.ReadLine();
                    Console.WriteLine($"\nTareas que contienen: \"{entrada1}\"");
                    List<Tarea> tareasFiltradas = gestorTareas.TareasPendientesPorDescripcion(entrada1);
                    GestorTareas.MostrarListado(tareasFiltradas);
                    break;
                case 4:
                    Console.WriteLine("***Listado pendientes***");
                    gestorTareas.MostrarPendientes();
                    Console.WriteLine("");
                    Console.WriteLine("***Listado finalizadas***");
                    gestorTareas.MostrarFinalizadas();
                    Console.WriteLine("");
                    break;

                default:
                    break;
            }
        } while (opcion != 0);

    }
    
    static int IngresarEntero(string linea)
    {
        string? entrada;
        int entero;
        do
        {
            Console.Write(linea);
            entrada = Console.ReadLine();
        } while (!int.TryParse(entrada, out entero));

        return entero;
    }
}