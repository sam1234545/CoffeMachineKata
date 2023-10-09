namespace CoffeMachineKata
{
    public class CoffeMakerTest 
    {
        [Fact]
        public void Should_SendOneTea_OneSugar_OneSpoon_WhenOrdered()
        {
            var CoffeMaker = new CoffeMaker();
            var order = CoffeMaker.MakeDrink("T:1:1");
            Assert.Equal("Tea with 1 sugar and 1 spoon", order);
        }

        [Fact]
        public void Should_SendOneCoffee_OneSugar_OneSpoon_WhenOrdered()
        {
            var CoffeMaker = new CoffeMaker();
            var order = CoffeMaker.MakeDrink("C:1:1");
            Assert.Equal("Coffee with 1 sugar and 1 spoon", order);
        }

        [Fact]
        public void Should_SendOneChocalate_OneSugar_OneSpoon_WhenOrdered()
        {
            var CoffeMaker = new CoffeMaker();
            var order = CoffeMaker.MakeDrink("H:1:1");
            Assert.Equal("Chocolate with 1 sugar and 1 spoon", order);
        }

        [Fact]
        public void Should_SendOneTeaNoSugar_NoSpoon_WhenOrdered()
        {
            var CoffeMaker = new CoffeMaker();
            var order = CoffeMaker.MakeDrink("T::");
            Assert.Equal("Tea with no sugar and no spoon", order);
        }

        [Fact]
        public void Should_SendOneCoffeeNoSugar_NoSpoon_WhenOrdered()
        {
            var CoffeMaker = new CoffeMaker();
            var order = CoffeMaker.MakeDrink("C::");
            Assert.Equal("Coffee with no sugar and no spoon", order);
        }

        [Fact]
        public void Should_SendOneChocolateNoSugar_NoSpoon_WhenOrdered()
        {
            var CoffeMaker = new CoffeMaker();
            var order = CoffeMaker.MakeDrink("H::");
            Assert.Equal("Chocolate with no sugar and no spoon", order);
        }
        [Fact]
        public void Should_SendErreurMessage_When_NoOrder()
        {
            var CoffeMaker = new CoffeMaker();
            var order = CoffeMaker.MakeDrink(":0:0");
            Assert.Equal("Please make an order", order);
        }
    }
}