using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class AdapterUseCase
    {
        public AdapterUseCase()
        {

            TargetInterface target = new Adapter();
            target.Request();

            Console.ReadKey();

        }

        class TargetInterface

        {
            public virtual void Request()
            {
                Console.WriteLine("Called TargetInterface Request()");
            }
        }



        class Adapter : TargetInterface

        {
            private AdapteeInterface _adaptee = new AdapteeInterface();

            public override void Request()
            {
                _adaptee.SpecificRequest();
            }
        }
        class AdapteeInterface

        {
            public void SpecificRequest()
            {
                Console.WriteLine("Called SpecificRequest()");
            }
        }
     }
        
    
}

    
