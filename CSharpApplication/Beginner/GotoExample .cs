using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class GotoExample
{
    public GotoExample()
    {
        GotoDemo();
        Console.ReadKey();
    }

    public void GotoDemo()
    {

        ineligible: // Atlancak Yer
        Console.WriteLine("Yaşınızı girin:\n");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age < 18)
        {
            Console.WriteLine("Oy vermeye uygun değilsiniz!");
            goto ineligible; // Atlancak Kısım
        }
        else
        {
            Console.WriteLine("Oy vermeye uygunsunuz!");
        }
    }
}
