using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachineKata
{
    internal class DrinkOrder: IDrinkOrder
    {
        private const string NO = "no";
        private const string INDEFINITE_ARTICLE = "a";

        private const char SEPARATOR = ':';
        private string? Drink;
        private string? Sugar;
        private string? Spoon;
        private double MoneyAmount = 0.0;

        public void SetDrinkOrder(string order)
        {
            string[] orderInstructions = order.Split(SEPARATOR);
            Drink = orderInstructions[0];
            SetSugar(orderInstructions);
            SetSpoon(orderInstructions);
        }

        public void SetSugar(string[] orderInstructions)
        {
            if (!string.IsNullOrEmpty(orderInstructions[1]))
            {
                Sugar = orderInstructions[1];
            }
            else
            {
                Sugar = NO;
            }
        }

        public void SetSpoon(string[] orderInstructions)
        {
            if (string.IsNullOrEmpty(orderInstructions[1]) || string.IsNullOrEmpty(orderInstructions[2]))
            {
                Spoon = NO;
            }
            if (orderInstructions[2] == "0")
            {
                Spoon = INDEFINITE_ARTICLE;
            }
        }
    }
}
