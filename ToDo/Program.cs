
using ModeloTarea;
using SpaceGestor;
class Program
{

    static void Main(string[] args)
    {
        GestorTareas gestorTareas = new GestorTareas();
        
        string entrada = "";
        int opcion = 0;
        int aux;
        bool respuesta;
        do
        {
            Console.WriteLine("MENU DE TAREAS");
            Console.WriteLine("Presione [1] para crear una tarea");
            Console.WriteLine("Presione [2] para marcar una tarea como finalizada");
            Console.WriteLine("Presione [2] ");
            Console.WriteLine("Presione [0] para cerrar el programa");
            do
            {
                Console.Write("Su opcion: ");
                entrada = Console.ReadLine();
            } while (int.TryParse(entrada, out opcion) || opcion < 0);

        } while (opcion != 0);

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
                break;
            case 4:
                break;

            default:
                break;
        }


    }
    static List<Tarea> GenerarTareasAleatorias(int cantidad)
    {
        List<string> descripciones = new List<string>
        {
            "Estudiar C#",
            "Leer documentación",
            "Practicar ejercicios",
            "Revisar código",
            "Ver tutoriales",
            "Resolver bugs",
            "Escribir documentación",
            "Hacer tests",
            "Refactorizar clase",
            "Diseñar base de datos"
        };

        Random rand = new Random();
        List<Tarea> tareas = new List<Tarea>();

        for (int i = 0; i < cantidad; i++)
        {
            string descripcion = descripciones[rand.Next(descripciones.Count)];
            int duracion = rand.Next(15, 181); // Entre 15 y 180 minutos
            tareas.Add(new Tarea(descripcion, duracion));
        }

        return tareas;


    }
    static int IngresarEntero(string linea)
    {
        string entrada;
        int entero; 
        do
        {
            Console.WriteLine(linea);
            entrada = Console.ReadLine();
        } while (!int.TryParse(entrada, out entero));

        return entero;
    }
}