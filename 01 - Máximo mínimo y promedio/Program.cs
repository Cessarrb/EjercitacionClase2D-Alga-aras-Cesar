using System;

namespace _01___Máximo_mínimo_y_promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado = 0;
            int numMaximo = int.MinValue;
            int numMinimo = int.MaxValue;
            int sumaNumIngresados = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");

                if(int.TryParse(Console.ReadLine(), out numeroIngresado)){

                    if(numeroIngresado > numMaximo)
                    {
                        numMaximo = numeroIngresado;
                    }
                    if(numeroIngresado < numMinimo)
                    {
                        numMinimo = numeroIngresado;
                    }

                    sumaNumIngresados += numeroIngresado;
                }
                else
                {
                    Console.WriteLine("Debe ingresar solo numeros");
                }
            }

            Console.WriteLine($"Numero Minimo {numMinimo} -- numero maximo {numMaximo} -- promedio {(float)sumaNumIngresados / 5}");
            
        }
    }
}
