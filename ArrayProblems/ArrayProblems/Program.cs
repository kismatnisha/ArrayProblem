namespace ArrayProblems
{
    internal class Program
    {
        public static void toPrint(int[] inputArray)
        {
            foreach(int element in inputArray)
            {
                Console.WriteLine(element); 
            }
        }
        public static void toPrint(double[] inputArray)
        {
            foreach (double element in inputArray)
            {
                Console.WriteLine(element);
            }
        }
        public static void toPrint(char[] inputArray)
        {
            foreach (char element in inputArray)
            {
                Console.WriteLine(element);
            }
        }

        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArray = { 'W', 'E', 'Q', 'T', 'R' };
            toPrint(intArray);
            toPrint(doubleArray);
            toPrint(charArray);
        }
    }
}