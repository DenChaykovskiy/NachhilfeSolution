using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class BaseClass
    {
        public virtual void DoWork()
        {
            Console.WriteLine("BaseClass DoWork");
        }       
    }
    public class DerivedClass : BaseClass
    {
        public override void DoWork()
        {
            // base.DoWork();   // calls BAseClass.DoWork
            Console.WriteLine("DerivedClass DoWork");
        }      
    }


    public class VirtualUseCase
    {
        public VirtualUseCase()
        {
            new BaseClass().DoWork(); 
            new DerivedClass().DoWork(); 


            DerivedClass B = new DerivedClass();
            B.DoWork();  // Calls the new method.

            BaseClass A = (BaseClass)B;
            A.DoWork();  // Also calls the new method.
        }
    }
}
