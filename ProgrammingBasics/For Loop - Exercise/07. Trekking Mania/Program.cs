using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int totalParticipants = 0;
            int musala = 0;
            int montblanc = 0;
            int kilimanjaro = 0;
            int k2 = 0;
            int everest = 0;

            for (int i = 1; i <= groups; i++)
            {
                int members = int.Parse(Console.ReadLine());

                totalParticipants += members;

                if (members >= 41)
                {
                    everest += members;
                }
                else if (members <= 40 && members >= 26)
                {
                    k2 += members;
                }
                else if (members <= 25 && members >= 13)
                {
                    kilimanjaro += members;
                }
                else if (members < 13 && members > 5)
                {
                    montblanc += members;
                }
                else if (members < 6)
                {
                    musala += members;
                }
            }
            Console.WriteLine($"{(double)musala / totalParticipants * 100:F2}%");
            Console.WriteLine($"{(double)montblanc / totalParticipants * 100:F2}%");
            Console.WriteLine($"{(double)kilimanjaro / totalParticipants * 100:F2}%");
            Console.WriteLine($"{(double)k2 / totalParticipants * 100:F2}%");
            Console.WriteLine($"{(double)everest / totalParticipants * 100:F2}%");
        }
    }
}
