using System;
using headerFile;

namespace Program
{
    class Program
    {
        static void Main()
        {   
            string? make;
            int yearModel = 0;
            Car anon = new Car();
            Console.Write("What model car do you want?: ");
            make = Console.ReadLine();
            Console.Write("What year car do you want?: ");
            yearModel = int.Parse(Console.ReadLine());
            anon.setMake(make);
            anon.setYear(yearModel);
            anon.display();

            
        }
    }

}