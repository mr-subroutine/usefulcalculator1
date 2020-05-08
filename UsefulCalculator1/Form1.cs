using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsefulCalculator1
{
    public partial class Form1 : Form
    {
        protected int value;
        protected int celcius;
        protected int lengthAndWidthCount = 0;
        protected int length;
        protected int width;
        protected const double PI = 3.14;
        protected double areaCircle;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lengthAndWidthCount = 1;
            length = 0;
            width = 0;

            while (lengthAndWidthCount < 3)
            {
                try
                { 
                    value = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter your value: ",
                        "First Value = LENGTH, Second Value = WIDTH"));
                }

                catch (Exception)
                {
                    MessageBox.Show("Enter a correct numerical value");
                }

                if (lengthAndWidthCount == 1)
                {
                    length += value;
                }

                if (lengthAndWidthCount == 2)
                {
                    width += value;
                }
                value = 0;
                lengthAndWidthCount++;
            }

            value = length * width;
            lengthAndWidthCount = 1;
            MessageBox.Show("The area is: " + value, "ANSWER", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           int radiusVal = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter your radius: ",
                        "Get area of a circle"));
            areaCircle = PI * Math.Pow(radiusVal, 2);
            MessageBox.Show("The area of " + radiusVal.ToString() + "is " + areaCircle.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            celcius = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter a degree in celcius: ",
                       "Convert Celsius to Fahrenheit"));
            celcius = convertToF(celcius);
            MessageBox.Show("The temperature in F is:  " + celcius, "Fahrenheit", MessageBoxButtons.OK, MessageBoxIcon.Question);

            int newCelcius = 0;
            int convertedValue;
            txtTable.Text = "Celsius\t Fahrenheit" + Environment.NewLine;

            while (newCelcius < 52)
            {
                convertedValue = convertToF(newCelcius);
                txtTable.Text += newCelcius.ToString() + "\t" + convertedValue.ToString() + Environment.NewLine;
                //celciusCounter++;
                newCelcius++;
            }
        }

        private int convertToF(int cdegrees)
        {
            int result1 = Convert.ToInt32(cdegrees * 1.8);
            result1 = result1 + 32;
            return result1;
        }
    }
}
