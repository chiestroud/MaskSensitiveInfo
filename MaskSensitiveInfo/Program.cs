using System;

namespace MaskSensitiveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any value");
            var sensitiveInfo = (Console.ReadLine());

            Console.Write("Your secret is ");
            for (var i = 0; i < (sensitiveInfo.Length - 4); i++)
            {
                Console.Write("*");
            }
            for (var i = (sensitiveInfo.Length - 4); i < sensitiveInfo.Length; i++)
            {
                Console.Write(sensitiveInfo[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Please guess your secret");
            var secret = Console.ReadLine();

            if (secret == sensitiveInfo)
            {
                Console.WriteLine($"Congratulations. Your secret is {secret}");
            }else
            {
                Console.WriteLine("Please try again.");
            }
        }
    }
}
