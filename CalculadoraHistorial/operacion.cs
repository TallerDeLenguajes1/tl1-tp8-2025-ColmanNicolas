namespace SpaceOperacion
{
    public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar // Representa la acción de borrar el resultado actual o el historial
    }
    public class Operacion
    {
        private double resultadoAnterior;
        private double nuevoValor;
        private TipoOperacion operacion;

        public double ResultadoAnterior
        {
            get { return resultadoAnterior; }
            set { resultadoAnterior = value; }
        }

        public double NuevoValor
        {
            get { return nuevoValor; }
            set { nuevoValor = value; }
        }

        public TipoOperacion Tipo
        {
            get { return operacion; }
            set { operacion = value; }
        }

        public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion tipo)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.Tipo = tipo;
        }

        public void MostrarOperacion()
        {
            Console.WriteLine($"{resultadoAnterior,-20} {operacion,-15} {nuevoValor,-20}");
        }
    }
}