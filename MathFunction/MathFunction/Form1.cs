using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*abs mutlak*/
            double sayi = Convert.ToDouble(textBox1.Text);
            label2.Text = Math.Abs(sayi).ToString();

            /*ceil:Üste yuvarlama*/
            label2.Text = Math.Ceiling(sayi).ToString();

            /*Floor = alta yuvarlama*/
            label2.Text = Math.Floor(sayi).ToString();

            /*Pow = üstünü alma*/
            label2.Text = Math.Pow(sayi, 3).ToString();

            /*Sqrt = Karekök alma*/
            label2.Text = Math.Sqrt(sayi).ToString();

            /*Pi değeri*/
            label2.Text = Math.PI.ToString();

            /*Max değeri*/
            label2.Text = Math.Max(sayi,sayi).ToString(); 
            
            /*Min değeri*/
            label2.Text = Math.Min(sayi,sayi).ToString();



        }
    }
}