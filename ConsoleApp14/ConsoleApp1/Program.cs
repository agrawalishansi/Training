namespace ConsoleApp1;
class Program
{

    public static void Main(string[] args)
    {




        HashSet<int> numbers = new HashSet<int>();

        for (int i = 0; i < 20; i++)
        {
            numbers.Add(i);
        }

        // Display all the numbers in the hash table.
        Console.Write("numbers contains {0} elements: ", numbers.Count);
        DisplaySet(numbers);

        // Remove all odd numbers.
        numbers.RemoveWhere(IsOdd);
        Console.Write("numbers contains {0} elements: ", numbers.Count);
        DisplaySet(numbers);

        // Check if the hash table contains 0 and, if so, remove it.
        if (numbers.Contains(0))
        {
            numbers.Remove(0);
        }
        Console.Write("numbers contains {0} elements: ", numbers.Count);
        DisplaySet(numbers);

        bool IsOdd(int i)
        {
            return ((i % 2) == 1);
        }

        void DisplaySet(HashSet<int> set)
        {
            Console.Write("{");
            foreach (int i in set)
                Console.Write(" {0}", i);

            Console.WriteLine(" }");
        }


    }
}
