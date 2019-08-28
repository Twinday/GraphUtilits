using Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AddNodeRadioButton.Checked = true;
            ValueTB.Text = "1";
            checkBox1.Checked = true;
        }
        //Bitmap btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        Graphics g;
        MyGraph Graph = new MyGraph();

        /*private void Mouse_Click(object sender, MouseEventArgs e)
        {
            if (AddNodeRadioButton.Checked)
                Graph.AddNode(e.X, e.Y, int.Parse(ValueTB.Text));
            else if (MoveNodeRadioButton.Checked)
            {
                //Graph.MoveNode(e.X, e.Y);
            }
            Bitmap btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(btm);
            Graph.DrawGraph(g);
            pictureBox1.Image = btm;
        }*/

        int counter = -1;
        int Val;
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (AddNodeRadioButton.Checked)
                {
                    if (checkBox1.Checked)
                    {
                        counter++;
                        Val = int.Parse(ValueTB.Text) + counter;
                    }
                    else
                    {
                        Val = int.Parse(ValueTB.Text);
                    }
                    Graph.AddNode(e.X, e.Y, Val);
                }
                else if (MoveNodeRadioButton.Checked)
                {
                    Graph.MoveNode(e.X, e.Y);
                }
                else if (AddEdgeRadioButton.Checked)
                {
                    Graph.CreateEdge(e.X, e.Y, int.Parse(ValueTB.Text));
                }
                else if (radioButtonDeleteNode.Checked)
                {
                    Graph.DeleteNode(e.X, e.Y);
                }
                else if (radioButtonDeleteEdge.Checked)
                {
                    Graph.DeleteEdge(e.X, e.Y);
                }
                Bitmap btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                g = Graphics.FromImage(btm);
                Graph.DrawGraph(g);
                pictureBox1.Image = btm;
            }
        }

        private void buttonCheckConnect_Click(object sender, EventArgs e)
        {
            try
            {
                bool connect = Graph.CheckConnectGraph();
                if (connect)
                    MessageBox.Show("Граф связан", "Message");
                else
                    MessageBox.Show("Граф не связан", "Message");
            }
            catch
            {
                MessageBox.Show("Граф не задан", "Error");
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Graph = FileTools.ReadGraphOnFile(openFileDialog1.FileName);
                    Bitmap btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    g = Graphics.FromImage(btm);
                    Graph.DrawGraph(g);
                    pictureBox1.Image = btm;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Error");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileTools.WriteGraphOnFile(saveFileDialog1.FileName, Graph);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка записи файла");
            }
        }

        private void buttonCheckBipartite_Click(object sender, EventArgs e)
        {
            bool ToDol = Graph.СheckBipartite();
            if (ToDol)
            {
                Bitmap btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                g = Graphics.FromImage(btm);
                Graph.DrawGraph(g);
                pictureBox1.Image = btm;
                MessageBox.Show("Граф является двудольным", "Message");
            }
            else
                MessageBox.Show("Граф двудольным не является", "Message");
        }

        private void buttonDelGraph_Click(object sender, EventArgs e)
        {
            Graph.Nodes.RemoveRange(0, Graph.Nodes.Count);
            Graph = new MyGraph();
            Bitmap btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = btm;
        }

        private void buttonInDepth_Click(object sender, EventArgs e)
        {
            Graph.InDepth();
            Bitmap btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(btm);
            Graph.DrawGraph(g);
            pictureBox1.Image = btm;
            listBoxListWay.Items.Clear();
            listBoxListWay.Items.AddRange(Convert(Graph.ListWay));
        }

        public static string[] Convert(List<string> L)
        {
            string[] str = new string[L.Count];
            for (int i = 0; i < L.Count; i++)
            {
                str[i] = L[i];
            }
            return str;
        }

        private void buttonInWidth_Click(object sender, EventArgs e)
        {
            Graph.InWidth();
            Bitmap btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(btm);
            Graph.DrawGraph(g);
            pictureBox1.Image = btm;
            listBoxListWay.Items.Clear();
            listBoxListWay.Items.AddRange(Convert(Graph.ListWay));
        }

        private void buttonAlgotitmPrima_Click(object sender, EventArgs e)
        {
            Graph.AlgoritmPrima();
            Bitmap btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(btm);
            Graph.DrawGraph(g);
            pictureBox1.Image = btm;
        }
    }
}
