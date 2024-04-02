using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_task_revise.Models
{
    internal class ElecrticCar : Cars
    {//ozunde ve miras verdiyi clasda isleyir.-potected.

        private byte _battery = 100; //ilkin qiymetine 100 % dir ilk veziyeytdeverdik 

        protected byte Battery
        {
            get => _battery;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Battery empty");
                }
                else
                {
                    _battery = value;

                }
            }
        }
    }
}
