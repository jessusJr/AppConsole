using System;

namespace appConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 34.1;
            x =  x + 2.0;
            
            if(args.Length > 0){
                Console.WriteLine($"Hello {args[0]}!");
                Console.ReadLine();
            }
            else{
                Console.WriteLine("Hello Jesús");
                Console.ReadLine();
            }
            
        }
    }
}
