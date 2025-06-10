namespace EspacioCalculadora
{
    public class Calculadora
    {


        private double resultado;

        public double Resultado
        {
            get => resultado;
            set => resultado = value;
        }


        public void Sumar(double termino)
        {
            resultado += termino;
        }
        public void Restar(double termino)
        {
            resultado -= termino;
        }
        public void Multiplicar(double termino)
        {
            resultado *= termino;
        }
        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                resultado /= termino;
            }
        }
        public void Limpiar()
        {
            resultado = 0;
        }

    }
}