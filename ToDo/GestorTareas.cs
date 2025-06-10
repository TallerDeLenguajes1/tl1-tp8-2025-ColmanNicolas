using ModeloTarea;

namespace SpaceGestor
{
    public class GestorTareas
    {
        private List<Tarea> tareasPendientes = new List<Tarea>();
        private List<Tarea> tareasRealizadas = new List<Tarea>();

        public void CrearTarea()
        {
            bool control;
            string? descripcion, entrada;
            int duracion;
            do
            {
                control = true;
                Console.Write("Ingrese descripcion: ");
                descripcion = Console.ReadLine();

                Console.Write("Ingrese duracion: ");
                entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(descripcion))
                {
                    Console.WriteLine("La descripción no puede estar vacía.");
                    control = false;

                }
                if (!int.TryParse(entrada, out duracion) || duracion <= 0)
                {
                    Console.WriteLine("La duración debe ser un número positivo.");
                    control = false;
                }

            } while (!control);
            Tarea tarea = new Tarea(descripcion, duracion);
            tareasPendientes.Add(tarea);
        }

        public bool FinalizarTarea(int id)
        {
            var existeTarea = tareasPendientes.Find(t => t.TareaID == id);
            if (existeTarea != null)
            {
                tareasRealizadas.Add(existeTarea);
                tareasPendientes.Remove(existeTarea);
                return true;
            }
            return false;
        }

        public List<Tarea> TareasPendientesPorDescripcion(string? descripcion)
        {
            return tareasPendientes.FindAll(t => t.Descripcion.Contains(descripcion));
        }
        public static void MostrarListado(List<Tarea> tareas)
        {
            if (tareas == null || tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas para mostrar.");
                return;
            }
            foreach (Tarea item in tareas)
            {
                item.MostrarTarea();
            }
        }
        public void MostrarPendientes()
        {
            foreach (Tarea item in tareasPendientes)
            {
                item.MostrarTarea();
            }
        }
        public void MostrarFinalizadas()
        {
            foreach (Tarea item in tareasRealizadas)
            {
                item.MostrarTarea();
            }
        }
        public void GenerarTareasAleatorias(int cantidad)
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

            for (int i = 0; i < cantidad; i++)
            {
                string descripcion = descripciones[rand.Next(descripciones.Count)];
                int duracion = rand.Next(15, 181); // Entre 15 y 180 minutos
                tareasPendientes.Add(new Tarea(descripcion, duracion));
            }
        }
    }

}