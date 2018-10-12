using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class AdapterUseCase
    {
        public AdapterUseCase()
        {

            Target target = new Adapter();
            target.Request();

            Console.ReadKey();

        }

        class Target

        {
            public virtual void Request()
            {
                Console.WriteLine("Called Target Request()");
            }
        }



        class Adapter : Target

        {
            private Adaptee _adaptee = new Adaptee();

            public override void Request()
            {
                _adaptee.SpecificRequest();
            }
        }
        class Adaptee

        {
            public void SpecificRequest()
            {
                Console.WriteLine("Called SpecificRequest()");
            }
        }
     }
        
    
}

    
