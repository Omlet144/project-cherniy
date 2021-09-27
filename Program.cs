using System;

namespace project_cherniy
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine($"Color marker: "); 
            Console.ForegroundColor = ConsoleColor.White;
            Marker marker1 = new Marker(System.ConsoleColor.Green, "Hello World"); 
            Console.WriteLine($"{marker1.GetInfo()}");
            Console.Read();
           
        }
    }
}
