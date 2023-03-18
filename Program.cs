namespace data_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers to {min} and {max}");

            double max1 = double.MaxValue;
            double min1 = double.MinValue;
            Console.WriteLine($"The range of double to {min1} to {max1}");

            decimal max2 = decimal.MaxValue;
            decimal min2 = decimal.MinValue;
            Console.WriteLine($"The range of decimal to {min2} to {max2}");

            byte max3 = byte.MaxValue;
            byte min3 = byte.MinValue;
            Console.WriteLine($"The range of byte to {min3} to {max3}");

            short max4 = short.MaxValue;
            short min4 = short.MinValue;
            Console.WriteLine($"The range of short to {min4} to {max4}");

            long max5 = long.MaxValue;
            long min5 = long.MinValue;
            Console.WriteLine($"The range of long to {min5} to {max5}");

            float max6 = float.MaxValue;
            float min6 = float.MinValue;
            Console.WriteLine($"The range of float to {min6} to {max6}");

            char max7 = char.MaxValue;
            char min7 = char.MinValue;
            Console.WriteLine($"The range of char to {min7} to {max7}");
        }
    }
}