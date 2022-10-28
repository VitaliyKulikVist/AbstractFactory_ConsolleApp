namespace AbstractFactory_ConsolleApp
{
    public interface IAbstractProductB
    {
        // Продукт B здатний виконувати свої дії...
        string UsefulFunctionB();

        // ...але він також може співпрацювати з ProductA.
        //
        // Абстрактна фабрика гарантує, що всі продукти, які вона створює, є of
        // той самий варіант і, таким чином, сумісний.
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}
