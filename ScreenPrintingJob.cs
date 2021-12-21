using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingFrog
{
    public static class ScreenPrintingJob
    {
        public static void PrintOnScreen(List<int> initialState, List<int> goalStateInList, List<List<int>> ListOfNodes)
        {
            Console.WriteLine();
            Console.WriteLine("\t Frog Jumping Problem");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("=======================================");
            Console.WriteLine("Start State : {0}", string.Join(',', initialState));
            Console.WriteLine("Goal State : {0}", string.Join(',', goalStateInList));
            Console.WriteLine("=======================================");

            Console.WriteLine();
            Console.WriteLine("Best Path Goes to Goal State From Inital State");
            Console.WriteLine("Total Node From Root to Goal Node : {0}", ListOfNodes.Count - 1);
            int i = 0;
            ListOfNodes.ForEach(eachNode =>
            {
                Console.WriteLine("");
                Console.WriteLine("Step {0} : {1}", ++i, string.Join(',', eachNode));
            });
            if (ListOfNodes.Count <= 0)
            {
                Console.WriteLine("No. Path Goes to Goal State");
            }
        }
    }
}
