using System;

namespace appConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables y tipos
            double x = 34.1;
            double y =  x + 2.0;
            var result = x + y;

            //Declaración de arreglos y tipos
            //double [] numbers = new double[3];
            double [] numbers = new [] {2.4, 3.3, 2.3};
            //numbers[0] = 2.4;
            //numbers[1] = 3.4;
            //numbers[2] = 2.4;
            var resultado = numbers[0];
            resultado += numbers[1];
            resultado += numbers[2];
            Console.WriteLine(resultado);
            //numbers[3] = 3.2;
            if(args.Length > 0){
                Console.WriteLine($"Hello {args[0]}!");
                Console.ReadLine();
            }
            else{
                Console.WriteLine("Hello Jesús");
                Console.WriteLine(result);
                Console.ReadLine();
            }
            
        }
    }
}
