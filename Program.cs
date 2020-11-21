using System;

namespace Factory_method
{
    class Lab5FactoryMethod : Lab
    {
        public void Run()
        {
            Console.WriteLine("Witamy na targach samochodowych");
            MakeCarShow(new BmwFactory());
            MakeCarShow(new SkodaFactory());
        }
        void MakeCarShow(CarFactory carFactory)
        {
            carFactory.PresentBrandNewCar();
        }
    }
    public interface ICar
    {
        public void ShowTurnSignal();
    }

        //ICar,
        //Bmw,
        //Skoda,
        //CarFactory,
        //Skoda Factory,
        //BmwFactory

    interface CarFactory
    {
        void PresentBrandNewCar()
        {
            ICar car = FactoryMethodMakeCar();
            Console.WriteLine($"Witamy na pokazie samochodu marki {car.GetType().Name}");
            Console.WriteLine("Teraz zobaczymy jak działają kierunkowskazy");
            car.ShowTurnSignal();
            Console.WriteLine("Koniec pokazu");
        }
        ICar FactoryMethodMakeCar();

    }

    class BmwFactory : CarFactory
    {
        public ICar FactoryMethodMakeCar()
        {
            return new BMW();
        }

    }
    class SkodaFactory : CarFactory
    {
        public ICar FactoryMethodMakeCar()
        {
            return new Skoda();
        }
    }

    class BMW :  ICar
    {
        public void ShowTurnSignal()
        {
            Console.WriteLine("Kierowcy i tak ich nie używają więc w tym moedlu nie dodaliśmy kierunkowskazów");
        }
    }
    class Skoda : ICar
    {
        public void ShowTurnSignal()
        {
            Console.WriteLine("Zobaczcie jakie pięknie działające migacze");
        }
    }
}
