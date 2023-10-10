﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachineKata
{
    internal abstract class DrinkOrder
    {

        internal const string NO = "no";
        internal const string NO_SUGAR_ORDER = "0";
        internal const string INDEFINITE_ARTICLE = "a";
        internal const char MESSAGE_CONTENT = 'M';
        internal const char SEPARATOR = ':';
        internal readonly string? Sugar;
        internal string? Drink { get; private set; }
        internal readonly string? Spoon;
        internal readonly double MoneyAmount;
        public DrinkOrder(double moneyAmount, string drink, string sugar, string spoon)
        {
            MoneyAmount = moneyAmount;
            Drink = drink;


            if (!string.IsNullOrEmpty(sugar))
            {
                Sugar = sugar;
            }
            else
            {
                Sugar = NO;
            }

            if (string.IsNullOrEmpty(sugar) || string.IsNullOrEmpty(spoon))
            {
                Spoon = NO;
            }
            if (spoon == NO_SUGAR_ORDER)
            {
                Spoon = INDEFINITE_ARTICLE;
            }
        }

        public abstract string GetOrder();

        internal string SendDrinkOrder( string drinkValue )
        {
            return string.Format("{0} with {1} sugar and {2} spoon", drinkValue, Sugar, Spoon);
        }

        internal string SendMessageNotEnoughMoney(string drinkValue)
        {
            CoffeMaker coffeeMaker = new CoffeMaker();
            return coffeeMaker.MakeDrink(string.Format("{0}{1}The amount {2} is not enough for ordering {3}", MESSAGE_CONTENT, SEPARATOR, MoneyAmount, drinkValue));
        }
    }
}
