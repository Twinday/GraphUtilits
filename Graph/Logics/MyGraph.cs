using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics
{
    public class Node
    {
        public int value;
        public List<Edge> Neighbourhood = new List<Edge>(); // список ребер
        public int x;
        public int y;
        public bool isDrawn = false;
        public bool visit = false;
        public int color = -1;
        public Node(int v)
        {
            this.value = v;
        }
    }

    public class Edge
    {
        public int value;
        public Node A;
        public Node B;
        public bool isDrawn = false;
        public bool visit = false;
        public Edge(Node p1, Node p2)
        {
            this.A = p1;
            this.B = p2;
        }

        public Node Neighbour(Node x) //сосед по ребру
        {
            if (x == A)
                return B;
            else if (x == B)
                return A;
            else
                return null;
        }
    }

    public class MyGraph
    {
        public List<Node> Nodes = new List<Node>();

        public void AddNode(int x, int y, int val)
        {
            Node p = new Node(val);
            p.x = x;
            p.y = y;
            p.value = val;
            Nodes.Add(p);
        }

        public void AddEdge(Node A, Node B, int value)
        {
            Edge e = new Edge(A, B);
            e.value = value;
            A.Neighbourhood.Add(e);
            B.Neighbourhood.Add(e);
        }

        public void DeleteNode(int x, int y) //удаление узла
        {
            int i = 0;
            Node p = FindByXY(x, y);
            foreach (Node n in Nodes)
            {
                if (p == n)
                    break;
                i++;
            }
            foreach(Edge a in Nodes[i].Neighbourhood)
            {
                List<int> Indexes = new List<int>();
                int j = 0;
                foreach (Edge q in a.Neighbour(p).Neighbourhood)
                {
                    if (q.Neighbour(a.Neighbour(p)) == p)
                        Indexes.Add(j);
                    else
                        j++;
                }
                for (int t = 0; t < Indexes.Count; t++)
                {
                    a.Neighbour(p).Neighbourhood.RemoveAt(Indexes[t]);
                }
            }
            Nodes[i].Neighbourhood = null;
            Nodes.RemoveAt(i);
        }

        private Node NodeForDeleteEdge = null;
        public void DeleteEdge(int x, int y) // удаление ребра
        {
            if (NodeForDeleteEdge == null)
            {
                NodeForDeleteEdge = FindByXY(x, y);
                NodeForDeleteEdge.color = 1;
                return;
            }
            else
            {
                Node SecondNode = FindByXY(x, y);
                int i = 0;
                int j = 0;
                foreach (Edge e in NodeForDeleteEdge.Neighbourhood)
                {
                    if (e.Neighbour(NodeForDeleteEdge) == SecondNode)
                        break;
                    else
                        i++;
                }
                foreach (Edge b in SecondNode.Neighbourhood)
                {
                    if (b.Neighbour(SecondNode) == NodeForDeleteEdge)
                        break;
                    else
                        j++;
                }
                NodeForDeleteEdge.Neighbourhood.RemoveAt(i);
                SecondNode.Neighbourhood.RemoveAt(j);
                NodeForDeleteEdge.color = -1;
                NodeForDeleteEdge = null;
            }
        }

        private Node FindByXY(int x, int y) //поиск узла по координатам
        {
            int R = 15; // радиус узла
            foreach (Node p in Nodes)
            {
                if ((p.x - x) * (p.x - x) + (p.y - y) * (p.y - y) < R * R)
                    return p;
            }
            return null;
        }

        private Node NodeForMove = null;
        public void MoveNode(int x, int y) // перемещение узла
        {
            if (NodeForMove == null)
            {
                NodeForMove = FindByXY(x, y);
                NodeForMove.color = 1;
                return;
            }
            else
            {
                NodeForMove.x = x;
                NodeForMove.y = y;
                NodeForMove.color = -1;
                NodeForMove = null;
            }
        }

        private Node NodeForEdge = null;
        public void CreateEdge(int x, int y, int value) // создание ребра между узлами
        {
            if (NodeForEdge == null)
            {
                NodeForEdge = FindByXY(x, y);
                NodeForEdge.color = 1;
                return;
            }
            else
            {
                Node SecondNode = FindByXY(x, y);
                AddEdge(NodeForEdge, SecondNode, value);
                NodeForEdge.color = -1;
                NodeForEdge = null;
            }
        }

        /*private void qwe(Node p)//обход графа в глубину
        {
            if (p.visit)
                return;
            else
            {
                p.visit = true;
                foreach (Node n in p.NeighBoars)
                {
                    qwe(n);
                }
            }
        }

        private void asd()//через стэк обход в глубину
        {
            Node p = ...;
            Stack<Node> s = new Stack<Node>();
            s.Push(p);
            while (!s.isEmpty)
            {
                p = s.Pop();
                ///
                foreach (var n in p.NeighBoars)
                {
                    if (!p.visit)
                    {
                        s.Push(n);
                    }
                }
            }
        }
        //через очередь обход в ширину*/

        public bool CheckConnectGraph() //проверка графа на связанность
        {
            foreach (Node a in Nodes)
            {
                a.color = -1;
                a.visit = false;
            }
            TraversalInDepth(Nodes[0]);
            foreach (Node n in Nodes)
            {
                if (!n.visit)
                {
                    return false;
                }
            }
            return true;
        }

        private void TraversalInDepth(Node p) //обход графа в глубину
        {
            if (p.visit)
                return;
            else
            {
                p.visit = true;
                foreach (Edge e in p.Neighbourhood)
                {
                    TraversalInDepth(e.Neighbour(p));
                }
            }
        }

        public List<string> ListWay = new List<string>(); // лист с последовательностью значений узлов при обходе

        public void InDepth() // обход графа в глубину с раскрашиванием в 1 цвет и записью путей в ListWay
        {
            foreach (Node n in Nodes)
            {
                n.color = -1;
                n.visit = false;
            }
            ListWay.Clear();
            TraversalInDepthPart2(Nodes[0]);
        }
        private void TraversalInDepthPart2(Node p) // обход графа в глубину с раскрашиванием в 1 цвет и записью путей в ListWay
        {
            if (p.visit)
                return;
            else
            {
                p.visit = true;
                p.color = 0;
                ListWay.Add(p.value.ToString());
                foreach (Edge e in p.Neighbourhood)
                {
                    TraversalInDepthPart2(e.Neighbour(p));
                }
            }
        }

        public void InWidth() // обход графа в ширину с раскрашиванием в 1 цвет и записью путей в ListWay
        {
            foreach (Node n in Nodes)
            {
                n.color = -1;
                n.visit = false;
            }
            ListWay.Clear();
            TraversalInWidth(Nodes[0]);
        }
        private Queue<Node> qn = new Queue<Node>();
        private void TraversalInWidth(Node p) // обход графа в ширину с раскрашиванием в 1 цвет и записью путей в ListWay
        {
            if (p.visit)
                return;
            else
            {
                p.visit = true;
                p.color = 1;
                ListWay.Add(p.value.ToString());
                foreach (Edge e in p.Neighbourhood)
                {
                    if (!e.Neighbour(p).visit)
                        qn.Enqueue(e.Neighbour(p));
                }
                if (qn.Count != 0)
                    TraversalInWidth(qn.Dequeue());
            }
        }


        public void AlgoritmPrima() // алгоритм Дейкстры-Прима или просто Прима (поиск минимального остовного дерева)
        {
            foreach (Node n in Nodes)
            {
                n.visit = false;
                n.color = -1;
                foreach (Edge edge in n.Neighbourhood)
                {
                    edge.visit = false;
                }
            }
            List<Node> Choose = new List<Node>();
            Choose.Add(Nodes[0]);
            AlgPrima(Choose);
        }
        private void AlgPrima(List<Node> Choose) // алгоритм Дейкстры-Прима или просто Прима (поиск минимального остовного дерева)
        {
            //помечаем узлы посещёнными
            foreach (Node n in Choose)
            {
                if (!n.visit)
                {
                    n.visit = true;
                    n.color = 1;
                }
            }

            //если прошли по всем узлам, то завершаем метод
            if (Choose.Count == Nodes.Count)
            {
                for (int i = 0; i < Choose.Count; i++)
                {
                    Nodes[i] = Choose[i];
                }
                return;
            }

            //смотрим все доступные ребра
            List<Edge> el = new List<Edge>();
            foreach (Node n in Choose)
            {
                foreach (Edge ed in n.Neighbourhood)
                {
                    if (n.visit && ed.Neighbour(n).visit)
                    {

                    }
                    else
                    {
                        if (!ed.visit)
                            el.Add(ed);
                    }
                }
            }
            //находим минимальное ребро и добавляем непосещённый узел в список
            Edge minEdge = MinValueEdge(el);
            bool flag = false;
            foreach (Node n in Choose)
            {
                foreach (Edge ed in n.Neighbourhood)
                {
                    if (ed == minEdge)
                    {
                        ed.visit = true;
                        if (!ed.A.visit)
                        {
                            Choose.Add(ed.A);
                            flag = true;
                            break;
                        }
                        else if (!ed.B.visit)
                        {
                            Choose.Add(ed.B);
                            flag = true;
                            break;
                        }
                    }
                }
                if (flag)
                    break;
            }
            //запускаем рекурсию
            AlgPrima(Choose);
        }
        private Edge MinValueEdge(List<Edge> l) // поиск минимального веса ребра
        {
            Stack<Edge> stack = new Stack<Edge>();
            stack.Push(l[0]);
            for (int i = 1; i < l.Count; i++)
            {
                Edge e1 = null;
                if (stack != null)
                    e1 = stack.Pop();
                if (l[i].value < e1.value)
                    stack.Push(l[i]);
                else
                    stack.Push(e1);
            }
            return stack.Pop();
        }

        public bool СheckBipartite() // проверка на двудольность
        {
            foreach (Node n in Nodes)
            {
                n.color = -1;
                n.visit = false;
            }
            return Bipartite(Nodes[0]);
        }

        private bool Bipartite(Node p) // обход в глубину и раскрашивание графа в 2 цвета
        {
            if (p.visit)
                return true;
            else
            {
                p.visit = true;
                int color0 = 0;
                int color1 = 0;
                foreach(Edge a in p.Neighbourhood)
                {
                    if (a.Neighbour(p).color == 0)
                        color0++;
                    else if (a.Neighbour(p).color == 1)
                        color1++;
                }
                if (color0 == 0 && color1 == 0)
                    p.color = 1;
                else if (color0 == 0 && color1 > 0)
                    p.color = 0;
                else if (color1 == 0 && color0 > 0)
                    p.color = 1;
                if (color0 > 0 && color1 > 0)
                    return false;
                else
                {
                    bool B = true;
                    foreach (Edge e in p.Neighbourhood)
                    {
                        B = Bipartite(e.Neighbour(p));
                        if (!B)
                            return false;
                    }
                    return B;
                }
            }
        }

        public void DrawGraph(Graphics g)
        {
            foreach (Node x in Nodes)
            {
                foreach (Edge e in x.Neighbourhood)
                {
                    e.isDrawn = false;
                    //e.visit = false;
                }
                x.isDrawn = false;
            }
            foreach (Node x in Nodes)
            {
                Draw(g, x);
            }
        }

        private void Draw(Graphics g, Node p)
        {
            /*foreach (Node n in p.Neighbourhood)//соседи
            {
                if (!n.isDrawn)//рисуем тольке для тех. где не нарисовано ребро
                    DrawEdge(g, p, n);
            }
            DrawNode(g, p);
            p.isDrawn = true;*/
            /*foreach (Edge e in Edges)
            {
                if (!e.isDrawn)
                    DrawEdge(g, e);
            }
            foreach (Node n in Nodes)
            {
                if (!n.isDrawn)
                    DrawNode(g, n);
            }*/
            foreach (Node n in Nodes)
            {
                if (n.Neighbourhood != null)
                {
                    foreach (Edge e in n.Neighbourhood)
                    {
                        if (!e.isDrawn)
                            DrawEdge(g, e);
                        e.isDrawn = true;
                    }
                }
                if (!n.isDrawn)
                    DrawNode(g, n);
                n.isDrawn = true;
            }
        }

        private void DrawEdge(Graphics g, Edge e)
        {
            if (!e.visit)
                g.DrawLine(Pens.Black, e.A.x, e.A.y, e.B.x, e.B.y);
            else
                g.DrawLine(Pens.Red, e.A.x, e.A.y, e.B.x, e.B.y);
            float x = (e.A.x + e.B.x) / 2;
            float y = (e.A.y + e.B.y) / 2;
            Font myFont = new Font("Arial", 20, FontStyle.Bold | FontStyle.Italic);
            g.DrawString(e.value.ToString(), myFont, Brushes.Red, x - 10, y - 10);
        }

        private void DrawEdge(Graphics g, Node p, Node n)
        {

        }

        private void DrawNode(Graphics g, Node p)
        {
            if (p.color == -1)
                g.FillEllipse(Brushes.LightPink, p.x - 15, p.y - 15, 30, 30);
            else if (p.color == 0)
                g.FillEllipse(Brushes.Green, p.x - 15, p.y - 15, 30, 30);
            else if (p.color == 1)
                g.FillEllipse(Brushes.Gray, p.x - 15, p.y - 15, 30, 30);
            g.DrawEllipse(Pens.Black, p.x - 15, p.y - 15, 30, 30);
            Font myFont = new Font("Arial", 12, FontStyle.Bold | FontStyle.Italic);
            g.DrawString(p.value.ToString(), myFont, Brushes.Blue, p.x - 10, p.y - 10);
        }

    }

}
