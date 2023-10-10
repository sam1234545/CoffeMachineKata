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
                return SendDrinkOrder(TEA_VALUE);
            }
            else
            {
                return SendMessageNotEnoughMoney(TEA_VALUE);
            }
        }
    }
}
