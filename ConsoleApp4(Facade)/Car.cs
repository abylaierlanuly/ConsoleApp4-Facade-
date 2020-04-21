using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4_Facade_
{
    class Car
    {
        Engine Engine = new Engine();

        SystemCheck SystemCheck = new SystemCheck();

        Transmission Transmission = new Transmission();

        public void Start()
        {
            if (SystemCheck.Check())
                Engine.StartEngine();
            Engine.Reset();
        }

        public void Stop()
        {
            Engine.StopEngine();
        }

        public void TurnLeft(int gradus)
        {

            if (SystemCheck.Check() && Engine.Rotations != 0)
            {
                Console.WriteLine("Поворачиваем на Лево - " + gradus + "градус");
            }

        }

        public void TurnRight(int gradus)
        {
            if (SystemCheck.Check() && Engine.Rotations != 0)
            {
                Console.WriteLine("Поворачиваем на Право " + gradus + "градус");
            }
        }

        public void Check(bool e, double p, double t, bool el, string s)
        {

            SystemCheck.engine = e;
            SystemCheck.pressure = p;
            SystemCheck.temperature_of_engine = t;
            SystemCheck.electronics = el;
            SystemCheck.type_of_engine = s;

            Console.WriteLine(SystemCheck.Check());
        }
    }
}
