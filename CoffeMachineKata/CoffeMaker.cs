using System.Runtime.CompilerServices;

namespace CoffeMachineKata
{
    public class CoffeMaker
    {
        const char CHOCOLATE = 'H';
        const char COFFEE = 'C';
        const char TEA = 'T';

        public string MakeDrink(string order)
        {
            
            char[] orderInstructions = order.ToCharArray();
            var drink = orderInstructions[0];

            if (drink ==CHOCOLATE)
            {
                return "Chocolate with 1 sugar and 1 spoon";
            }
            if (drink == COFFEE)
            {
                return "Coffee with 1 sugar and 1 spoon";
            }
            return "Tea with 1 sugar and 1 spoon";
        }
    }
}