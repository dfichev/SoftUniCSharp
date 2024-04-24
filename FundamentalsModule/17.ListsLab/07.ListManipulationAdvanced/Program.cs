namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            string input = "";

            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split();

                switch (arguments[0])
                {
                    case "Contains":
                        int digit = int.Parse(arguments[1]);
                        bool isContain = numbers.Contains(digit);
                        if (isContain)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        foreach (int item in numbers)
                        {
                            if (item % 2 == 0)
                            {
                                Console.Write($"{item} ");
                            }
                        }
                        break;
                    case "PrintOdd":
                        foreach (int item in numbers)
                        {
                            if (item % 2 != 0)
                            {
                                Console.Write($"{item} ");
                            }
                        }
                        break;
                    case "GetSum":
                        int sum = 0;
                        foreach (int item in numbers)
                        {
                            sum += item;
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = (arguments[1]);
                        int currentDigit = int.Parse(arguments[2]);
                        if (condition == "<")
                        {
                            foreach (int item in numbers.Where(item => item < currentDigit))
                            {
                                Console.Write($"{item} ");
                            }
                        }
                        else if (condition == ">")
                        {
                            foreach (int item in numbers.Where(item => item > currentDigit))
                            {
                                Console.Write($"{item} ");
                            }
                        }
                        else if (condition == ">=")
                        {
                            foreach (int item in numbers.Where(item => item >= currentDigit))
                            {
                                Console.Write($"{item} ");
                            }
                        }
                        else if (condition == "<=")
                        {
                            foreach (int item in numbers.Where(item => item <= currentDigit))
                            {
                                Console.Write($"{item} ");
                            }
                        }
                        break;
                }
            }
        }
    }
}
/*
5 34 678 67 5 563 98
Contains 23
PrintOdd
GetSum
Filter >= 21
end

 */