namespace CoffeMachineKata
{
    public class CoffeMakerTest 
    {
    
        [Fact]
        public void Should_SendErreurMessage_When_NoOrder()
        {
            var coffeMaker = new CoffeMaker();
            var order = coffeMaker.MakeDrink(":0:0");
            Assert.Equal("Please make an order", order);
        }
        [Fact]
        public void Should_SendMessage_When_ThereisMessageinput()
        {
            var coffeMaker = new CoffeMaker();
            var order = coffeMaker.MakeDrink("M:Hello There");
            Assert.Equal("Hello There", order);
        }

        [Fact]
        public void Should_SendOneTea_OneSugar_aSpoon_WhenOrdered_WithRightPrice()
        {
            var coffeMaker = new CoffeMaker();
            var order = coffeMaker.MakeDrink("T:1:0", 0.4);
            Assert.Equal("Tea with 1 sugar and a spoon", order);
        }

        [Fact]
        public void Should_SendOneTea_OneSugar_aSpoon_WhenOrdered_WithlessPricePrice()
        {
            var coffeMaker = new CoffeMaker();
            var order = coffeMaker.MakeDrink("T:1:0",0.2);
            Assert.Equal("The amount 0.2 is not enough for ordering Tea", order);
        }

        [Fact]
        public void Should_SendOneCoffee_OneSugar_aSpoon_WhenOrdered_WithRightPrice()
        {
            var coffeMaker = new CoffeMaker();
            var order = coffeMaker.MakeDrink("C:1:0", 0.6);
            Assert.Equal("Coffee with 1 sugar and a spoon", order);
        }

        [Fact]
        public void Should_SendOneCoffee_OneSugar_aSpoon_WhenOrdered_WithWrongPrice()
        {
            var coffeMaker = new CoffeMaker();
            var order = coffeMaker.MakeDrink("C:1:0", 0.3);
            Assert.Equal("The amount 0.3 is not enough for ordering Coffee", order);
        }


        [Fact]
        public void Should_SendOneChocolate_OneSugar_aSpoon_WhenOrdered_WithRightPrice()
        {
            var coffeMaker = new CoffeMaker();
            var order = coffeMaker.MakeDrink("H:1:0", 0.6);
            Assert.Equal("Chocolate with 1 sugar and a spoon", order);
        }

        [Fact]
        public void Should_SendOneChocolate_OneSugar_aSpoon_WhenOrdered_WithWrongPrice()
        {
            var coffeMaker = new CoffeMaker();
            var order = coffeMaker.MakeDrink("H:1:0", 0.3);
            Assert.Equal("The amount 0.3 is not enough for ordering Chocolate", order);
        }

        [Fact]
        public void Should_SendOneChocolateNoSugar_NoSpoon_WhenOrdered_WithRightPrice()
        {
            var coffeMaker = new CoffeMaker();
            var order = coffeMaker.MakeDrink("H::",0.5);
            Assert.Equal("Chocolate with no sugar and no spoon", order);
        }

        [Fact]
        public void Should_SendOneOrange_OneSugar_aSpoon_WhenOrdered_WithWrongPrice()
        {
            var coffeMaker = new CoffeMaker();
            var order = coffeMaker.MakeDrink("O:1:0", 0.5);
            Assert.Equal("The amount 0.5 is not enough for ordering Orange", order);
        }

        [Fact]
        public void Should_SendOneOrangeNoSugar_NoSpoon_WhenOrdered_WithWrongPrice()
        {
            var coffeMaker = new CoffeMaker();
            var order = coffeMaker.MakeDrink("O::", 0.6);
            Assert.Equal("Orange with no sugar and no spoon", order);
        }

        [Fact]
        public void Should_SendOneHotChocolate_OneSugar_aSpoon_WhenOrdered_WithWrongPrice()
        {
            var coffeMaker = new CoffeMaker();
            var order = coffeMaker.MakeDrink("Hh:1:0", 0.3);
            Assert.Equal("The amount 0.3 is not enough for ordering Chocolate", order);
        }

        [Fact]
        public void Should_SendOneHotChocolateNoSugar_NoSpoon_WhenOrdered_WithRightPrice()
        {
            var coffeMaker = new CoffeMaker();
            var order = coffeMaker.MakeDrink("Hh::", 0.5);
            Assert.Equal("An extra hot Chocolate with no sugar and no spoon", order);
        }
    }
}