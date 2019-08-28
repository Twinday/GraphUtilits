using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics
{
    public class FileTools
    {
        public static MyGraph ReadGraphOnFile(string name)
        {
            MyGraph Graph = new MyGraph();
            string[] fileLines = File.ReadAllLines(name);
            int numNode = int.Parse(fileLines[0]);
            for (int i = 1; i < numNode + 1; i++)
            {
                string[] parts = fileLines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int val = int.Parse(parts[0]);
                int x = int.Parse(parts[1]);
                int y = int.Parse(parts[2]);
                Graph.AddNode(x, y, val);
            }
            for (int j = numNode + 1; j < fileLines.Length; j++)
            {
                string[] part = fileLines[j].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int x1 = int.Parse(part[0]);
                int y1 = int.Parse(part[1]);
                int x2 = int.Parse(part[2]);
                int y2 = int.Parse(part[3]);
                Graph.CreateEdge(x1, y1, 1);
                Graph.CreateEdge(x2, y2, 1);
            }
            return Graph;
        }

        public static void WriteGraphOnFile(string name, MyGraph graph)
        {
            int N = graph.Nodes.Count;
            List<List<string>> AllNode = new List<List<string>>();
            List<string> lines = new List<string>();
            lines.Add(N.ToString());
            foreach (Node n in graph.Nodes)
            {
                lines.Add(n.value.ToString() + " " + n.x.ToString() + " " + n.y.ToString());
            }
            foreach(Node p in graph.Nodes)
            {
                foreach (Edge e in p.Neighbourhood)
                {
                    int x1 = p.x;
                    int y1 = p.y;
                    Node B = e.Neighbour(p);
                    int x2 = B.x;
                    int y2 = B.y;
                    lines.Add(x1.ToString() + " " + y1.ToString() + " " + x2.ToString() + " " + y2.ToString());
                }
            }
            File.WriteAllLines(name, lines);
        }

    }
}
