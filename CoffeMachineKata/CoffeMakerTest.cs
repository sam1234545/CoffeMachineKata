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
            var order = CoffeMaker.MakeDrink("T:0:0");
            Assert.Equal("Tea with 0 sugar and 0 spoon", order);
        }

        [Fact]
        public void Should_SendOneCoffeeNoSugar_NoSpoon_WhenOrdered()
        {
            var CoffeMaker = new CoffeMaker();
            var order = CoffeMaker.MakeDrink("C:0:0");
            Assert.Equal("Coffee with 0 sugar and 0 spoon", order);
        }
    }
}