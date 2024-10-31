/*
 * PROG 3365L C# PROGRAMMING & LAB
 * PROF. MIGUEL OJEDA
 * PGM DE CALCULAR VENTA PROMEDIO
 */
namespace CALCULA_VP
{
    class Program
    {
        static void Main()
        { 
            double d1=0, d2=0, d3=0, d4=0, d5=0;
            for (int x = 1; x <= 5; x++ )
            {
                switch (x)
                {
                  case 1: 
                      Console.Write("Entra ventas del Lunes: ");
                      d1 = double.Parse(Console.ReadLine()); 
                      break; 
                  case 2: 
                      Console.Write("Entra ventas del Martes: ");
                      d2 = double.Parse(Console.ReadLine()); 
                      break; 
                  case 3: 
                      Console.Write("Entra ventas del Miercoles: ");
                      d3 = double.Parse(Console.ReadLine()); 
                      break; 
                  case 4: 
                      Console.Write("Entra ventas del jueves: ");
                      d4 = double.Parse(Console.ReadLine()); 
                      break; 
                  case 5: 
                      Console.Write("Entra ventas del Viernes: ");
                      d5 = double.Parse(Console.ReadLine()); 
                      break; 
                }
            }

        Console.WriteLine("Ventas promedio: $" + (d1+d2+d3+d4+d5) / 5);
        }
    }
}