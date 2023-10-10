namespace CoffeMachineKata
{
    internal class CoffeeDrinkOrder : DrinkOrder
    {
        private const double MINIMUM_AMOUNT_COFFEE = 0.6;
        private const string COFFEE_VALUE = "Coffee";

        public CoffeeDrinkOrder(double moneyAmount, string sugar, string spoon, bool isHot) : base(moneyAmount, sugar, spoon, isHot)
        {
        }

        public override string GetOrder()
        {
            if (MoneyAmount >= MINIMUM_AMOUNT_COFFEE)
            {
                return SendDrinkOrder(COFFEE_VALUE);
            }
            else
            {
                return SendMessageNotEnoughMoney(COFFEE_VALUE);
            }
        }
    }
}