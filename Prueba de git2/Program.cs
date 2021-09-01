using System;

namespace Prueba_de_git2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione el miembro de los borbotones");
            Console.WriteLine("1 Emmanuel Julio");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
                {
                case 1:
                    Console.WriteLine("Emmanuel julio edad 29 años tell 1138427868");
                    break;
                }
        }
    }
}
