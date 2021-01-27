using System;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int x;
            string[] nombres = new string[5] { "Eugenio", "Emma","Lorenzo","Ricardo","Verónica" };

            Console.Write("ingrese un numero entero: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingrese otro numero entero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            x = n1 + n2;
            Console.WriteLine("El resultado de la suma es: {0}", x);

            x = n1 - n2;
            Console.WriteLine("El resultado de la resta es: {0}", x);

            x = n1 * n2;
            Console.WriteLine("El resultado de la multiplicacion es: {0}", x);

            if (n2 == 0)
            {
                Console.WriteLine("No puede dividirse por cero.");
            }
            else
            {
                x = n1 / n2;
                Console.WriteLine("El resultado de la division es: {0}", x);
            }

            foreach ( string nombre in nombres )
            {
                if (nombre == "Emma")
                {
                    Console.WriteLine("{0} sos la ganadora!", nombre);
                }
                else
                {
                    Console.WriteLine(nombre);
                }
            }
         
        }
    }
}
