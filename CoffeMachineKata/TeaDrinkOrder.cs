namespace CoffeMachineKata
{
    internal class TeaDrinkOrder : DrinkOrder
    {
        private const double MINIMUM_AMOUNT_TEA = 0.4;
        private const string TEA_VALUE = "Tea";
        public TeaDrinkOrder(double moneyAmount, string drink, string sugar, string spoon) : base(moneyAmount, drink, sugar, spoon)
        {
        }

        public override string GetOrder()
        {
            if (MoneyAmount >= MINIMUM_AMOUNT_TEA)
            {
                return SendDrinkOrder();
            }
            else
            {
                return SendMessageNotEnoughMoney();
            }
        }

        internal override string SendDrinkOrder()
        {
            return string.Format("{0} with {1} sugar and {2} spoon", TEA_VALUE, Sugar, Spoon);
        }

        internal override string SendMessageNotEnoughMoney()
        {
            CoffeMaker coffeeMaker = new CoffeMaker();
            return coffeeMaker.MakeDrink(string.Format("{0}{1}The amount {2} is not enough for ordering {3}", MESSAGE_CONTENT, SEPARATOR, MoneyAmount, TEA_VALUE));
        }
    }
}
