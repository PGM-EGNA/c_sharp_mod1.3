/*
 * PROG 3365L C# PROGRAMMING & LAB
 * PROF. MIGUEL OJEDA
 * PGM DE CALCULAR SUELDO DE EMP
 */
namespace Horas_T
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Ingresa horas trabajadas en la semana: ");
            double horas = double.Parse(Console.ReadLine());
            double salario = 7.50; 
            double net = horas *  salario; 
            Console.WriteLine("Sueldo Net: $" + net); 


        }
    }
}