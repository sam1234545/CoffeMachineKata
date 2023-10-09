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
        string? _drink;
        string? _sugar;
        string? _spoon;
        private readonly double moneyAmount;

       

        public CoffeMaker(double moneyAmount)
        {
            this.moneyAmount = moneyAmount;
        }
        public CoffeMaker()
        {

        }

        public string MakeDrink(string order)
        {
            if (!order.StartsWith(MESSAGE_CONTENT))
            {
                return GetCustomerOrder(order);
            }
            return DisplayMessage(order);
        }

        private static string DisplayMessage(string order)
        {
            return order.Substring(2);
        }

        private string GetCustomerOrder(string order)
        {
            SetOrder(order);
            switch (_drink)
            {
                case CHOCOLATE:
                    return string.Format("{0} with {1} sugar and {2} spoon", CHOCOLATE_VALUE, _sugar, _spoon);
                case COFFEE:
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

                case TEA:
                    {
                        return GetTeaOrder();
                    }

                default:
                    return MakeDrink(string.Format("M:{0}",ERROR));
            }
        }

        private string GetTeaOrder()
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
            setSugar(orderInstructions);
            SetSpoon(orderInstructions);
        }

        private void setSugar(string[] orderInstructions)
        {
            if (!string.IsNullOrEmpty(orderInstructions[1]))
            {
                _sugar = orderInstructions[1];
            }
            else
            {
                _sugar = "no";
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