using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Break
{
    public Break()
    {
        ContinueDeme();
        Console.ReadKey();
    }
    public void BreakDemo()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                break; // 5 Eşit Olduğunda Döngüden Çık. break Aynı Zamanda swich de Kullanılır.
                // return; // Aynı Sekilde Return İfadesi de Kullanır.
            }
            Console.WriteLine(i);
        }
    }
    public void ContinueDeme()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                continue;// 5 Geldiğinde 5 Atlar Sonraki İşleme Giter
            }
            Console.WriteLine(i);
        }
    }
}

