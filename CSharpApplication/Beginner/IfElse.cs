using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class IfElse
    {
        public IfElse()
        {
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."

            // Ternary Operator
            string result = (time > 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
            // Outputs "Good day."

            Console.ReadKey();
        }
    }

