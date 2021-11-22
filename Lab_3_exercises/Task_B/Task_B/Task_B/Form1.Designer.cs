
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
            this.view = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.availYes = new System.Windows.Forms.RadioButton();
            this.availNo = new System.Windows.Forms.RadioButton();
            this.detailsDisplay = new System.Windows.Forms.RichTextBox();
            this.delete = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.MaskedTextBox();
            this.nameText = new System.Windows.Forms.MaskedTextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.errorLabel2 = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(129, 303);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(98, 23);
            this.view.TabIndex = 0;
            this.view.Text = "View details";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(630, 266);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(118, 23);
            this.add.TabIndex = 1;
            this.add.Text = "Add Employee";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBox1.ForeColor = System.Drawing.Color.OldLace;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(42, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 204);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameText);
            this.groupBox1.Controls.Add(this.idText);
            this.groupBox1.Controls.Add(this.availNo);
            this.groupBox1.Controls.Add(this.availYes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(487, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 148);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new employee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Available?";
            // 
            // availYes
            // 
            this.availYes.AutoSize = true;
            this.availYes.Location = new System.Drawing.Point(86, 111);
            this.availYes.Name = "availYes";
            this.availYes.Size = new System.Drawing.Size(53, 21);
            this.availYes.TabIndex = 3;
            this.availYes.TabStop = true;
            this.availYes.Text = "Yes";
            this.availYes.UseVisualStyleBackColor = true;
            // 
            // availNo
            // 
            this.availNo.AutoSize = true;
            this.availNo.Location = new System.Drawing.Point(145, 111);
            this.availNo.Name = "availNo";
            this.availNo.Size = new System.Drawing.Size(47, 21);
            this.availNo.TabIndex = 4;
            this.availNo.TabStop = true;
            this.availNo.Text = "No";
            this.availNo.UseVisualStyleBackColor = true;
            // 
            // detailsDisplay
            // 
            this.detailsDisplay.BackColor = System.Drawing.Color.DarkCyan;
            this.detailsDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.detailsDisplay.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.detailsDisplay.Location = new System.Drawing.Point(255, 69);
            this.detailsDisplay.Name = "detailsDisplay";
            this.detailsDisplay.ReadOnly = true;
            this.detailsDisplay.Size = new System.Drawing.Size(121, 148);
            this.detailsDisplay.TabIndex = 4;
            this.detailsDisplay.Text = "";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(42, 303);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(81, 23);
            this.delete.TabIndex = 5;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // idText
            // 
            this.idText.BackColor = System.Drawing.Color.DarkCyan;
            this.idText.ForeColor = System.Drawing.SystemColors.Window;
            this.idText.Location = new System.Drawing.Point(62, 29);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(179, 22);
            this.idText.TabIndex = 6;
            this.idText.ValidatingType = typeof(int);
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.Color.DarkCyan;
            this.nameText.ForeColor = System.Drawing.SystemColors.Window;
            this.nameText.Location = new System.Drawing.Point(62, 73);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(179, 22);
            this.nameText.TabIndex = 7;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(494, 290);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 6;
            // 
            // errorLabel2
            // 
            this.errorLabel2.AutoSize = true;
            this.errorLabel2.Location = new System.Drawing.Point(39, 329);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(0, 17);
            this.errorLabel2.TabIndex = 7;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(42, 274);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(188, 23);
            this.show.TabIndex = 8;
            this.show.Text = "Show employees";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Employee details:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.show);
            this.Controls.Add(this.errorLabel2);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.detailsDisplay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.view);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton availNo;
        private System.Windows.Forms.RadioButton availYes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox nameText;
        private System.Windows.Forms.MaskedTextBox idText;
        private System.Windows.Forms.RichTextBox detailsDisplay;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label errorLabel2;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Label label4;
    }
}

