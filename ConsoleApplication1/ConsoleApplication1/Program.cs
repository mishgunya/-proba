using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;

            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.printState();
            }

            Console.ReadLine();
        }
    }

    class  Car
    {
        public string petName;
        public int currSpeed;
        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
        public void printState()
            => Console.WriteLine($"{petName} is going {currSpeed}");

    }


}