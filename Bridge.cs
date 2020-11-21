using System;
using System.Collections.Generic;
using System.Text;

namespace Wzorce_projektowe
{
    class Lab7Bridge : Lab
    {
        public void Run()
        {
            Shape redSquare = new Square(new Red());
            redSquare.draw();

            Shape blueTriangle = new Triangle(new Blue());
            blueTriangle.draw();
        }
    }
    abstract class Shape
    {
        protected IColor color;

        public Shape(IColor color)
        {
            this.color = color;
        }
        public abstract void draw();
    }
    class Square : Shape
    {
        public Square(IColor color) :base(color)
        {

        }
        public override void draw()
        {
            Console.WriteLine("Square " + color.getName());
        }
    }
    class Triangle : Shape
    {
        public Triangle(IColor color) :base(color)
        {

        }
        public override void draw()
        {
            Console.WriteLine("Triangle " + color.getName());
        }
    }
    interface IColor
    {
        public String getName();
    }
    class Red : IColor
    {
        public String getName()
        {
            return "Red";
        }
    }
    class Blue : IColor
    {
        public String getName()
        {
            return "Blue";
        }
    }
}
