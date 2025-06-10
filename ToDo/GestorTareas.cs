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
            string descripcion, entrada;
            int duracion;
            do
            {
                control = true;
                Console.Write("Ingrese descripcion: ");
                descripcion = Console.ReadLine();

                Console.WriteLine("Ingrese duracion: ");
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
    }
}