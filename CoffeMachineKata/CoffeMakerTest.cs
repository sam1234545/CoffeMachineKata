namespace CoffeMachineKata
{
    public class CoffeMakerTest
    {
        [Fact]
        public void Should_SendOneTea_OneSugar_OneSpoon_WhenOrdered()
        {
            var order = MakeDrink("T:1:1");
            Assert.Equal("Tea with 1 sugar and 1 spoon", order);
        }

        private string MakeDrink(string order)
        {
            return "Tea with 1 sugar and 1 spoon";
        }
    }
}