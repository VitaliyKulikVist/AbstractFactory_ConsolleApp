namespace AbstractFactory_ConsolleApp
{
    class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "Результат продукту B1.";
        }

        // Варіант, продукт B1, може правильно працювати лише з
        // варіант, продукт A1. Тим не менш, він приймає будь-які випадки
        // AbstractProductA як аргумент.
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"Результат спiвпрацi B1 з ({result})";
        }
    }
}
