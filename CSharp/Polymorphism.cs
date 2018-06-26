namespace CSharp
{
    using System;
    using System.Collections.Generic;


    class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }


    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
            base.Draw();
        }
    }


    class Rectangle : Shape
    {
        public override void Draw()
        {        
            Console.WriteLine("Drawing a rectangle");
            base.Draw();
        }
    }


    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle");
            base.Draw();
        }
    }


    public class Polymorphism
    {
        public Polymorphism()
        { 

            var shapes = new List<Shape>
            {
                new Rectangle(),
                new Triangle(),
                new Circle()
            };
            
            foreach (var shape in shapes)
            {
                shape.Draw();
            }          
        }

    }

    /* Output:
        Drawing a rectangle
        Performing base class drawing tasks
        Drawing a triangle
        Performing base class drawing tasks
        Drawing a circle
        Performing base class drawing tasks
    */
}
