using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1Hw3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double loanAmount = Convert.ToDouble(textBox1.Text);
            double interestRate = 6.39;
            int loanTerms = Convert.ToInt32(textBox4.Text);

            double monthlyMortagage;

            //Converting Yearly Interest Rate into MonthlyInterest Rate
            double monthlyInterestRate = interestRate / 1200;

            //Calculating Monthly Mortagage
            monthlyMortagage = (loanAmount * ((monthlyInterestRate) * Math.Pow(1 + monthlyInterestRate, loanTerms))) / (Math.Pow(1 + monthlyInterestRate, loanTerms) - 1);

            //Writting to text box
            textBox3.Text = (Math.Round(monthlyMortagage, 2)).ToString();
            textBox2.Text = (Math.Round(monthlyInterestRate*monthlyMortagage,2)).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
