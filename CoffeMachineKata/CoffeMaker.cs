
namespace CoffeMachineKata
{
    public class CoffeMaker
    {
        const string CHOCOLATE = "H";
        const string COFFEE = "C";
        const string TEA = "T";
        const string ORANGE = "O";
        internal const string HOT = "h";

        private const char MESSAGE_CONTENT = 'M';
        private const string ERROR = "Please make an order";
        private const char SEPARATOR = ':';

        public string MakeDrink(string order, double moneyAmount = 0.0)
        {
            if (!order.StartsWith(MESSAGE_CONTENT))
            {
                return GetCustomerOrder(order, moneyAmount);
            }
            return DisplayMessage(order);
        }

        private static string DisplayMessage(string order)
        {
            return order.Substring(2);
        }

        private string GetCustomerOrder(string order, double moneyAmount)
        {
            string[] orderInstructions = order.Split(SEPARATOR);
            string drinkOrderValue = orderInstructions[0];
            string isHot = "";
            if (drinkOrderValue.Length > 0 && drinkOrderValue.Length >= 2)
            {
                isHot = drinkOrderValue.Substring(1, 1);
                orderInstructions[0] = drinkOrderValue.Substring(0, 1);

            }
            switch (orderInstructions[0])
            {
                case ORANGE:
                    {
                        DrinkOrder drinkOrder = new OrangeDrinkOrder(moneyAmount, orderInstructions[0], orderInstructions[1], orderInstructions[2]);
                        return drinkOrder.GetOrder();
                    }
                case CHOCOLATE:
                    {
                        if (!string.IsNullOrEmpty(isHot) && isHot == HOT)
                        {
                            DrinkOrder drinkOrder = new ChocolateDrinkOrder(moneyAmount, orderInstructions[0], orderInstructions[1], orderInstructions[2], true);
                            return drinkOrder.GetOrder();
                        }
                        else
                        {
                            DrinkOrder drinkOrder = new ChocolateDrinkOrder(moneyAmount, orderInstructions[0], orderInstructions[1], orderInstructions[2]);
                            return drinkOrder.GetOrder();
                        }
                       
                      //  return drinkOrder.GetOrder();
                    }

                case COFFEE:
                    {
                        DrinkOrder drinkOrder = new CoffeeDrinkOrder(moneyAmount, orderInstructions[0], orderInstructions[1], orderInstructions[2]);
                        return drinkOrder.GetOrder();
                    }

                case TEA:
                    {
                        DrinkOrder drinkOrder = new TeaDrinkOrder(moneyAmount, orderInstructions[0], orderInstructions[1], orderInstructions[2]);
                        return drinkOrder.GetOrder();
                    }

                default:
                    return MakeDrink(string.Format("{0}{1}{2}", MESSAGE_CONTENT, SEPARATOR, ERROR));
            }
        }
    }
}