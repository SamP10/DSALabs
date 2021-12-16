
namespace Task_B
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.fromBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.conSel = new System.Windows.Forms.RadioButton();
            this.directSel = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addNode = new System.Windows.Forms.Button();
            this.addID = new System.Windows.Forms.TextBox();
            this.dfsBox = new System.Windows.Forms.ListBox();
            this.conBox1 = new System.Windows.Forms.ListBox();
            this.conBox2 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delFlight = new System.Windows.Forms.Button();
            this.errorM2 = new System.Windows.Forms.Label();
            this.addDir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dirShow = new System.Windows.Forms.ListBox();
            this.errorM1 = new System.Windows.Forms.Label();
            this.errorM3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.fromBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.conSel);
            this.groupBox1.Controls.Add(this.directSel);
            this.groupBox1.Location = new System.Drawing.Point(51, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(456, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(332, 137);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 21);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.Text = "Both";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // fromBox
            // 
            this.fromBox.FormattingEnabled = true;
            this.fromBox.ItemHeight = 16;
            this.fromBox.Location = new System.Drawing.Point(12, 44);
            this.fromBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(280, 132);
            this.fromBox.TabIndex = 5;
            this.fromBox.SelectedIndexChanged += new System.EventHandler(this.fromBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "From:";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(332, 44);
            this.Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 28);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // conSel
            // 
            this.conSel.AutoSize = true;
            this.conSel.Location = new System.Drawing.Point(332, 108);
            this.conSel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.conSel.Name = "conSel";
            this.conSel.Size = new System.Drawing.Size(100, 21);
            this.conSel.TabIndex = 1;
            this.conSel.Text = "Connecting";
            this.conSel.UseVisualStyleBackColor = true;
            // 
            // directSel
            // 
            this.directSel.AutoSize = true;
            this.directSel.Location = new System.Drawing.Point(332, 80);
            this.directSel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.directSel.Name = "directSel";
            this.directSel.Size = new System.Drawing.Size(66, 21);
            this.directSel.TabIndex = 0;
            this.directSel.Text = "Direct";
            this.directSel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addNode);
            this.groupBox2.Controls.Add(this.addID);
            this.groupBox2.Location = new System.Drawing.Point(523, 39);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(289, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Airport";
            // 
            // addNode
            // 
            this.addNode.Location = new System.Drawing.Point(101, 80);
            this.addNode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addNode.Name = "addNode";
            this.addNode.Size = new System.Drawing.Size(100, 28);
            this.addNode.TabIndex = 10;
            this.addNode.Text = "Add";
            this.addNode.UseVisualStyleBackColor = true;
            this.addNode.Click += new System.EventHandler(this.addNode_Click);
            // 
            // addID
            // 
            this.addID.Location = new System.Drawing.Point(31, 44);
            this.addID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addID.Name = "addID";
            this.addID.Size = new System.Drawing.Size(227, 22);
            this.addID.TabIndex = 9;
            this.addID.TextChanged += new System.EventHandler(this.addID_TextChanged);
            // 
            // dfsBox
            // 
            this.dfsBox.FormattingEnabled = true;
            this.dfsBox.ItemHeight = 16;
            this.dfsBox.Location = new System.Drawing.Point(51, 245);
            this.dfsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dfsBox.Name = "dfsBox";
            this.dfsBox.Size = new System.Drawing.Size(455, 196);
            this.dfsBox.TabIndex = 8;
            // 
            // conBox1
            // 
            this.conBox1.FormattingEnabled = true;
            this.conBox1.ItemHeight = 16;
            this.conBox1.Location = new System.Drawing.Point(8, 23);
            this.conBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.conBox1.Name = "conBox1";
            this.conBox1.Size = new System.Drawing.Size(153, 132);
            this.conBox1.TabIndex = 9;
            this.conBox1.SelectedIndexChanged += new System.EventHandler(this.conBox1_SelectedIndexChanged);
            // 
            // conBox2
            // 
            this.conBox2.FormattingEnabled = true;
            this.conBox2.ItemHeight = 16;
            this.conBox2.Location = new System.Drawing.Point(171, 23);
            this.conBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.conBox2.Name = "conBox2";
            this.conBox2.Size = new System.Drawing.Size(153, 132);
            this.conBox2.TabIndex = 10;
            this.conBox2.SelectedIndexChanged += new System.EventHandler(this.conBox2_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.errorM3);
            this.groupBox3.Controls.Add(this.delFlight);
            this.groupBox3.Controls.Add(this.errorM2);
            this.groupBox3.Controls.Add(this.addDir);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dirShow);
            this.groupBox3.Controls.Add(this.conBox1);
            this.groupBox3.Controls.Add(this.conBox2);
            this.groupBox3.Location = new System.Drawing.Point(515, 191);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(488, 350);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add/Remove Directed Flights";
            // 
            // delFlight
            // 
            this.delFlight.Location = new System.Drawing.Point(8, 314);
            this.delFlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delFlight.Name = "delFlight";
            this.delFlight.Size = new System.Drawing.Size(172, 28);
            this.delFlight.TabIndex = 14;
            this.delFlight.Text = "Remove connection";
            this.delFlight.UseVisualStyleBackColor = true;
            this.delFlight.Click += new System.EventHandler(this.delFlight_Click);
            // 
            // errorM2
            // 
            this.errorM2.AutoSize = true;
            this.errorM2.Location = new System.Drawing.Point(332, 25);
            this.errorM2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorM2.Name = "errorM2";
            this.errorM2.Size = new System.Drawing.Size(0, 17);
            this.errorM2.TabIndex = 13;
            // 
            // addDir
            // 
            this.addDir.Location = new System.Drawing.Point(361, 128);
            this.addDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addDir.Name = "addDir";
            this.addDir.Size = new System.Drawing.Size(100, 28);
            this.addDir.TabIndex = 10;
            this.addDir.Text = "Add";
            this.addDir.UseVisualStyleBackColor = true;
            this.addDir.Click += new System.EventHandler(this.addDir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Direct Flights:";
            // 
            // dirShow
            // 
            this.dirShow.FormattingEnabled = true;
            this.dirShow.ItemHeight = 16;
            this.dirShow.Location = new System.Drawing.Point(8, 192);
            this.dirShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dirShow.Name = "dirShow";
            this.dirShow.Size = new System.Drawing.Size(316, 116);
            this.dirShow.TabIndex = 11;
            this.dirShow.SelectedIndexChanged += new System.EventHandler(this.dirShow_SelectedIndexChanged);
            // 
            // errorM1
            // 
            this.errorM1.AutoSize = true;
            this.errorM1.Location = new System.Drawing.Point(860, 59);
            this.errorM1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorM1.Name = "errorM1";
            this.errorM1.Size = new System.Drawing.Size(0, 17);
            this.errorM1.TabIndex = 12;
            // 
            // errorM3
            // 
            this.errorM3.AutoSize = true;
            this.errorM3.Location = new System.Drawing.Point(209, 320);
            this.errorM3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorM3.Name = "errorM3";
            this.errorM3.Size = new System.Drawing.Size(0, 17);
            this.errorM3.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.errorM1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dfsBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton conSel;
        private System.Windows.Forms.RadioButton directSel;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ListBox fromBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox addID;
        private System.Windows.Forms.ListBox dfsBox;
        private System.Windows.Forms.ListBox conBox1;
        private System.Windows.Forms.ListBox conBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox dirShow;
        private System.Windows.Forms.Button addNode;
        private System.Windows.Forms.Label errorM1;
        private System.Windows.Forms.Label errorM2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button delFlight;
        private System.Windows.Forms.Label errorM3;
    }
}

