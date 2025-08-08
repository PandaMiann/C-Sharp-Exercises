namespace Exercise01;

class Program
{

    public static void inputInts()
    {
        int number1, number2, result;
        bool isValid = false;

        while (!isValid)
        {
            try
            {
                Console.Write("Input the first number: ");
                number1 = int.Parse(Console.ReadLine());

                Console.Write("Input the second number: ");
                number2 = int.Parse(Console.ReadLine());

                result = number1 / number2;
                Console.WriteLine($"Result: {result}");
                isValid = true;

            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by zero.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }

        

    }

    static void Main(string[] args)
    {
        Console.Clear();
        inputInts();
    }
}
