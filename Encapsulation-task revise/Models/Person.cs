using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_task_revise.Models
{
    internal class Person
    {
        private sbyte _age;
        //property

        public sbyte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Age must be equal or greater than 0");
                }
                else
                {
                    _age = value;
                }
            }
        }

        public Person(sbyte age)
        {
            Age = age;

        }
    }
}
