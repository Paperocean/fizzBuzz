class Program
{
    static void Main()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        fizzBuzz.Run(10);

        WelcomeMessage message = new WelcomeMessage();
        message.Hello();
    }
}

class WelcomeMessage
{
    public void Hello()
    {
        Console.WriteLine("Hello World");
    }
}

class FizzBuzz
{
    public void Run(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}