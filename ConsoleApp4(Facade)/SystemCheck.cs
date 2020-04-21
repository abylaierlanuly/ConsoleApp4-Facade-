using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4_Facade_
{
    class SystemCheck
    {
        public bool engine { get; set; }
        public double pressure { get; set; }
        public double temperature_of_engine { get; set; }
        public bool electronics { get; set; }
        public string type_of_engine { get; set; }


        public bool Check(bool engine, double pressure, double temperature_of_engine, bool electronics)
        {

            if (engine == true && pressure >= 5.5 && pressure <= 13.5
                    && temperature_of_engine >= 40 && temperature_of_engine < 150
                    && electronics == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Check()
        {
            if (Check(engine, pressure, temperature_of_engine, electronics) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Check_type()
        {
            return type_of_engine;
        }

    }
}
