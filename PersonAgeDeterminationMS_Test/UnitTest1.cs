using PersonAgeDetermination;

namespace PersonAgeDeterminationMS_Test
{
    [TestClass]
    public class UnitTest1
    {
        AgeCategoryDeterminer AC = new AgeCategoryDeterminer();

        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                int age = 10;
                string ageCategory = AC.DetermineAgeCategory(age);
                Console.WriteLine($"Age: {age}, Category: {ageCategory}");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            try
            {
                int age = 20;
                string ageCategory = AC.DetermineAgeCategory(age);
                Console.WriteLine($"Age: {age}, Category: {ageCategory}");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [TestMethod]
        public void TestMethod3()
        {
            try
            {
                int age = 40;
                string ageCategory = AC.DetermineAgeCategory(age);
                Console.WriteLine($"Age: {age}, Category: {ageCategory}");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            try
            {
                int age = 70;
                string ageCategory = AC.DetermineAgeCategory(age);
                Console.WriteLine($"Age: {age}, Category: {ageCategory}");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [TestMethod]
        public void TestMethod5() 
        {
            try
            {
                int age = -5;
                string ageCategory = AC.DetermineAgeCategory(age);
                Console.WriteLine($"Age: {age}, Category: {ageCategory}");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}