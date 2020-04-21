using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4_Facade_
{
    class Transmission
    {
        public bool Driveforward;



        public int Position = 0;

        public string R = "R";


        public void Increase(SystemCheck SystemCheck, Engine Engine)
        {
            for (int i = 1; i <= 5; i++)
            {
                if (Position == i && Driveforward == true)
                {
                    if (SystemCheck.Check_type() == "Gasoline")
                    {
                        Engine.Accelerate(1000 + i * 2);
                    }
                    else if (SystemCheck.Check_type() == "Gas")
                    {
                        Engine.Accelerate(500 + i * 5);
                    }
                }
            }


            if (R == "R" && Driveforward == false)
            {
                if (SystemCheck.Check_type() == "Gasoline")
                {
                    Engine.Accelerate(1500);
                }
                else if (SystemCheck.Check_type() == "Gas")
                {
                    Engine.Accelerate(1000);
                }
            }
        }


    }

}
