string[] dayArr = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

int dayIndex = int.Parse(Console.ReadLine());

if (dayIndex > 0 && dayIndex <= 7)
{
    Console.WriteLine(dayArr[dayIndex - 1]);
}
else
{
    Console.WriteLine($"Invalid day!");
}

