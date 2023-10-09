using System.Runtime.CompilerServices;

namespace CoffeMachineKata
{
    public class CoffeMaker
    {
        const string CHOCOLATE = "H";
        const string COFFEE = "C";
        const string TEA = "T";
        const string COFFEE_VALUE = "Coffee";
        const string TEA_VALUE = "Tea";
        const string CHOCOLATE_VALUE = "Chocolate";
        private const char MESSAGE_CONTENT = 'M';
        private const string ERROR = "Please make an order";
        private const char SEPARATOR = ':';

        private const string NO = "no";
        private const string INDEFINITE_ARTICLE = "a";

        private const double MINIMUM_AMOUNT_TEA = 0.4;
        public const double MINIMUM_AMOUNT_COFFEE = 0.6;
        public const double MINIMUM_AMOUNT_CHOCOLATE = 0.5;
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
            switch (_drink)
            {
                case CHOCOLATE:
                    {
                        return GetChocolateOrder(moneyAmount);
                    }
                case COFFEE:
                    {
                        return GetCoffeeOrder(moneyAmount);
                    }

                case TEA:
                    {
                        return GetTeaOrder(moneyAmount);
                    }

                default:
                    return MakeDrink(string.Format("M:{0}", ERROR));
            }
        }

        private string GetChocolateOrder(double moneyAmount)
        {
            if (moneyAmount >= MINIMUM_AMOUNT_CHOCOLATE)
            {
                return string.Format("{0} with {1} sugar and {2} spoon", CHOCOLATE_VALUE, _sugar, _spoon);
            }
            else
            {
                return MakeDrink(string.Format("M:The amount {0} is not enough for ordering {1}", moneyAmount, CHOCOLATE_VALUE));
            }
        }

        private string GetCoffeeOrder(double moneyAmount)
        {
            if (moneyAmount >= MINIMUM_AMOUNT_COFFEE)
            {
                return string.Format("{0} with {1} sugar and {2} spoon", COFFEE_VALUE, _sugar, _spoon);
            }
            else
            {
                return MakeDrink(string.Format("M:The amount {0} is not enough for ordering {1}", moneyAmount, COFFEE_VALUE));
            }
        }

        private string GetTeaOrder(double moneyAmount)
        {
            if (moneyAmount >= MINIMUM_AMOUNT_TEA)
            {
                return string.Format("{0} with {1} sugar and {2} spoon", TEA_VALUE, _sugar, _spoon);
            }
            else
            {
                return MakeDrink(string.Format("M:The amount {0} is not enough for ordering {1}", moneyAmount, TEA_VALUE));
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
            if (orderInstructions[2] == "0")
            {
                _spoon = INDEFINITE_ARTICLE;
            }
        }
    }
}