namespace idealWeightCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IdealWeight weight_01 = new IdealWeight
            {
                Height = 176,
                Gender = 'w'
            };

            int weight = weight_01.GetIdealWeight();
            Console.WriteLine($"Weight = {weight}");
            int expected = 64;
            //for Manual testing 
            if (weight == expected)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("failed");
            }
        }
    }
}
