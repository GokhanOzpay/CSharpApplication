using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class ForLoop
    {

        public ForLoop()
        {
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine(i);
            }

            // For döngüsünde çift noktalı virgül kullanırsak, sonsuz kez yürütülür. C#'ta basit bir sonsuz for döngüsü örneği görelim.
          /*  for (; ; )
            {
                Console.WriteLine("Infinitive For Loop");
            }
          */
            int[] arr = { 10, 20, 30, 40, 50 };//creating and initializing array  

            //traversing array  
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
        


   }


