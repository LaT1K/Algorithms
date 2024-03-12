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
        private void InitializeComponent() {
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
            dataGridView1.Location = new Point(12, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(516, 162);
            dataGridView1.TabIndex = 0;
            // 
            // Group
            // 
            Group.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Group.HeaderText = "Group";
            Group.MinimumWidth = 6;
            Group.Name = "Group";
            Group.ReadOnly = true;
            Group.Width = 65;
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
            button1.Location = new Point(575, 289);
            button1.Name = "button1";
            button1.Size = new Size(189, 37);
            button1.TabIndex = 1;
            button1.Text = "Fill";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(358, 401);
            button2.Name = "button2";
            button2.Size = new Size(170, 37);
            button2.TabIndex = 2;
            button2.Text = "Sort";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 401);
            button3.Name = "button3";
            button3.Size = new Size(170, 37);
            button3.TabIndex = 3;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(594, 12);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 4;
            label1.Text = "Group";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(594, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(594, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(594, 62);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 6;
            label2.Text = "Surname";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(594, 136);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(594, 162);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 10;
            label3.Text = "Math";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(594, 186);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(594, 112);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 8;
            label4.Text = "English";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(594, 236);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(594, 212);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 12;
            label5.Text = "Programming";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(12, 12);
            label6.Name = "label6";
            label6.Size = new Size(80, 21);
            label6.TabIndex = 14;
            label6.Text = "Unsorted";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(12, 212);
            label7.Name = "label7";
            label7.Size = new Size(60, 21);
            label7.TabIndex = 16;
            label7.Text = "Sorted";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { g, s, a });
            dataGridView2.Location = new Point(12, 236);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(516, 162);
            dataGridView2.TabIndex = 17;
            // 
            // g
            // 
            g.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            g.HeaderText = "Group";
            g.MinimumWidth = 6;
            g.Name = "g";
            g.ReadOnly = true;
            g.Width = 65;
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
            button4.Location = new Point(575, 401);
            button4.Name = "button4";
            button4.Size = new Size(92, 37);
            button4.TabIndex = 18;
            button4.Text = "Write";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(672, 401);
            button5.Name = "button5";
            button5.Size = new Size(92, 37);
            button5.TabIndex = 19;
            button5.Text = "Read";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bubble sort", "Shaker sort", "Minimum elements", "Insertion" });
            comboBox1.Location = new Point(575, 343);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 23);
            comboBox1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
