using System;
using System.Windows.Forms;

namespace WinProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Дочерний процесс запущен";
            label2.Text = Task1.Run();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Дочерний процесс запущен";
            label3.Text = await Task2.Run();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Task2.Kill();
        }
    }
}
