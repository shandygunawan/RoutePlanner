using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
namespace RoutePlanner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }
    }
    
    public class AStar
    {
        public Tuple<double, int, List<int>> FinalPath;

        public AStar(double[,] Graph, List<double> Heur, int Start, int Goal)
        {
            //Queue by Cost
            List<Tuple<double, int, List<int>>> QueNode = new List<Tuple<double, int, List<int>>>();

            //Set Defaut Path with Start Node
            List<int> Path = new List<int>();
            Path.Add(Start);
            var tuppleAdd = new Tuple<double, int, List<int>>(Heur[Start], Start, Path);
            //Set tupleAdd as FinalPath in case Start=Goal 
            FinalPath = tuppleAdd;
            QueNode.Add(tuppleAdd);

            //Set Current to Start
            var Current = QueNode[0];
            var CurrentNode = Start;

            // Keep procesing Node as long as CurrentNode not Goal and Queue not Empty
            while ((Current.Item2 != Goal) && (QueNode.Count != 0))
            {
                //Set Current to First Item In queue
                Current = QueNode[0];
                //Pop First Item
                QueNode.RemoveAt(0);
                //Set CurrentNode and CurrentDist from  Current
                CurrentNode = Current.Item2;
                var CurrentDist = Current.Item1;

                // Substrac Current Distance wih heuristic since Current distance is total distance from start plus Heuristic
                CurrentDist -= Heur[CurrentNode-1];
                //Check if Current Node is Goal or not
                if (CurrentNode != Goal)
                {
                    //If not goal, check every neighbour node from current node
                    for (int i = 1; i < Graph.GetLength(1); i++)
                    {
                        //check whether there is a path from current node to this node, if there is no path, dont add it to queue
                        if (Graph[i, CurrentNode] != MainForm.INF)
                        {
                            //Record path from start node to current node 
                            var CurrentPath = new List<int>(Current.Item3);
                            CurrentPath.Add(i);

                            //Cost of this node, the distance from start node to this node + distance from this node to goal
                            var newDist = CurrentDist + Graph[i, CurrentNode] + Heur[i-1];

                            // add this node to queue
                            var temp = new Tuple<double, int, List<int>>(newDist, i, CurrentPath);
                            QueNode.Add(temp);

                        }
                    }
                }
                //if current node is goal, then set Current as Finalpath and break the loop
                else
                {
                    FinalPath = Current;
                    break;
                }
                //Sort List after adding new node
                QueNode.Sort((x, y) => x.Item1.CompareTo(y.Item1));

            }

        }
    }
}


