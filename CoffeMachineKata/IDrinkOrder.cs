namespace CoffeMachineKata
{
    internal interface IDrinkOrder
    {
        void SetDrinkOrder(string order);
        void SetSpoon(string[] orderInstructions);
        void SetSugar(string[] orderInstructions);
    }
}
