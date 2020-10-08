namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i < 39; i++)
            {
                System.Console.WriteLine(FizzBuzz(i));
                System.Threading.Thread.Sleep(50);
            }
        }
        static string FizzBuzz(int num)
        {
            return num % 3 == 0
                ? (num % 5 == 0 ? "FizzBuzz" : "Fizz")
                : num % 5 == 0 ? "Buzz" : num.ToString();
        }
    }
}
