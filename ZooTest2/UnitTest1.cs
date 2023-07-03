using Lab06_Zoo.Zoo;
using Lab06_Zoo.ZooInterfaces;

namespace ZooTest2
{
    public class UnitTest1
    {
        [Fact]
        private static void TestTheClassesThatImplementTheInterFacesActuallyiIplementIit()
        {
            //Arrange
            Lion lion = new Lion("Simba", 4, false, "yellow", "King of the Jungle")
            { LifeSpanPeriod = 12 };

            Hawk hawk = new Hawk("Hawkeye", 2, true, 120, 55.6)
            { LifeSpanPeriod = 17, MigrationDestance = 8500 };
            
            Snake snake = new Snake("Nagini", 0, false, "semi-hard")
            { MigrationDestance = 10 };

            Crocodile crocodile = new Crocodile("Brutus", 4, false, "hard")
            { LifeSpanPeriod = 70 };
                
           
            //Assert

            Assert.IsAssignableFrom<ILifeSpan> (lion);
            
            Assert.IsAssignableFrom<IMigration>(hawk);
            Assert.IsAssignableFrom<ILifeSpan>(hawk);

            Assert.IsAssignableFrom<IMigration>(snake);        

            Assert.IsAssignableFrom<IMigration>(crocodile);
            Assert.IsAssignableFrom<ILifeSpan>(crocodile);
        }

        [Fact]
        public void TestInheritance()
        {
            //Assert
            Reptile reptile = new Crocodile("Brutus", 4, false, "hard");
            // Act            
            Assert.Equal("hard", reptile.SkinSoftness);
            // Assert
            Assert.True(reptile is Animal);
        }

        [Fact]
        public void ProveMethodsHaveBeenOverridden()
        {
            // Arrange
            Hawk hawk = new Hawk("Hawkeye", 2, true, 120, 55.6)
            { LifeSpanPeriod = 17, MigrationDestance = 8500 };
            // Act
            var result = hawk.Living();
            // Assert
            Assert.Equal("Hawkeye live in forests and mountains", hawk.Living().ToString());
        }

        [Fact]
        public void ProveThatConcreteIsAnAnimal()
        {
            // Arrange
            Snake snake = new Snake("Nagini", 0, false, "semi-hard");

            //Assert 
            Assert.IsAssignableFrom<Animal>(snake);

        }
    }
}