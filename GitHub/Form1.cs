using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub
{
    public partial class Form1 : Form
    {
        string Message1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            Message1 = textBox1.Text;
            Console.WriteLine(Message1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message;
            message = Message1;
            string titile = "Введеный текст";
            MessageBox.Show(Message1, titile);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
