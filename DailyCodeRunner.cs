using System;
using System.Collections.Generic;
using System.Linq;

using DailyCode;
using DailyCode.BinaryTree;

namespace DailyCode
{
    public static class Runner
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Array.ContainsPairAddingToTarget(new List<int>{10, 15, 3, 7}, 17));

            Array.ProductArrayExcludingI(new List<int>{1,2,3,4,5}).ForEach(i => Console.Write($"{i} "));
            // Console.WriteLine();

            Node node = Node.Deserialize("A B C D # # #");
            Console.WriteLine(node);
        }
    }
}
