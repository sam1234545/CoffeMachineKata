using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachineKata
{
    internal abstract class DrinkOrder
    {

        protected const string NO = "no";
        protected const string NO_SUGAR_ORDER = "0";
        protected const string INDEFINITE_ARTICLE = "a";
        protected const char MESSAGE_CONTENT = 'M';
        protected const string EXTRA_HOT_DRINK_TEXT = "An extra hot";
        protected const char SEPARATOR = ':';
        protected readonly string? Sugar;
        protected readonly string? Drink;
        protected readonly string? Spoon;
        protected readonly double MoneyAmount;
        protected readonly bool IsHot;
        public DrinkOrder(double moneyAmount, string sugar, string spoon, bool isHot = default)
        {
            MoneyAmount = moneyAmount;
            IsHot = isHot;

            bool addSugar = !string.IsNullOrEmpty(sugar);
            if (!addSugar)
            {
                Sugar = NO;
            }
            else
            {
                Sugar = sugar;
            }
            bool noSpoonInput = string.IsNullOrEmpty(spoon);

            if (!addSugar || noSpoonInput)
            {
                Spoon = NO;
            }
            if (spoon == NO_SUGAR_ORDER)
            {
                Spoon = INDEFINITE_ARTICLE;
            }
        }

        public abstract string GetOrder();

        protected string SendDrinkOrder(string drinkValue)
        {
            if (IsHot)
            {
                return string.Format("{0} {1} with {2} sugar and {3} spoon", EXTRA_HOT_DRINK_TEXT, drinkValue, Sugar, Spoon);
            }
            return string.Format("{0} with {1} sugar and {2} spoon", drinkValue, Sugar, Spoon);
        }

        protected string SendMessageNotEnoughMoney(string drinkValue)
        {
            CoffeMaker coffeeMaker = new CoffeMaker();
            return coffeeMaker.MakeDrink(string.Format("{0}{1}The amount {2} is not enough for ordering {3}", MESSAGE_CONTENT, SEPARATOR, MoneyAmount.ToString(CultureInfo.InvariantCulture), drinkValue));
        }
    }
}
