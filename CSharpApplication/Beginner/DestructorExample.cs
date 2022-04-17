using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class DestructorExample 
{
    public DestructorExample()
    {
        Console.WriteLine(" Oluşturucu Çağrıldı (Constructor)");
    }
   
   ~DestructorExample() => Console.WriteLine("Yıkıcı Çağrıldı (Destructor)");

}

