namespace MultidimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] array2D = new string[3, 2]
            {
                {"one", "two"},
                {"three", "four" },
                {"five", "six"}
            };

            array2D[1,1] = "chicken";

            Console.WriteLine(array2D[1,1]);
        }
    }
}