using System.Runtime.CompilerServices;

namespace CoffeMachineKata
{
    public class CoffeMaker
    {
        const string CHOCOLATE = "H";
        const string COFFEE = "C";
        const string TEA = "T";

        public string MakeDrink(string order)
        {
            
            string[] orderInstructions = order.Split(':');
            var drink = orderInstructions[0];
            var sugar = orderInstructions[1];
            var spoon = orderInstructions[1] != "0" ? orderInstructions[2]:"0";

            if (drink ==CHOCOLATE)
            {
                return "Chocolate with 1 sugar and 1 spoon";
            }
            if (drink == COFFEE)
            {
                return "Coffee with 1 sugar and 1 spoon";
            }
            return string.Format("Tea with {0} sugar and {1} spoon",sugar,spoon);
        }
    }
}