namespace MainForm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddNodeRadioButton = new System.Windows.Forms.RadioButton();
            this.MoveNodeRadioButton = new System.Windows.Forms.RadioButton();
            this.ValueTB = new System.Windows.Forms.NumericUpDown();
            this.AddEdgeRadioButton = new System.Windows.Forms.RadioButton();
            this.buttonCheckConnect = new System.Windows.Forms.Button();
            this.radioButtonDeleteNode = new System.Windows.Forms.RadioButton();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonCheckBipartite = new System.Windows.Forms.Button();
            this.buttonDelGraph = new System.Windows.Forms.Button();
            this.radioButtonDeleteEdge = new System.Windows.Forms.RadioButton();
            this.buttonInDepth = new System.Windows.Forms.Button();
            this.listBoxListWay = new System.Windows.Forms.ListBox();
            this.buttonInWidth = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonAlgotitmPrima = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueTB)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(733, 594);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // AddNodeRadioButton
            // 
            this.AddNodeRadioButton.AutoSize = true;
            this.AddNodeRadioButton.Location = new System.Drawing.Point(784, 41);
            this.AddNodeRadioButton.Name = "AddNodeRadioButton";
            this.AddNodeRadioButton.Size = new System.Drawing.Size(70, 17);
            this.AddNodeRadioButton.TabIndex = 1;
            this.AddNodeRadioButton.TabStop = true;
            this.AddNodeRadioButton.Text = "AddNode";
            this.AddNodeRadioButton.UseVisualStyleBackColor = true;
            // 
            // MoveNodeRadioButton
            // 
            this.MoveNodeRadioButton.AutoSize = true;
            this.MoveNodeRadioButton.Location = new System.Drawing.Point(784, 64);
            this.MoveNodeRadioButton.Name = "MoveNodeRadioButton";
            this.MoveNodeRadioButton.Size = new System.Drawing.Size(78, 17);
            this.MoveNodeRadioButton.TabIndex = 2;
            this.MoveNodeRadioButton.TabStop = true;
            this.MoveNodeRadioButton.Text = "MoveNode";
            this.MoveNodeRadioButton.UseVisualStyleBackColor = true;
            // 
            // ValueTB
            // 
            this.ValueTB.Location = new System.Drawing.Point(784, 234);
            this.ValueTB.Name = "ValueTB";
            this.ValueTB.Size = new System.Drawing.Size(89, 20);
            this.ValueTB.TabIndex = 3;
            // 
            // AddEdgeRadioButton
            // 
            this.AddEdgeRadioButton.AutoSize = true;
            this.AddEdgeRadioButton.Location = new System.Drawing.Point(784, 88);
            this.AddEdgeRadioButton.Name = "AddEdgeRadioButton";
            this.AddEdgeRadioButton.Size = new System.Drawing.Size(69, 17);
            this.AddEdgeRadioButton.TabIndex = 4;
            this.AddEdgeRadioButton.TabStop = true;
            this.AddEdgeRadioButton.Text = "AddEdge";
            this.AddEdgeRadioButton.UseVisualStyleBackColor = true;
            // 
            // buttonCheckConnect
            // 
            this.buttonCheckConnect.Location = new System.Drawing.Point(784, 297);
            this.buttonCheckConnect.Name = "buttonCheckConnect";
            this.buttonCheckConnect.Size = new System.Drawing.Size(89, 23);
            this.buttonCheckConnect.TabIndex = 5;
            this.buttonCheckConnect.Text = "CheckConnect";
            this.buttonCheckConnect.UseVisualStyleBackColor = true;
            this.buttonCheckConnect.Click += new System.EventHandler(this.buttonCheckConnect_Click);
            // 
            // radioButtonDeleteNode
            // 
            this.radioButtonDeleteNode.AutoSize = true;
            this.radioButtonDeleteNode.Location = new System.Drawing.Point(784, 112);
            this.radioButtonDeleteNode.Name = "radioButtonDeleteNode";
            this.radioButtonDeleteNode.Size = new System.Drawing.Size(82, 17);
            this.radioButtonDeleteNode.TabIndex = 6;
            this.radioButtonDeleteNode.TabStop = true;
            this.radioButtonDeleteNode.Text = "DeleteNode";
            this.radioButtonDeleteNode.UseVisualStyleBackColor = true;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(784, 518);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 7;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(784, 547);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCheckBipartite
            // 
            this.buttonCheckBipartite.Location = new System.Drawing.Point(784, 326);
            this.buttonCheckBipartite.Name = "buttonCheckBipartite";
            this.buttonCheckBipartite.Size = new System.Drawing.Size(89, 23);
            this.buttonCheckBipartite.TabIndex = 9;
            this.buttonCheckBipartite.Text = "CheckBipartite";
            this.buttonCheckBipartite.UseVisualStyleBackColor = true;
            this.buttonCheckBipartite.Click += new System.EventHandler(this.buttonCheckBipartite_Click);
            // 
            // buttonDelGraph
            // 
            this.buttonDelGraph.Location = new System.Drawing.Point(784, 176);
            this.buttonDelGraph.Name = "buttonDelGraph";
            this.buttonDelGraph.Size = new System.Drawing.Size(75, 23);
            this.buttonDelGraph.TabIndex = 10;
            this.buttonDelGraph.Text = "DelGraph";
            this.buttonDelGraph.UseVisualStyleBackColor = true;
            this.buttonDelGraph.Click += new System.EventHandler(this.buttonDelGraph_Click);
            // 
            // radioButtonDeleteEdge
            // 
            this.radioButtonDeleteEdge.AutoSize = true;
            this.radioButtonDeleteEdge.Location = new System.Drawing.Point(784, 136);
            this.radioButtonDeleteEdge.Name = "radioButtonDeleteEdge";
            this.radioButtonDeleteEdge.Size = new System.Drawing.Size(81, 17);
            this.radioButtonDeleteEdge.TabIndex = 11;
            this.radioButtonDeleteEdge.TabStop = true;
            this.radioButtonDeleteEdge.Text = "DeleteEdge";
            this.radioButtonDeleteEdge.UseVisualStyleBackColor = true;
            // 
            // buttonInDepth
            // 
            this.buttonInDepth.Location = new System.Drawing.Point(784, 355);
            this.buttonInDepth.Name = "buttonInDepth";
            this.buttonInDepth.Size = new System.Drawing.Size(89, 23);
            this.buttonInDepth.TabIndex = 12;
            this.buttonInDepth.Text = "InDepth";
            this.buttonInDepth.UseVisualStyleBackColor = true;
            this.buttonInDepth.Click += new System.EventHandler(this.buttonInDepth_Click);
            // 
            // listBoxListWay
            // 
            this.listBoxListWay.FormattingEnabled = true;
            this.listBoxListWay.Location = new System.Drawing.Point(925, 41);
            this.listBoxListWay.Name = "listBoxListWay";
            this.listBoxListWay.Size = new System.Drawing.Size(120, 537);
            this.listBoxListWay.TabIndex = 13;
            // 
            // buttonInWidth
            // 
            this.buttonInWidth.Location = new System.Drawing.Point(784, 384);
            this.buttonInWidth.Name = "buttonInWidth";
            this.buttonInWidth.Size = new System.Drawing.Size(89, 23);
            this.buttonInWidth.TabIndex = 14;
            this.buttonInWidth.Text = "InWidth";
            this.buttonInWidth.UseVisualStyleBackColor = true;
            this.buttonInWidth.Click += new System.EventHandler(this.buttonInWidth_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(784, 261);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(38, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "++";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonAlgotitmPrima
            // 
            this.buttonAlgotitmPrima.Location = new System.Drawing.Point(784, 413);
            this.buttonAlgotitmPrima.Name = "buttonAlgotitmPrima";
            this.buttonAlgotitmPrima.Size = new System.Drawing.Size(89, 23);
            this.buttonAlgotitmPrima.TabIndex = 16;
            this.buttonAlgotitmPrima.Text = "Alg Prima";
            this.buttonAlgotitmPrima.UseVisualStyleBackColor = true;
            this.buttonAlgotitmPrima.Click += new System.EventHandler(this.buttonAlgotitmPrima_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 606);
            this.Controls.Add(this.buttonAlgotitmPrima);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonInWidth);
            this.Controls.Add(this.listBoxListWay);
            this.Controls.Add(this.buttonInDepth);
            this.Controls.Add(this.radioButtonDeleteEdge);
            this.Controls.Add(this.buttonDelGraph);
            this.Controls.Add(this.buttonCheckBipartite);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.radioButtonDeleteNode);
            this.Controls.Add(this.buttonCheckConnect);
            this.Controls.Add(this.AddEdgeRadioButton);
            this.Controls.Add(this.ValueTB);
            this.Controls.Add(this.MoveNodeRadioButton);
            this.Controls.Add(this.AddNodeRadioButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton AddNodeRadioButton;
        private System.Windows.Forms.RadioButton MoveNodeRadioButton;
        private System.Windows.Forms.NumericUpDown ValueTB;
        private System.Windows.Forms.RadioButton AddEdgeRadioButton;
        private System.Windows.Forms.Button buttonCheckConnect;
        private System.Windows.Forms.RadioButton radioButtonDeleteNode;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonCheckBipartite;
        private System.Windows.Forms.Button buttonDelGraph;
        private System.Windows.Forms.RadioButton radioButtonDeleteEdge;
        private System.Windows.Forms.Button buttonInDepth;
        private System.Windows.Forms.ListBox listBoxListWay;
        private System.Windows.Forms.Button buttonInWidth;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonAlgotitmPrima;
    }
}

