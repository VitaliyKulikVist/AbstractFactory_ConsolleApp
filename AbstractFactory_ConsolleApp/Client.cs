using AbstractFactory_ConsolleApp.Infrastructure.Interface.ConcreteFactorys;
using System;

namespace AbstractFactory_ConsolleApp
{
    public class Client
    {
        public void Main()
        {
            // Клієнтський код може працювати з будь-яким конкретним фабричним класом.

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Клiєнт: Тестування коду клiєнта з першим заводським типом...");
            Console.ResetColor();
            ClientMethod(new ConcreteFactory1());

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Клiєнт: Тестування того самого коду клiєнта з другим заводським типом...");
            Console.ResetColor();
            ClientMethod(new ConcreteFactory2());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
            Console.ResetColor();
        }
    }
}
