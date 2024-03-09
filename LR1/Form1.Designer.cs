namespace LR1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Group = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            Avg = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dataGridView2 = new DataGridView();
            g = new DataGridViewTextBoxColumn();
            s = new DataGridViewTextBoxColumn();
            a = new DataGridViewTextBoxColumn();
            button4 = new Button();
            button5 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Group, Surname, Avg });
            dataGridView1.Location = new Point(14, 48);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(590, 216);
            dataGridView1.TabIndex = 0;
            // 
            // Group
            // 
            Group.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Group.HeaderText = "Group";
            Group.MinimumWidth = 6;
            Group.Name = "Group";
            Group.ReadOnly = true;
            Group.Width = 79;
            // 
            // Surname
            // 
            Surname.HeaderText = "Surname";
            Surname.MinimumWidth = 6;
            Surname.Name = "Surname";
            Surname.Width = 125;
            // 
            // Avg
            // 
            Avg.HeaderText = "Avg";
            Avg.MinimumWidth = 6;
            Avg.Name = "Avg";
            Avg.ReadOnly = true;
            Avg.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(657, 385);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(216, 49);
            button1.TabIndex = 1;
            button1.Text = "Fill";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(409, 535);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(194, 49);
            button2.TabIndex = 2;
            button2.Text = "Sort";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(14, 535);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(194, 49);
            button3.TabIndex = 3;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(679, 16);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 4;
            label1.Text = "Group";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(679, 48);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(679, 115);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(679, 83);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 6;
            label2.Text = "Surname";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(679, 181);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 27);
            textBox3.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(679, 216);
            label3.Name = "label3";
            label3.Size = new Size(62, 28);
            label3.TabIndex = 10;
            label3.Text = "Math";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(679, 248);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(114, 27);
            textBox4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(679, 149);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 8;
            label4.Text = "English";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(679, 315);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(114, 27);
            textBox5.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(679, 283);
            label5.Name = "label5";
            label5.Size = new Size(141, 28);
            label5.TabIndex = 12;
            label5.Text = "Programming";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(14, 16);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 14;
            label6.Text = "Unsorted";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(14, 283);
            label7.Name = "label7";
            label7.Size = new Size(75, 28);
            label7.TabIndex = 16;
            label7.Text = "Sorted";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { g, s, a });
            dataGridView2.Location = new Point(14, 315);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(590, 216);
            dataGridView2.TabIndex = 17;
            // 
            // g
            // 
            g.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            g.HeaderText = "Group";
            g.MinimumWidth = 6;
            g.Name = "g";
            g.ReadOnly = true;
            g.Width = 79;
            // 
            // s
            // 
            s.HeaderText = "Surname";
            s.MinimumWidth = 6;
            s.Name = "s";
            s.Width = 125;
            // 
            // a
            // 
            a.HeaderText = "Avg";
            a.MinimumWidth = 6;
            a.Name = "a";
            a.ReadOnly = true;
            a.Width = 125;
            // 
            // button4
            // 
            button4.Location = new Point(657, 535);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(105, 49);
            button4.TabIndex = 18;
            button4.Text = "Write";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(768, 535);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(105, 49);
            button5.TabIndex = 19;
            button5.Text = "Read";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bubble sort", "Shaker sort" });
            comboBox1.Location = new Point(657, 457);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 28);
            comboBox1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(comboBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dataGridView2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Latkivskyi";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn Group;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Avg;
        private Label label7;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn g;
        private DataGridViewTextBoxColumn s;
        private DataGridViewTextBoxColumn a;
        private Button button4;
        private Button button5;
        private ComboBox comboBox1;
    }
}
