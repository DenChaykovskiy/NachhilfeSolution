using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    abstract class AbstractClass
    {
        // A Non abstract method
        public int AddTwoNumbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }


        // An abstract method, to be overridden in derived class
        public abstract int MultiplyTwoNumbers(int Num1, int Num2);
    }


    // MultiplyTwoNumbers overridden
    class AbstractDerived : AbstractClass
    {
        public override int MultiplyTwoNumbers(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
    }


    public class AbstractUseCase
    {
        public AbstractUseCase()
        {

            // you can NOT create an instance of abstract class 
            // AbstractClass derivedCalculate = new AbstractClass();
                      

            // Abstract is overrriden, now you can create an instance 
            AbstractDerived derivedCalculate = new AbstractDerived();
            int added = derivedCalculate.AddTwoNumbers(10, 20);
            int multiplied = derivedCalculate.MultiplyTwoNumbers(10, 20);

            Console.WriteLine("Added : {0}, Multiplied: {1} ", added, multiplied);
        }
    }




    /*
    The advantages of an abstract class are:
        - Ability to specify default implementations of methods
        - Added invariant checking to functions
        - Have slightly more control in how the "interface" methods are called
        - Ability to provide behavior related or unrelated to the interface for "free"
    Interfaces are merely data passing contracts and do not have these features.
    However, they are typically more flexible as a type can only be derived from one class, but can implement any number of interfaces.
    */
}
