namespace CoffeMachineKata
{
    public class CoffeMakerTest 
    {
    
        [Fact]
        public void Should_SendErreurMessage_When_NoOrder()
        {
            var CoffeMaker = new CoffeMaker();
            var order = CoffeMaker.MakeDrink(":0:0");
            Assert.Equal("Please make an order", order);
        }
        [Fact]
        public void Should_SendMessage_When_ThereisMessageinput()
        {
            var CoffeMaker = new CoffeMaker();
            var order = CoffeMaker.MakeDrink("M:Hello There");
            Assert.Equal("Hello There", order);
        }

        [Fact]
        public void Should_SendOneTea_OneSugar_aSpoon_WhenOrdered_WithRightPrice()
        {
            var CoffeMaker = new CoffeMaker(0.4);
            var order = CoffeMaker.MakeDrink("T:1:0");
            Assert.Equal("Tea with 1 sugar and a spoon", order);
        }

        [Fact]
        public void Should_SendOneTea_OneSugar_aSpoon_WhenOrdered_WithlessPricePrice()
        {
            var CoffeMaker = new CoffeMaker(0.2);
            var order = CoffeMaker.MakeDrink("T:1:0");
            Assert.Equal("The amount 0,2 is not enough for ordering Tea", order);
        }
    }
}