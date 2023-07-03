using Lab06_Zoo.Zoo;

namespace Lab06_Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion("Simba", 4, false,"yellow", "King of the Jungle")
            { LifeSpanPeriod = 12};

            Console.WriteLine($"The Lion Name is : {lion.Name} and his ability to fly is {lion.FlyAbility}," +
                $" he has {lion.NumberOfLegs} legs, his Color is {lion.Color}");

            Console.WriteLine(lion.Eat());
            Console.WriteLine(lion.Sleep());
            Console.WriteLine(lion.Sound());
            Console.WriteLine(lion.Living());
            lion.Breastfeed();
            Console.WriteLine(lion.NeckHair());
            lion.LifeSpan(); // Interface
            Console.WriteLine("===================");
            Console.WriteLine();

            Hawk hawk = new Hawk("Hawkeye", 2, true, 120, 55.6)
            { LifeSpanPeriod = 17, MigrationDestance = 8500 };

            Console.WriteLine($"The Hawk Name is : {hawk.Name} and his ability to fly is {hawk.FlyAbility}," +
                $" he has {hawk.NumberOfLegs} legs, his speed is {hawk.Speed}");

            Console.WriteLine(hawk.Eat());
            Console.WriteLine(hawk.Sleep());
            Console.WriteLine(hawk.Sound());
            Console.WriteLine(hawk.Living());
            Console.WriteLine(hawk.Beak());
            hawk.DisplayWingSize();
            hawk.MigrationHapit(); // Interface
            hawk.LifeSpan(); // Interface
            Console.WriteLine("===================");
            Console.WriteLine();

            Snake snake = new Snake("Nagini", 0, false, "semi-hard")
            { MigrationDestance = 10 };

            Console.WriteLine($"The Snake Name is : {snake.Name} and his ability to fly is {snake.FlyAbility}," +
                $" he has {snake.NumberOfLegs} legs, his skin is {snake.SkinSoftness}");

            Console.WriteLine(snake.Eat());
            Console.WriteLine(snake.Sleep());
            Console.WriteLine(snake.Sound());
            Console.WriteLine(snake.Living());
            Console.WriteLine(snake.ShedSkin());
            snake.SharpTeeth();
            snake.MigrationHapit(); // Interface
            Console.WriteLine("===================");

            Crocodile crocodile = new Crocodile("Brutus", 4, false, "hard")
            { LifeSpanPeriod = 70 };

            Console.WriteLine($"The Crocodile Name is : {crocodile.Name} and his ability to fly is {crocodile.FlyAbility}," +
                $" he has {crocodile.NumberOfLegs} legs, his skin is {crocodile.SkinSoftness}");

            Console.WriteLine(crocodile.Eat());
            Console.WriteLine(crocodile.Sleep());
            Console.WriteLine(crocodile.Sound());
            Console.WriteLine(crocodile.Living());           
            crocodile.SharpTeeth();
            crocodile.MigrationHapit(); // Interface
            crocodile.LifeSpan();  // Interface
            Console.WriteLine("===================");
        }
    }
}