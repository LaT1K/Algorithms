using System.CodeDom.Compiler;
using System.Security.Policy;

namespace LR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filePath = "output.bin";
        private void button1_Click(object sender, EventArgs e)
        {
            addStudent();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;

        }
        private void addStudent()
        {
            try
            {
                students_bubble temp = new students_bubble(textBox1.Text,
                                            textBox2.Text,
                                            Convert.ToInt32(textBox3.Text),
                                            Convert.ToInt32(textBox4.Text),
                                            Convert.ToInt32(textBox5.Text));
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["Group"].Value = temp.group;
                dataGridView1.Rows[rowIndex].Cells["Surname"].Value = temp.surname;
                dataGridView1.Rows[rowIndex].Cells["Avg"].Value = temp.calAvg().ToString("F2");
            }

            catch (FormatException ex)
            {

                MessageBox.Show($"{ex.Message}", "Error");
                return;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void bubble_sort()
        {
            dataGridView2.Rows.Clear();
            students_bubble[] arr = new students_bubble[dataGridView1.Rows.Count - 1];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new students_bubble();
                arr[i].group = Convert.ToString(dataGridView1.Rows[i].Cells["Group"].Value);
                arr[i].surname = Convert.ToString(dataGridView1.Rows[i].Cells["Surname"].Value);
                arr[i].Avg = Convert.ToDouble(dataGridView1.Rows[i].Cells["Avg"].Value);
            }

            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].Avg > arr[j + 1].Avg)
                    {
                        students_bubble temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    else if (arr[j].Avg == arr[j + 1].Avg)
                    {
                        if (string.Compare(arr[j].surname, arr[j + 1].surname) > 0)
                        {
                            students_bubble temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                    else if (arr[j].Avg < arr[j + 1].Avg)
                    {
                        counter++;
                    }
                }
                if (counter == arr.Length - 1)
                {
                    MessageBox.Show("Природність поведінки працює");
                    break;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int rowIndex = dataGridView2.Rows.Add();
                dataGridView2.Rows[rowIndex].Cells["g"].Value = arr[i].group;
                dataGridView2.Rows[rowIndex].Cells["s"].Value = arr[i].surname;
                dataGridView2.Rows[rowIndex].Cells["a"].Value = arr[i].Avg.ToString("F2");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text.Equals("Bubble sort"))
            {
                this.bubble_sort();
            }
            else if(comboBox1.Text.Equals("Shaker sort"))
            {
                this.shaker_sort();
            }
        }

        private void shaker_sort()
        {
            dataGridView2.Rows.Clear();
            students_bubble[] arr = new students_bubble[dataGridView1.Rows.Count - 1];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new students_bubble();
                arr[i].group = Convert.ToString(dataGridView1.Rows[i].Cells["Group"].Value);
                arr[i].surname = Convert.ToString(dataGridView1.Rows[i].Cells["Surname"].Value);
                arr[i].Avg = Convert.ToDouble(dataGridView1.Rows[i].Cells["Avg"].Value);
            }

            int left = 0;
            int right = arr.Length - 1;
            bool swapped;

            do
            {
                swapped = false;

                // Прохід вправо
                for (int i = left; i < right; i++)
                {
                    if (arr[i].Avg > arr[i + 1].Avg || (arr[i].Avg == arr[i + 1].Avg && string.Compare(arr[i].surname, arr[i + 1].surname) > 0))
                    {
                        Swap(ref arr[i], ref arr[i + 1]);
                        swapped = true;
                    }
                }
                right--;

                if (!swapped)
                    break;

                swapped = false;

                // Прохід вліво
                for (int i = right; i > left; i--)
                {
                    if (arr[i].Avg < arr[i - 1].Avg || (arr[i].Avg == arr[i - 1].Avg && string.Compare(arr[i].surname, arr[i - 1].surname) < 0))
                    {
                        Swap(ref arr[i], ref arr[i - 1]);
                        swapped = true;
                    }
                }
                left++;
            } while (swapped);


            for (int i = 0; i < arr.Length; i++)
            {
                dataGridView2.Rows.Add(arr[i].group, arr[i].surname, arr[i].Avg.ToString("F2"));
            }
            

        }
        private static void Swap(ref students_bubble a, ref students_bubble b)
        {
            students_bubble temp = a;
            a = b;
            b = temp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            students_bubble[] arr = new students_bubble[dataGridView1.Rows.Count - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new students_bubble();
                arr[i].group = Convert.ToString(dataGridView1.Rows[i].Cells["Group"].Value);
                arr[i].surname = Convert.ToString(dataGridView1.Rows[i].Cells["Surname"].Value);
                arr[i].Avg = Convert.ToDouble(dataGridView1.Rows[i].Cells["Avg"].Value);
            }

            Writestudents_bubbleToFile(arr, filePath);
            MessageBox.Show("Дані записано");

        }
        static void Writestudents_bubbleToFile(students_bubble[] students_bubble, string filePath)
        {
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
                {
                    foreach (var student in students_bubble)
                    {
                        // Запис групи, прізвища та середнього балу студента у бінарний файл
                        writer.Write(student.group);
                        writer.Write(student.surname);
                        writer.Write(student.Avg);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася помилка при записі у файл: {ex.Message}");
            }
        }

        static students_bubble[] ReadStudentsFromFile(string filePath)
        {
            List<students_bubble> studentList = new List<students_bubble>();
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    // Read until the end of the file
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        students_bubble student = new students_bubble
                        {
                            group = reader.ReadString(),
                            surname = reader.ReadString(),
                            Avg = reader.ReadDouble()
                        };

                        // Add student only if all fields were successfully read
                        studentList.Add(student);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading from the file: {ex.Message}");
            }

            // Convert list to array
            return studentList.ToArray();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            students_bubble[] arr = ReadStudentsFromFile(filePath);

            for (int i = 0; i < arr.Length; i++)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["Group"].Value = arr[i].group;
                dataGridView1.Rows[rowIndex].Cells["Surname"].Value = arr[i].surname;
                dataGridView1.Rows[rowIndex].Cells["Avg"].Value = arr[i].Avg.ToString("F2");
            }
            MessageBox.Show("Дані прочитано");
        }
    }
}
