namespace Exercise01;

class Program
{
    public static void LoadNumbers(int[] array)
    {
        for (int i = 1; i < 11; i++)
        {
            Console.Write($"Enter number {i}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public static void FindMax(int[] array)
    {
        int maxValue = int.MinValue;
        foreach (int number in array)
        {
            if (number > maxValue)
            {
                maxValue = number;
            }
        }
        Console.WriteLine($"The largest number is: {maxValue}");
    
    }
    static void Main(string[] args)
    {
        int[] array = new int[11];
        LoadNumbers(array);
        FindMax(array);


    }
}
