using Lab06_Zoo.Zoo;

namespace Lab06_Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion("Simba", 4, false,"yellow", "King of the Jungle");

            Console.WriteLine($"The Lion Name is : {lion.Name} and his ability to fly is {lion.FlyAbility}," +
                $" he has {lion.NumberOfLegs} legs, his Color is {lion.Color}");

            Console.WriteLine(lion.Eat());
            Console.WriteLine(lion.Sleep());
            Console.WriteLine(lion.Sound());
            Console.WriteLine(lion.Living());
            lion.Breastfeed();
            Console.WriteLine(lion.NeckHair());
            Console.WriteLine();
            Console.WriteLine();

            Hawk hawk = new Hawk("Hawkeye", 2, true, 120, 55.6);

            Console.WriteLine($"The Hawk Name is : {hawk.Name} and his ability to fly is {hawk.FlyAbility}," +
                $" he has {hawk.NumberOfLegs} legs, his speed is {hawk.Speed}");

            Console.WriteLine(hawk.Eat());
            Console.WriteLine(hawk.Sleep());
            Console.WriteLine(hawk.Sound());
            Console.WriteLine(hawk.Living());
            Console.WriteLine(hawk.Beak());
            hawk.DisplayWingSize();
            Console.WriteLine();
            Console.WriteLine();

            Snake snake = new Snake("Nagini", 0, false, "semi-hard");

            Console.WriteLine($"The Snake Name is : {snake.Name} and his ability to fly is {snake.FlyAbility}," +
                $" he has {snake.NumberOfLegs} legs, his skin is {snake.SkinSoftness}");

            Console.WriteLine(snake.Eat());
            Console.WriteLine(snake.Sleep());
            Console.WriteLine(snake.Sound());
            Console.WriteLine(snake.Living());
            Console.WriteLine(snake.ShedSkin());
            hawk.DisplayWingSize();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}