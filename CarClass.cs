using System;

namespace headerFile
{
    class Car
    {
        private int yearModel;
        private string make;
        private int speed;

        public Car(int xyearModel, string xmake){
            yearModel = xyearModel;
            make = xmake;
            speed = 0;
        }

        public Car(){
            yearModel = 1999;
            make = "default";
            speed = 999;
        }

        public void accelerate(){
            speed += 5;
        }

        public void brake(){
            speed -= 5;
        }

        public int getYearModel(){
            return yearModel;
        }

        public string getMake(){
            return make;
        }

        public int getSpeed(){
            return speed;
        }

        public void setYear(int year){
            yearModel = year;
        }

        public void setMake(string xmake){
            make = xmake;
        }

        public void display(){
            Console.WriteLine("Car Model: " + make);
            Console.WriteLine("Car Year: " + yearModel);
            Console.WriteLine("Car Speed: " + speed);
        }
    }

}