using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Neevin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Caclculate(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            double secondValue = Convert.ToDouble(textBox2.Text);
            ICalculate calculate = Factory.CreateCalculate(((Button) sender).Name);
            double result = calculate.Calculate(firstValue, secondValue);
           
           label1.Text = result.ToString();
        }
        
        private void SingleCalculate(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
          
            ISingleInterface calculate = SingleFactory.CreateCalculate(((Button)sender).Name);
            double result = calculate.Calculate(firstValue);

            label1.Text = result.ToString();
        }
    }
}
