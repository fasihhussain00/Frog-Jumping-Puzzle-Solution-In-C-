
using JumpingFrog;
using JumpingFrog.Model;
using Newtonsoft.Json;

int[] InitialState = {1, 1, 1, 0, 2, 2, 2};
int[] GoalState = {2, 2, 2, 0, 1, 1, 1};

var InitialStateInList = InitialState.ToList();
var GoalStateInList = GoalState.ToList();

var tree = new TreeModel(null);

var TreeHandler = new MakeATreeOfStates();
TreeHandler.CreateANode(ref tree, InitialStateInList);

Console.WriteLine("=============Start Tree================");
Console.WriteLine("{0}", JsonConvert.SerializeObject(tree, Formatting.Indented));

Console.WriteLine("=============End Tree================");
Console.WriteLine();

var ListOfNodeAfterTraversal = new BFS(GoalStateInList).Traverse(tree);

Console.WriteLine("Total No. Of States {0}", TreeHandler.TotalNoOfStates);

ScreenPrintingJob.PrintOnScreen(InitialStateInList, GoalStateInList, ListOfNodeAfterTraversal);

Console.ReadLine();
