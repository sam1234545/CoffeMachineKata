using System.Runtime.CompilerServices;

namespace CoffeMachineKata
{
    public class CoffeMaker
    {
        const string CHOCOLATE = "H";
        const string COFFEE = "C";
        const string TEA = "T";

        string? _drink;
        string? _sugar;
        string? _spoon;

        public string MakeDrink(string order)
        {
            SetOrder(order);

            if (_drink == CHOCOLATE)
            {
                return "Chocolate with 1 sugar and 1 spoon";
            }
            if (_drink == COFFEE)
            {
                return "Coffee with 1 sugar and 1 spoon";
            }
            return string.Format("Tea with {0} sugar and {1} spoon", _sugar, _spoon);
        }

        private void SetOrder(string order)
        {
            string[] orderInstructions = order.Split(':');
            _drink = orderInstructions[0];
            _sugar = orderInstructions[1];
            _spoon = orderInstructions[1] != "0" ? orderInstructions[2] : "0";
        }
    }
}