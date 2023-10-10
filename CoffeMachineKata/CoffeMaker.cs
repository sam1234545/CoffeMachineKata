using System.Runtime.CompilerServices;

namespace CoffeMachineKata
{
    public class CoffeMaker
    {
        const string CHOCOLATE = "H";
        const string COFFEE = "C";
        const string TEA = "T";

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
 
            switch (orderInstructions[0])
            {
                case CHOCOLATE:
                    {
                        DrinkOrder drinkOrder = new ChocolateDrinkOrder(moneyAmount, orderInstructions[0], orderInstructions[1], orderInstructions[2]);
                        return drinkOrder.GetOrder();
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