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

        private const string NO = "no";
        private const string INDEFINITE_ARTICLE = "a";

        private const string NO_SUGAR_ORDER = "0";
        string? _drink;
        string? _sugar;
        string? _spoon;

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
            SetOrder(order);
            string[] orderInstructions = order.Split(SEPARATOR);
 
            switch (_drink)
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

        private void SetOrder(string order)
        {
            string[] orderInstructions = order.Split(SEPARATOR);
            _drink = orderInstructions[0];
            SetSugar(orderInstructions);
            SetSpoon(orderInstructions);
        }

        private void SetSugar(string[] orderInstructions)
        {
            if (!string.IsNullOrEmpty(orderInstructions[1]))
            {
                _sugar = orderInstructions[1];
            }
            else
            {
                _sugar = NO;
            }
        }

        private void SetSpoon(string[] orderInstructions)
        {
            if (string.IsNullOrEmpty(orderInstructions[1]) || string.IsNullOrEmpty(orderInstructions[2]))
            {
                _spoon = NO;
            }
            if (orderInstructions[2] == NO_SUGAR_ORDER)
            {
                _spoon = INDEFINITE_ARTICLE;
            }
        }
    }
}