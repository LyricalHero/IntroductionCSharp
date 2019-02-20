using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTypes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello  ");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Min: " +int.MinValue + "Max: " int.MaxValue);
            //$ -интегрирует код в строку 
            MessageBox.Show($"Min: {int.MinValue}, Max: {int.MaxValue}");




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Min: {decimal.MinValue}, Max: {decimal.MaxValue}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Min: {double.MinValue}, Max: {double.MaxValue}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Min: {float.MinValue}, Max: {float.MaxValue}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Min: {ushort.MinValue}, Max: {ushort.MaxValue}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Min: {byte.MinValue}, Max: {byte.MaxValue}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Min: {long.MinValue}, Max: {long.MaxValue}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Min: {short.MinValue}, Max: {short.MaxValue}");
        }
    }
}
