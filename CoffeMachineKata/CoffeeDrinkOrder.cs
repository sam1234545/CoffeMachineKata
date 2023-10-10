namespace CoffeMachineKata
{
    internal class CoffeeDrinkOrder : DrinkOrder
    {
        private const double MINIMUM_AMOUNT_COFFEE = 0.6;
        private const string COFFEE_VALUE = "Coffee";

        public CoffeeDrinkOrder(double moneyAmount, string drink, string sugar, string spoon) : base(moneyAmount, drink, sugar, spoon)
        {
        }

        public override string GetOrder()
        {
            if (MoneyAmount >= MINIMUM_AMOUNT_COFFEE)
            {
                return SendDrinkOrder();
            }
            else
            {
                return SendMessageNotEnoughMoney();
            }
        }
        internal override string SendMessageNotEnoughMoney()
        {
            CoffeMaker coffeeMaker = new CoffeMaker();
            return coffeeMaker.MakeDrink(string.Format("{0}{1}The amount {2} is not enough for ordering {3}", MESSAGE_CONTENT, SEPARATOR, MoneyAmount, COFFEE_VALUE));
        }
        internal override string SendDrinkOrder()
        {
            return string.Format("{0} with {1} sugar and {2} spoon", COFFEE_VALUE, Sugar, Spoon);
        }

    }
}
