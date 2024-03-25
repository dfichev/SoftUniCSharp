using System;

namespace _1._Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int volumePool = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double pipe1vol = pipe1 * hours;
            double pipe2vol = pipe2 * hours;
           
            double volFilled = pipe1vol + pipe2vol;

            if (volFilled > volumePool)
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {(pipe1vol + pipe2vol) - volumePool} liters.");
            }
            else
            {
                Console.WriteLine($"The pool is {(volFilled / volumePool) * 100}% full. Pipe 1: {(pipe1vol / volFilled) * 100:F2}%. Pipe 2: {(pipe2vol / volFilled) * 100:F2}%.");
            }

        }
    }
}
