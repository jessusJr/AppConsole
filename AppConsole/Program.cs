using System;
using System.Collections.Generic;
using GradeBook;

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
            var book = new Book();
            //Declaración de arreglos y tipos
            //double [] numbers = new double[3];
            double [] numbers = new [] {2.4, 3.3, 2.3};
            //numbers[0] = 2.4;
            //numbers[1] = 3.4;
            //numbers[2] = 2.4;
            var resultado = numbers[0];
            resultado += numbers[1];
            resultado += numbers[2];

            double suma = 0.0;
            foreach (double number in numbers)
            {
                suma += number;
            }

            //declaracion de una lista
            List <double> listGrades = new List<double>();
            listGrades.Add(3.5);
            Console.WriteLine(listGrades);
            Console.WriteLine(suma);
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
