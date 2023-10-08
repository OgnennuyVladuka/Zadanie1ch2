namespace z1l
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int g = 0;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    g = i * j;
                    s = String.Format("{0,-10}", i + " * " + j + " = " + g);
                    Console.Write("  " + s);
                }
                Console.WriteLine();
            }
        }
    }
}