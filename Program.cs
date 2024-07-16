namespace HW_AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalWorld africa = new AnimalWorld(new Africa());
            AnimalWorld northAmerica = new AnimalWorld(new NorthAmerica());

            Console.WriteLine("Africa:");
            africa.MealsHerbivores();
            africa.NutritionCarnivores();

            Console.WriteLine("NorthAmerica:");
            northAmerica.MealsHerbivores();
            northAmerica.NutritionCarnivores();
        }
    }
}
