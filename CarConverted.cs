using System;
using headerFile;

namespace Program
{
    class Program
    {
        static void Main()
        {   
            string? answer;
            string? make;
            int yearModel = 0;
            Car anon = new Car();
            Console.Write("What model car do you want?: ");
            make = Console.ReadLine();
            Console.Write("What year car do you want?: ");
            answer = Console.ReadLine();
            yearModel = Convert.ToInt32(answer);
            anon.setMake(make);
            anon.setYear(yearModel);

            menu(anon);
        


        }
        static void printMenu(){
            Console.WriteLine("1. Accelerate");
            Console.WriteLine("2. Brake");
            Console.WriteLine("3. Display info");
            Console.WriteLine("4. Display speed");
            Console.WriteLine("5. Exit");
        }

        static void menu(Car car){
            int answer;
            bool exit = false;
            
            
            while(!exit){
                printMenu();
            
                Console.Write("Select an option: ");
                answer = Convert.ToInt32(Console.ReadLine());
                switch(answer){
                    case 1:
                        car.accelerate();
                        Console.WriteLine("Accelerating!!!");
                        break;
                    case 2:
                        car.brake();
                        Console.WriteLine("Braking!!!");
                        break;
                    case 3:
                        car.display();
                        break;
                    case 4:
                        Console.WriteLine("Car speed: " + car.getSpeed());
                        break;
                    case 5:
                        exit = true;
                        Console.WriteLine("Exiting...");
                        break;
                }
            }
        }
    }
}

