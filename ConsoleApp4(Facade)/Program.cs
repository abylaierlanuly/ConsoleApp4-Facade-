using System;

namespace ConsoleApp4_Facade_
{
    class EngineExceptions : Exception
    {
        public override string Message
        {
            get
            {
                return "Достигнут макимальный оборот";
            }
        }
    }


    class SpeedExceptions : Exception
    {
        public override string Message
        {
            get
            {
                return "Больше не можем разгоняться";
            }
        }
    }

    class Engine
    {
        public int Rotations { get; set; }
        public int Speed { get; set; }

        public void Reset()
        {
            Rotations = 1000;
        }

        public void StartEngine()
        {
            Console.WriteLine("Engine start");
        }

        public void StopEngine()
        {
            Rotations = 0;
            Console.WriteLine("Engine stop");
        }

        public void Accelerate(int rotations)
        {
            Rotations += rotations;
        }

        public void Deccelerate(int rotations)
        {
            Rotations -= rotations;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Car c = new Car();
            try
            {
                c.Check(true, 6.2, 124, true, "Gasoline");
                c.Start();
                c.TurnRight(45);
                c.TurnLeft(72);
                c.Stop();

                c.TurnLeft(50);
            }
            catch (EngineExceptions e)
            {
                Console.WriteLine(e.Message);
            }
            catch (SpeedExceptions e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
   
