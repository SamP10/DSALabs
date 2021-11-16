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
            this.remove = new System.Windows.Forms.Button();
            this.nameAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.RichTextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totQue = new System.Windows.Forms.Label();
            this.errorLabel2 = new System.Windows.Forms.Label();
            this.fromVal = new System.Windows.Forms.NumericUpDown();
            this.reverseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fromVal)).BeginInit();
            this.SuspendLayout();
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(668, 91);
            this.remove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(119, 50);
            this.remove.TabIndex = 4;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // nameAdd
            // 
            this.nameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nameAdd.Location = new System.Drawing.Point(208, 95);
            this.nameAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameAdd.Name = "nameAdd";
            this.nameAdd.Size = new System.Drawing.Size(305, 36);
            this.nameAdd.TabIndex = 5;
            this.nameAdd.TextChanged += new System.EventHandler(this.nameAdd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(114, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(147, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Reverse amount:";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(544, 91);
            this.add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(119, 50);
            this.add.TabIndex = 10;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(829, 91);
            this.displayBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(448, 601);
            this.displayBox.TabIndex = 11;
            this.displayBox.Text = "";
            this.displayBox.ZoomFactor = 2F;
            this.displayBox.TextChanged += new System.EventHandler(this.displayBox_TextChanged);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.errorLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.errorLabel.Location = new System.Drawing.Point(208, 135);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 29);
            this.errorLabel.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(555, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total in queue:";
            // 
            // totQue
            // 
            this.totQue.AutoSize = true;
            this.totQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.totQue.ForeColor = System.Drawing.SystemColors.Control;
            this.totQue.Location = new System.Drawing.Point(727, 242);
            this.totQue.Name = "totQue";
            this.totQue.Size = new System.Drawing.Size(27, 29);
            this.totQue.TabIndex = 14;
            this.totQue.Text = "0";
            // 
            // errorLabel2
            // 
            this.errorLabel2.AutoSize = true;
            this.errorLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.errorLabel2.Location = new System.Drawing.Point(208, 222);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(0, 17);
            this.errorLabel2.TabIndex = 15;
            // 
            // fromVal
            // 
            this.fromVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.fromVal.Location = new System.Drawing.Point(393, 178);
            this.fromVal.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.fromVal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fromVal.Name = "fromVal";
            this.fromVal.Size = new System.Drawing.Size(120, 36);
            this.fromVal.TabIndex = 16;
            this.fromVal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // reverseButton
            // 
            this.reverseButton.Location = new System.Drawing.Point(544, 172);
            this.reverseButton.Margin = new System.Windows.Forms.Padding(4);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(243, 50);
            this.reverseButton.TabIndex = 17;
            this.reverseButton.Text = "Reverse";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1295, 708);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.fromVal);
            this.Controls.Add(this.errorLabel2);
            this.Controls.Add(this.totQue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameAdd);
            this.Controls.Add(this.remove);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fromVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.TextBox nameAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.RichTextBox displayBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totQue;
        private System.Windows.Forms.Label errorLabel2;
        private System.Windows.Forms.NumericUpDown fromVal;
        private System.Windows.Forms.Button reverseButton;
    }
}

