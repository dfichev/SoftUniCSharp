string[] firstArray = Console.ReadLine()
    .Split()
    .ToArray();
string[] secondArray = Console.ReadLine()
    .Split()
    .ToArray();

for (int i = 0; i < firstArray.Length; i++)
{
    for (int j = 0; j < secondArray.Length; j++)
    {
        if (firstArray[i] == secondArray[j])
        {
            Console.Write($"{firstArray[i]} ");
        }

    }
}