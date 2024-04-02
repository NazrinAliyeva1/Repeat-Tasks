using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_task_revise.Models
{
    internal class Tesla : ElecrticCar
    {
        public string Model { get; set; }
        public void MaxSpeed()
        {
            switch (Battery)
            {
                case > 80:
                    Console.WriteLine("Max speed is 350");
                    break;
                case > 60:
                    Console.WriteLine("Max speed is 300");
                    break;
                case > 40:
                    Console.WriteLine("Max speed is 220");
                    break;
                case > 20:
                    Console.WriteLine("Max  speed is 150");
                    break;
            }
        }
        //drive metodu qiyaq her defe surende azalmalidi. drive olmalidi amma teslanin icinde de gorunmelidir.
        public void Drive()
        {
            //driveda random tipinde bir dne clas var-bu adam bu surusde nece faiz zaryatka xercleyib onu gormek isteyirik bu sertde:
            Random r = new Random();
            byte usedBattery = Convert.ToByte(r.Next(30));//0-dan 100-e qeder sururem
            Battery -= usedBattery;
            Console.WriteLine($"Driver used {usedBattery} % battery. Battery: {Battery}");



            //bir adam bir surusde max 30faiz zaryatka xercleye biler.



        }
    }
}
