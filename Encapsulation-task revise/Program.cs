using Encapsulation_task_revise.Models;

namespace Encapsulation_task_revise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = true;
            Tesla s = new Tesla();
            //s.Drive(); bunu sildik eslinde

            do
            {
                //her defe while islenmezden evvel evvelkiler silinsin konsolda
                Console.WriteLine(@"1.Drive  
2. MaxSpeed
3. Exit");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        s.Drive();
                        break;
                    case 2:
                        s.MaxSpeed();
                        break;
                    case 3:
                        isContinue = false;
                        break;
                        Console.Clear();

                }


            } while (isContinue);
        }
    }
}
