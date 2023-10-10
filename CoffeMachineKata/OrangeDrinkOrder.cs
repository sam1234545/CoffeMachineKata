using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachineKata
{
    internal class OrangeDrinkOrder : DrinkOrder
    {
        public OrangeDrinkOrder(double moneyAmount, string sugar, string spoon) : base(moneyAmount, sugar, spoon)
        {
        }

        private const string ORANGE_VALUE = "Orange";
        private const double MINIMUM_AMOUNT_ORANGE = 0.6;

        public override string GetOrder()
        {

            if (MoneyAmount >= MINIMUM_AMOUNT_ORANGE)
            {
                return SendDrinkOrder(ORANGE_VALUE);
            }
            else
            {
                return SendMessageNotEnoughMoney(ORANGE_VALUE);
            }
        }
    }
}