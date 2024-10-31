/*
 * PROG 3365L C# PROGRAMMING & LAB
 * PROF. MIGUEL OJEDA
 * PGM DE INFORMACION DE USUARIO
*/
namespace form
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Ingresa tu nombre"); string nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu direccion"); string dir = Console.ReadLine();
            string INFO_PE = "Tu nombre es: " + nombre + "\nDireccion: " + dir;
            Console.WriteLine(INFO_PE);


        }
    }
}