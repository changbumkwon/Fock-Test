using Calcuator2;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("수식을 입력하세요(종료를 원하시면 n 을 입력하세요)");

            var input = Console.ReadLine();
            var clculate = new Clculate();

            while (true)
            {
                Console.WriteLine("{0} = {1}", input, clculate.AdditionSubtraction(input.ToCharArray(), 0));
                input = Console.ReadLine();
                if (input == "n")
                    break;
                Console.WriteLine();
            }
        }
    }
}

