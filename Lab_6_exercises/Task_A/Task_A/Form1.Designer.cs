
namespace Task_A
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddID = new System.Windows.Forms.TextBox();
            this.Nodes1 = new System.Windows.Forms.ListBox();
            this.Nodes2 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addN = new System.Windows.Forms.Button();
            this.Edge1 = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.addE = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorM1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nodeCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edgeCount = new System.Windows.Forms.Label();
            this.errorM2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddID
            // 
            this.AddID.Location = new System.Drawing.Point(26, 19);
            this.AddID.Name = "AddID";
            this.AddID.Size = new System.Drawing.Size(158, 20);
            this.AddID.TabIndex = 1;
            // 
            // Nodes1
            // 
            this.Nodes1.BackColor = System.Drawing.Color.White;
            this.Nodes1.FormattingEnabled = true;
            this.Nodes1.Location = new System.Drawing.Point(6, 19);
            this.Nodes1.Name = "Nodes1";
            this.Nodes1.Size = new System.Drawing.Size(120, 173);
            this.Nodes1.TabIndex = 2;
            this.Nodes1.SelectedIndexChanged += new System.EventHandler(this.Nodes1_SelectedIndexChanged);
            // 
            // Nodes2
            // 
            this.Nodes2.FormattingEnabled = true;
            this.Nodes2.Location = new System.Drawing.Point(132, 19);
            this.Nodes2.Name = "Nodes2";
            this.Nodes2.Size = new System.Drawing.Size(120, 173);
            this.Nodes2.TabIndex = 3;
            this.Nodes2.SelectedIndexChanged += new System.EventHandler(this.Nodes2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addN);
            this.groupBox1.Controls.Add(this.AddID);
            this.groupBox1.Location = new System.Drawing.Point(81, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Node";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // addN
            // 
            this.addN.Location = new System.Drawing.Point(109, 45);
            this.addN.Name = "addN";
            this.addN.Size = new System.Drawing.Size(75, 23);
            this.addN.TabIndex = 2;
            this.addN.Text = "Add Node";
            this.addN.UseVisualStyleBackColor = true;
            this.addN.Click += new System.EventHandler(this.addN_Click);
            // 
            // Edge1
            // 
            this.Edge1.FormattingEnabled = true;
            this.Edge1.Location = new System.Drawing.Point(81, 231);
            this.Edge1.Name = "Edge1";
            this.Edge1.Size = new System.Drawing.Size(499, 160);
            this.Edge1.TabIndex = 6;
            this.Edge1.SelectedIndexChanged += new System.EventHandler(this.Edge1_SelectedIndexChanged);
            // 
            // addE
            // 
            this.addE.Location = new System.Drawing.Point(587, 195);
            this.addE.Name = "addE";
            this.addE.Size = new System.Drawing.Size(75, 23);
            this.addE.TabIndex = 8;
            this.addE.Text = "Make Edge";
            this.addE.UseVisualStyleBackColor = true;
            this.addE.Click += new System.EventHandler(this.addE_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Nodes1);
            this.groupBox2.Controls.Add(this.Nodes2);
            this.groupBox2.Location = new System.Drawing.Point(322, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 199);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Edge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Edges:";
            // 
            // errorM1
            // 
            this.errorM1.AutoSize = true;
            this.errorM1.ForeColor = System.Drawing.Color.White;
            this.errorM1.Location = new System.Drawing.Point(84, 126);
            this.errorM1.Name = "errorM1";
            this.errorM1.Size = new System.Drawing.Size(0, 13);
            this.errorM1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total nodes:";
            // 
            // nodeCount
            // 
            this.nodeCount.AutoSize = true;
            this.nodeCount.Location = new System.Drawing.Point(649, 151);
            this.nodeCount.Name = "nodeCount";
            this.nodeCount.Size = new System.Drawing.Size(13, 13);
            this.nodeCount.TabIndex = 15;
            this.nodeCount.Text = "0";
            this.nodeCount.Click += new System.EventHandler(this.nodeCount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total edges: ";
            // 
            // edgeCount
            // 
            this.edgeCount.AutoSize = true;
            this.edgeCount.Location = new System.Drawing.Point(649, 315);
            this.edgeCount.Name = "edgeCount";
            this.edgeCount.Size = new System.Drawing.Size(13, 13);
            this.edgeCount.TabIndex = 17;
            this.edgeCount.Text = "0";
            this.edgeCount.Click += new System.EventHandler(this.edgeCount_Click);
            // 
            // errorM2
            // 
            this.errorM2.AutoSize = true;
            this.errorM2.ForeColor = System.Drawing.Color.White;
            this.errorM2.Location = new System.Drawing.Point(587, 231);
            this.errorM2.Name = "errorM2";
            this.errorM2.Size = new System.Drawing.Size(0, 13);
            this.errorM2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorM2);
            this.Controls.Add(this.edgeCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nodeCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errorM1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.addE);
            this.Controls.Add(this.Edge1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AddID;
        private System.Windows.Forms.ListBox Nodes1;
        private System.Windows.Forms.ListBox Nodes2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox Edge1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button addN;
        private System.Windows.Forms.Button addE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errorM1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nodeCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label edgeCount;
        private System.Windows.Forms.Label errorM2;
    }
}

