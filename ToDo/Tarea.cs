
namespace ModeloTarea
{
    public class Tarea
    {
        private static int idIncremental = 0;
        public int TareaID { get; set; }
        public string Descripcion { get; set; }
        public int Duracion { get; set; }
        public Tarea(string desc, int durac)
        {
            idIncremental++;
            TareaID = idIncremental;
            Descripcion = desc;
            Duracion = durac;
        }
    }

}