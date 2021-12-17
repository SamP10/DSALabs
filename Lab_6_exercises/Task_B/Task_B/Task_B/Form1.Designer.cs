
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
            this.bothSel = new System.Windows.Forms.RadioButton();
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
            this.errorM3 = new System.Windows.Forms.Label();
            this.delFlight = new System.Windows.Forms.Button();
            this.errorM2 = new System.Windows.Forms.Label();
            this.addDir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dirShow = new System.Windows.Forms.ListBox();
            this.errorM1 = new System.Windows.Forms.Label();
            this.errorM4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bothSel);
            this.groupBox1.Controls.Add(this.fromBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.conSel);
            this.groupBox1.Controls.Add(this.directSel);
            this.groupBox1.Location = new System.Drawing.Point(38, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // bothSel
            // 
            this.bothSel.AutoSize = true;
            this.bothSel.Location = new System.Drawing.Point(249, 111);
            this.bothSel.Name = "bothSel";
            this.bothSel.Size = new System.Drawing.Size(47, 17);
            this.bothSel.TabIndex = 6;
            this.bothSel.Text = "Both";
            this.bothSel.UseVisualStyleBackColor = true;
            // 
            // fromBox
            // 
            this.fromBox.FormattingEnabled = true;
            this.fromBox.Location = new System.Drawing.Point(9, 36);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(211, 108);
            this.fromBox.TabIndex = 5;
            this.fromBox.SelectedIndexChanged += new System.EventHandler(this.fromBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "From:";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(249, 36);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // conSel
            // 
            this.conSel.AutoSize = true;
            this.conSel.Location = new System.Drawing.Point(249, 88);
            this.conSel.Name = "conSel";
            this.conSel.Size = new System.Drawing.Size(79, 17);
            this.conSel.TabIndex = 1;
            this.conSel.Text = "Connecting";
            this.conSel.UseVisualStyleBackColor = true;
            // 
            // directSel
            // 
            this.directSel.AutoSize = true;
            this.directSel.Location = new System.Drawing.Point(249, 65);
            this.directSel.Name = "directSel";
            this.directSel.Size = new System.Drawing.Size(53, 17);
            this.directSel.TabIndex = 0;
            this.directSel.Text = "Direct";
            this.directSel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addNode);
            this.groupBox2.Controls.Add(this.addID);
            this.groupBox2.Location = new System.Drawing.Point(392, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Airport";
            // 
            // addNode
            // 
            this.addNode.Location = new System.Drawing.Point(76, 65);
            this.addNode.Name = "addNode";
            this.addNode.Size = new System.Drawing.Size(75, 23);
            this.addNode.TabIndex = 10;
            this.addNode.Text = "Add";
            this.addNode.UseVisualStyleBackColor = true;
            this.addNode.Click += new System.EventHandler(this.addNode_Click);
            // 
            // addID
            // 
            this.addID.Location = new System.Drawing.Point(23, 36);
            this.addID.Name = "addID";
            this.addID.Size = new System.Drawing.Size(171, 20);
            this.addID.TabIndex = 9;
            this.addID.TextChanged += new System.EventHandler(this.addID_TextChanged);
            // 
            // dfsBox
            // 
            this.dfsBox.FormattingEnabled = true;
            this.dfsBox.Location = new System.Drawing.Point(38, 199);
            this.dfsBox.Name = "dfsBox";
            this.dfsBox.Size = new System.Drawing.Size(342, 160);
            this.dfsBox.TabIndex = 8;
            // 
            // conBox1
            // 
            this.conBox1.FormattingEnabled = true;
            this.conBox1.Location = new System.Drawing.Point(6, 19);
            this.conBox1.Name = "conBox1";
            this.conBox1.Size = new System.Drawing.Size(116, 108);
            this.conBox1.TabIndex = 9;
            this.conBox1.SelectedIndexChanged += new System.EventHandler(this.conBox1_SelectedIndexChanged);
            // 
            // conBox2
            // 
            this.conBox2.FormattingEnabled = true;
            this.conBox2.Location = new System.Drawing.Point(128, 19);
            this.conBox2.Name = "conBox2";
            this.conBox2.Size = new System.Drawing.Size(116, 108);
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
            this.groupBox3.Location = new System.Drawing.Point(386, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 284);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add/Remove Directed Flights";
            // 
            // errorM3
            // 
            this.errorM3.AutoSize = true;
            this.errorM3.Location = new System.Drawing.Point(157, 260);
            this.errorM3.Name = "errorM3";
            this.errorM3.Size = new System.Drawing.Size(0, 13);
            this.errorM3.TabIndex = 15;
            // 
            // delFlight
            // 
            this.delFlight.Location = new System.Drawing.Point(6, 255);
            this.delFlight.Name = "delFlight";
            this.delFlight.Size = new System.Drawing.Size(129, 23);
            this.delFlight.TabIndex = 14;
            this.delFlight.Text = "Remove connection";
            this.delFlight.UseVisualStyleBackColor = true;
            this.delFlight.Click += new System.EventHandler(this.delFlight_Click);
            // 
            // errorM2
            // 
            this.errorM2.AutoSize = true;
            this.errorM2.Location = new System.Drawing.Point(249, 20);
            this.errorM2.Name = "errorM2";
            this.errorM2.Size = new System.Drawing.Size(0, 13);
            this.errorM2.TabIndex = 13;
            // 
            // addDir
            // 
            this.addDir.Location = new System.Drawing.Point(271, 104);
            this.addDir.Name = "addDir";
            this.addDir.Size = new System.Drawing.Size(75, 23);
            this.addDir.TabIndex = 10;
            this.addDir.Text = "Add";
            this.addDir.UseVisualStyleBackColor = true;
            this.addDir.Click += new System.EventHandler(this.addDir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Direct Flights:";
            // 
            // dirShow
            // 
            this.dirShow.FormattingEnabled = true;
            this.dirShow.Location = new System.Drawing.Point(6, 156);
            this.dirShow.Name = "dirShow";
            this.dirShow.Size = new System.Drawing.Size(238, 95);
            this.dirShow.TabIndex = 11;
            this.dirShow.SelectedIndexChanged += new System.EventHandler(this.dirShow_SelectedIndexChanged);
            // 
            // errorM1
            // 
            this.errorM1.AutoSize = true;
            this.errorM1.Location = new System.Drawing.Point(630, 32);
            this.errorM1.Name = "errorM1";
            this.errorM1.Size = new System.Drawing.Size(0, 13);
            this.errorM1.TabIndex = 12;
            // 
            // errorM4
            // 
            this.errorM4.AutoSize = true;
            this.errorM4.Location = new System.Drawing.Point(44, 371);
            this.errorM4.Name = "errorM4";
            this.errorM4.Size = new System.Drawing.Size(0, 13);
            this.errorM4.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorM4);
            this.Controls.Add(this.errorM1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dfsBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.RadioButton bothSel;
        private System.Windows.Forms.Button delFlight;
        private System.Windows.Forms.Label errorM3;
        private System.Windows.Forms.Label errorM4;
    }
}

