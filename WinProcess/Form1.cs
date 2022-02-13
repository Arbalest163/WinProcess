using System;
using System.Windows.Forms;

namespace WinProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitComboBox();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt";
        }

        private void InitComboBox()
        {
            string[] actions = { "+", "-", "*", "/" };
            foreach (var act in actions)
            {
                comboBox1.Items.Add(act);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            label2.Text = "Дочерний процесс запущен";
            label2.Text = Task1.Run();
            button1.Enabled = true;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            label3.Text = "Дочерний процесс запущен";
            label3.Text = await Task2.Run();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Task2.Kill();
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            double value1 = 0;
            double value2 = 0;
            bool isNumber = Double.TryParse(textBox1.Text, out value1) && Double.TryParse(textBox2.Text, out value2);

            if (!isNumber)
            {
                MessageBox.Show("Введите целое число");
                return;
            }
            var action = comboBox1.SelectedItem.ToString();

            Task3.Run(new[] {value1.ToString(), value2.ToString(), action });
            button3.Enabled = true;
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Введите слово для поиска");
                button4.Enabled = true;
                return;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            var task4 = new Task4
            {
                FindWord = textBox3.Text,
                FilePath = openFileDialog1.FileName
            };
            var result = await task4.RunAsync();

            label8.Text = result.ToString();

            button4.Enabled = true;
        }
    }
}
