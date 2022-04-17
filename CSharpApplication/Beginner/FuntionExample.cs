using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class FuntionExample
{
    public FuntionExample()
    {

        NotReturnFunction();
        ParameterFuncion("Ben Parametre İle İşlem Gören Method (Function)");
        Console.WriteLine(ReturnFunction());
        Console.ReadKey();
    }

    public void NotReturnFunction() // parametre Ve Dönüş Türü Kullanmayan
    {
        Console.WriteLine("Ben Değer Döndürmeyen Method ( Function)");
    }
    public void ParameterFuncion(string message) // Parametre Kullanıyor Ancak Dönüş Türü Yok
    {
        Console.WriteLine( message);
    }
    public string ReturnFunction() // Parametre Ve Dönüş türünü Kullanarak
    {
        return "Değer Döndüren Method (Function)";

    }
   
}

