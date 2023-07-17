namespace PersonAgeDetermination
{
    public class Program
    {
        static void Main(string[] args)
        {
            AgeCategoryDeterminer ACD = new AgeCategoryDeterminer();


            try
            {
                int age = 10;
                string ageCategory = ACD.DetermineAgeCategory(age);
                Console.WriteLine($"Age: {age}, Category: {ageCategory}");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                int age = 20;
                string ageCategory = ACD.DetermineAgeCategory(age);
                Console.WriteLine($"Age: {age}, Category: {ageCategory}");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                int age = 40;
                string ageCategory = ACD.DetermineAgeCategory(age);
                Console.WriteLine($"Age: {age}, Category: {ageCategory}");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                int age = 70;
                string ageCategory = ACD.DetermineAgeCategory(age);
                Console.WriteLine($"Age: {age}, Category: {ageCategory}");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                int age = -5; 
                string ageCategory = ACD.DetermineAgeCategory(age);
                Console.WriteLine($"Age: {age}, Category: {ageCategory}");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}