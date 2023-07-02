using Lab06_Zoo.Zoo;

namespace ZooTest
{
    public class UnitTest1
    {
         
        [Fact]
        private static void LionBehaviors()
        {
            // Arrange 
            var lion = new Lion("Simba", 4, false, "yellow", "King of the Jungle");

            // Act 
            var eatResult = lion.Eat();
            var sleepResult = lion.Sleep();
            var soundResult = lion.Sound();
            var livingResult = lion.Living();

            // Assert 
            Assert.Equal("Simba eating meats so they are Carnivores", eatResult);
            Assert.Equal("Simba sleep under the Trees", sleepResult);
            Assert.Equal("Simba Roars Loudly!", soundResult);
            Assert.Equal("Simba lives in grasslands, savannas, open woodlands", livingResult);
        }

        

        [Fact]
        private static void SnakeBehaviors()
        {
            // Arrange 
            var snake = new Snake("Nagini", 0, false, "semi-hard");

            // Act 
            var eatResult = snake.Eat();
            var sleepResult = snake.Sleep();
            var soundResult = snake.Sound();
            var livingResult = snake.Living();

            // Assert 
            Assert.Equal("Nagini feeds on small mammals, birds, and reptiles.", eatResult);
            Assert.Equal("Nagini rests in hidden areas such as burrows or vegetation", sleepResult);
            Assert.Equal("Nagini produces hissing sounds when threatened!", soundResult);
            Assert.Equal("Nagini inhabits various environments including forests, grasslands, and deserts", livingResult);
        }
    }
}