using System;

namespace appConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0){
                Console.WriteLine($"Hello {args[0]}!");
                Console.ReadLine();
            }
            else{
                Console.WriteLine("Hello");
                Console.WriteLine();
            }
            
        }
    }
}
