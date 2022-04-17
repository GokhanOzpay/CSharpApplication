using System;
using System.Collections.Generic;
using System.Text;
class WhileLoop
{
    public WhileLoop()
    {


        DoWhileDemo();
    }
    public void WhileDemo()
    {
        int i = 1;
        while (i <= 10)
        {
            Console.WriteLine(i);
            i++;
        }

        /*
                while (true)
                {
                    Console.WriteLine("Infinitive While Loop");
                }
        */
    }
    public void DoWhileDemo()
    {
        int i = 1;

        do
        {
            Console.WriteLine(i);
            i++;
        } while (i <= 10);
        /*
        do
        {
            Console.WriteLine("Infinitive do-while Loop");
        } while (true);
        */
    }
}