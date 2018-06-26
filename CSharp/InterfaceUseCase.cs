using System;

// OK
namespace CSharp
{
    interface ISampleInterface
    {
        void SampleMethod();
    }

    class ImplementationClass : ISampleInterface
    {
        // Explicit interface member implementation: 
        void ISampleInterface.SampleMethod()
        {
            Console.WriteLine("SampleMethod Interface");
            // Method implementation.

        }
    }

    public class InterfaceUseCase
    {
        public InterfaceUseCase()
        {
            // Declare an interface instance.
            ISampleInterface obj = new ImplementationClass();

            // Call the member.
            obj.SampleMethod();
        }


    }

    // Eine Schnittstelle kann von einer oder mehreren Basisschnittstellen erben.
}
