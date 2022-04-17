using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Application.Beginner
{

   public class AClass
    {
        public string variablePublic= "Public Variable";
        protected string variableProtected = "Protected Variable";
        internal string variableInternal = "Internal Variable";
        protected internal string variableProtectedInternal = "Protected Variable";
        private string variablePrivate = "Private Variable";
        public void myAFunction()
        {
            Console.WriteLine("AClass "+this.variableProtected);
            Console.WriteLine("AClass "+this.variablePrivate);

        }
    }

   public class BClasss : AClass
    {        
       
        public void myBFunction()
        {           
            Console.WriteLine(this.variableProtected);
            // Console.WriteLine(this.variablePrivate); Hata Koruma Duzeyi private

        }

    }

    internal class Access
    {
        public Access()
        {
            AClass aClass = new AClass();
            Console.WriteLine(aClass.variablePublic);
            // Console.WriteLine(aClass.variableProtected); Hata Koruma Duzeyi protected Sadece Miras Alınabilinir.
            Console.WriteLine(aClass.variableInternal);
            Console.WriteLine(aClass.variableProtectedInternal);
            // Console.WriteLine(aClass.variablePrivate); Hata Koruma Duzeyi private
            aClass.myAFunction();


            BClasss bClass = new BClasss();

            Console.WriteLine(bClass.variablePublic);
            bClass.myBFunction();
            Console.WriteLine(bClass.variableInternal);
            Console.WriteLine(bClass.variableProtectedInternal);
            // Console.WriteLine(bClass.variablePrivate); Hata Koruma Duzeyi private


            Console.ReadKey();// Console Cıkmamak İçin
        }
    }



}
