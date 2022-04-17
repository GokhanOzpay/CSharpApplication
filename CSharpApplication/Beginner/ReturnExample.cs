using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class ReturnExample
    {
        public ReturnExample()
        {
            Console.WriteLine(ReturnString());
            Console.ReadKey();

        }

        public string ReturnString()
        {
            return "Değer Döndüren Return İfadesi";
        }
    }

