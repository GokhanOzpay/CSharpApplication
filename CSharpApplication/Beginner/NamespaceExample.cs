using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpApplication.Beginner.NamespaceExample;
using CSharpApplication.Beginner.NamespaceExample.Second;

namespace CSharpApplication.Beginner.NamespaceExample
{
    internal class NamespaceExample
    {
        public NamespaceExample()
        {
            Hello h1 = new Hello();
            h1.sayHello();
            Welcome w1 = new Welcome();
            w1.sayWelcome();
            CSharpApplication.Beginner.NamespaceExample.Hello h2 = new CSharpApplication.Beginner.NamespaceExample.Hello(); // using Kullanmadan Sisteme Dahil Etilebilinir
            h2.sayHello();
        }
    }

    public class Hello
    {
        public void sayHello() { Console.WriteLine("Merhaba Ad Alanı"); }
    }
    
}
namespace CSharpApplication.Beginner.NamespaceExample.Second
{
    public class Welcome
    {
        public void sayWelcome() { Console.WriteLine("Hoş Geldiniz Ad Alanı"); }
    }
}