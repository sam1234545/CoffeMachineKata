namespace CoffeMachineKata
{
    public class CoffeMaker
    {

        public string MakeDrink(string order)
        {

            if (order.StartsWith('H'))
            {
                return "Chocolate with 1 sugar and 1 spoon";
            }
            if (order.StartsWith('C'))
            {
                return "Coffee with 1 sugar and 1 spoon";
            }
            return "Tea with 1 sugar and 1 spoon";
        }
    }
}