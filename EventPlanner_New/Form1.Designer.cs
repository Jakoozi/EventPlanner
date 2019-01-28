namespace EventPlanner_New
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BdaycostLabel = new System.Windows.Forms.Label();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.CakeWritinglabel = new System.Windows.Forms.Label();
            this.CakeWritingBox = new System.Windows.Forms.TextBox();
            this.fancyCheckBox = new System.Windows.Forms.CheckBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(44, 53);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(148, 21);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cost :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(44, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Fancy OPtion";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(44, 158);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(118, 19);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Healthy option";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of people";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(303, 260);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BdaycostLabel);
            this.tabPage1.Controls.Add(this.tooLongLabel);
            this.tabPage1.Controls.Add(this.numericUpDown2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.CakeWritinglabel);
            this.tabPage1.Controls.Add(this.CakeWritingBox);
            this.tabPage1.Controls.Add(this.fancyCheckBox);
            this.tabPage1.Controls.Add(this.costLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(295, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BirthdayParty";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BdaycostLabel
            // 
            this.BdaycostLabel.AutoSize = true;
            this.BdaycostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BdaycostLabel.Location = new System.Drawing.Point(110, 191);
            this.BdaycostLabel.Name = "BdaycostLabel";
            this.BdaycostLabel.Size = new System.Drawing.Size(17, 17);
            this.BdaycostLabel.TabIndex = 9;
            this.BdaycostLabel.Text = "$";
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.Red;
            this.tooLongLabel.Location = new System.Drawing.Point(129, 100);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(127, 15);
            this.tooLongLabel.TabIndex = 8;
            this.tooLongLabel.Text = "Writting is too long";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(129, 17);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(127, 21);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "No of People :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CakeWritinglabel
            // 
            this.CakeWritinglabel.AutoSize = true;
            this.CakeWritinglabel.Location = new System.Drawing.Point(25, 100);
            this.CakeWritinglabel.Name = "CakeWritinglabel";
            this.CakeWritinglabel.Size = new System.Drawing.Size(96, 15);
            this.CakeWritinglabel.TabIndex = 5;
            this.CakeWritinglabel.Text = "Cake Writing :";
            // 
            // CakeWritingBox
            // 
            this.CakeWritingBox.Location = new System.Drawing.Point(28, 145);
            this.CakeWritingBox.Name = "CakeWritingBox";
            this.CakeWritingBox.Size = new System.Drawing.Size(228, 21);
            this.CakeWritingBox.TabIndex = 4;
            this.CakeWritingBox.Text = "Happy Birthday";
            this.CakeWritingBox.TextChanged += new System.EventHandler(this.CakeWritingBox_TextChanged);
            // 
            // fancyCheckBox
            // 
            this.fancyCheckBox.AutoSize = true;
            this.fancyCheckBox.Checked = true;
            this.fancyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyCheckBox.Location = new System.Drawing.Point(28, 60);
            this.fancyCheckBox.Name = "fancyCheckBox";
            this.fancyCheckBox.Size = new System.Drawing.Size(63, 19);
            this.fancyCheckBox.TabIndex = 2;
            this.fancyCheckBox.Text = "Fancy";
            this.fancyCheckBox.UseVisualStyleBackColor = true;
            this.fancyCheckBox.CheckedChanged += new System.EventHandler(this.fancyCheckBox_CheckedChanged);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(25, 191);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(79, 15);
            this.costLabel.TabIndex = 1;
            this.costLabel.Text = "Total Cost :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(269, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DinnerParty";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 279);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox fancyCheckBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label CakeWritinglabel;
        private System.Windows.Forms.TextBox CakeWritingBox;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.Label BdaycostLabel;
    }
}

