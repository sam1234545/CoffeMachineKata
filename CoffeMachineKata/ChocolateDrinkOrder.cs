using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachineKata
{
    internal class ChocolateDrinkOrder : DrinkOrder
    {
        private const string CHOCOLATE_VALUE = "Chocolate";
        private const double MINIMUM_AMOUNT_CHOCOLATE = 0.5;
        public ChocolateDrinkOrder(double moneyAmount, string drink, string sugar, string spoon) : base(moneyAmount, drink, sugar, spoon)
        {
        }

        public override string GetOrder()
        {
            if (MoneyAmount >= MINIMUM_AMOUNT_CHOCOLATE)
            {
                return SendDrinkOrder();
            }
            else
            {
                return SendMessageNotEnoughMoney();
            }
        }

        internal override string SendDrinkOrder()
        {
            return string.Format("{0} with {1} sugar and {2} spoon", CHOCOLATE_VALUE, Sugar, Spoon);
        }

        internal override string SendMessageNotEnoughMoney()
        {
            CoffeMaker coffeeMaker = new CoffeMaker();
            return coffeeMaker.MakeDrink(string.Format("{0}{1}The amount {2} is not enough for ordering {3}", MESSAGE_CONTENT, SEPARATOR, MoneyAmount, CHOCOLATE_VALUE));
        }
    }
}
