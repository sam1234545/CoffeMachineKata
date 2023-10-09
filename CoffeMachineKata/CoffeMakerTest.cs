namespace CoffeMachineKata
{
    public class CoffeMakerTest 
    {
        [Fact]
        public void Should_SendOneTea_OneSugar_aSpoon_WhenOrdered()
        {
            var CoffeMaker = new CoffeMaker();
            var order = CoffeMaker.MakeDrink("T:1:0");
            Assert.Equal("Tea with 1 sugar and a spoon", order);
        }

        [Fact]
        public void Should_SendOneCoffee_OneSugar_ASpoon_WhenOrdered()
        {
            var CoffeMaker = new CoffeMaker();
            var order = CoffeMaker.MakeDrink("C:1:0");
            Assert.Equal("Coffee with 1 sugar and a spoon", order);
        }

        [Fact]
        public void Should_SendOneChocalate_OneSugar_ASpoon_WhenOrdered()
        {
            var CoffeMaker = new CoffeMaker();
            var order = CoffeMaker.MakeDrink("H:1:0");
            Assert.Equal("Chocolate with 1 sugar and a spoon", order);
        }

        [Fact]
        public void Should_SendOneTeaNoSugar_ASpoon_WhenOrdered()
        {
            var CoffeMaker = new CoffeMaker();
            var order = CoffeMaker.MakeDrink("T::");
            Assert.Equal("Tea with no sugar and no spoon", order);
        }

        [Fact]
        public void Should_SendOneCoffeeNoSugar_ASpoon_WhenOrdered()
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