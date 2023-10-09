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
                return string.Format("{0} with {1} sugar and {2} spoon", COFFEE_VALUE ,_sugar, _spoon); ;
            }
            return string.Format("{0} with {1} sugar and {2} spoon", TEA_VALUE, _sugar, _spoon);
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