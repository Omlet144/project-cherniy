using System;

namespace project_cherniy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Marker marker1 = new Marker(Red, "asdfsfd");
            
            Console.WriteLine($"{marker1.GetInfo()}");
           
            Console.Read();
           
        }
    }
}
