
using EspacioCalculadora;
using SpaceOperacion;
class Program
{
    static void Main(string[] args)
    {
        List<Operacion> historialOperaciones = new List<Operacion>();
        Calculadora calc = new Calculadora();
        string opcion;
        double valor;
        TipoOperacion operacion = new TipoOperacion();
        do
        {
            Console.WriteLine("\n==== CALCULADORA ====");
            Console.WriteLine("Resultado actual: " + calc.Resultado);
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Restar");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Limpiar");
            Console.WriteLine("6 - Mostrar Historial");
            Console.WriteLine("0 - Salir");
            Console.Write("Opción: ");
            opcion = Console.ReadLine();
            double valorAnterior = calc.Resultado;
            
            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese un número para sumar: ");
                    valor = double.Parse(Console.ReadLine());
                    calc.Sumar(valor);
                    operacion = TipoOperacion.Suma;
                    break;
                case "2":
                    Console.Write("Ingrese un número para restar: ");
                    valor = double.Parse(Console.ReadLine());
                    calc.Restar(valor);
                    operacion = TipoOperacion.Resta;
                    break;
                case "3":
                    Console.Write("Ingrese un número para multiplicar: ");
                    valor = double.Parse(Console.ReadLine());
                    calc.Multiplicar(valor);
                    operacion = TipoOperacion.Multiplicacion;
                    break;
                case "4":
                    Console.Write("Ingrese un número para dividir: ");
                    valor = double.Parse(Console.ReadLine());
                    calc.Dividir(valor);
                    operacion = TipoOperacion.Division;
                    break;
                case "5":
                    calc.Limpiar();
                    Console.WriteLine("Calculadora reiniciada.");
                    operacion = TipoOperacion.Limpiar;
                    break;
                case "6":
                    Console.WriteLine($"{"Resultado anterior:",-20} {"Operación:",-15} {"Nuevo Resultado:",-20}");
                    foreach (var item in historialOperaciones)
                    {
                        item.MostrarOperacion();
                    }
                    break;
                case "0":
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            historialOperaciones.Add(new Operacion(valorAnterior, calc.Resultado, operacion));
        } while (opcion != "0");
    }
}
