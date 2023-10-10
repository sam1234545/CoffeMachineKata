
namespace CoffeMachineKata
{
    internal class ChocolateDrinkOrder : DrinkOrder
    {
        private const string CHOCOLATE_VALUE = "Chocolate";
        private const double MINIMUM_AMOUNT_CHOCOLATE = 0.5;
        public ChocolateDrinkOrder(double moneyAmount, string drink, string sugar, string spoon) : base(moneyAmount, drink, sugar, spoon)
        {
        }

        public override string GetOrder()
        {
            if (MoneyAmount >= MINIMUM_AMOUNT_CHOCOLATE)
            {
                return SendDrinkOrder(CHOCOLATE_VALUE);
            }
            else
            {
                return SendMessageNotEnoughMoney(CHOCOLATE_VALUE);
            }
        }
    }
}
