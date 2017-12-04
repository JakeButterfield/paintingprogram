using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Demo
{
    public partial class WindowsDemoForm : Form
    {

        public int basePrice;

        public int paintPrice;

        public int totalPrice = 0;

        public int pricePerWall;

        public int labourPrice;

        public int wallAmount;
        public int wallLength;
        public int wallHeight;

        public WindowsDemoForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            basePrice = 30;
            labourPrice = 5;
            Input_BasePrice.Text = "£" + basePrice.ToString();

            // Disable Decorating Elements
            groupBox3.Visible = false;
            radioButton6.Visible = false;
            radioButton2.Visible = false;

            // Enable Painting Elements:
            label5.Text = "Painting:";
            label2.Text = "How many walls need painting?";
            groupBox2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            basePrice = 50;
            labourPrice = 10;
            Input_BasePrice.Text = "£" + basePrice.ToString();

            // Disable Painting Elements:
            groupBox2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;

            // Enable Decorating Elements:
            label5.Text = "Decorating:";
            label2.Text = "How many walls need wallpaper?";
            groupBox3.Visible = true;
            radioButton6.Visible = true;
            radioButton2.Visible = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            paintPrice = 10;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            paintPrice = 20;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            paintPrice = 30;
        }

        private void Input_BasePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void Input_WallAmount_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(Input_WallAmount.Text, out value))
            {
                if (value < 1)
                {
                    MessageBox.Show("The number cannot be 0");
                }
                else
                {
                    wallAmount = value;
                }
            }
            else if (string.IsNullOrWhiteSpace(Input_WallAmount.Text))
            {
                // Do Nothing
            }
            else
            {
                MessageBox.Show("The amount of walls must be a number");
            }
        }

        private void Input_WallLength_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(Input_WallLength.Text, out value))
            {
                if (value < 1)
                {
                    MessageBox.Show("The number cannot be 0");
                }
                else
                {
                    wallLength = value;
                }
            }
            else if (string.IsNullOrWhiteSpace(Input_WallLength.Text))
            {
                // Do Nothing
            }
            else
            {
                MessageBox.Show("The length of the wall must be a number");
            }
        }

        private void Input_WallHeight_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(Input_WallHeight.Text, out value))
            {
                if(value < 1)
                {
                    MessageBox.Show("The number cannot be 0");
                }
                else
                {
                    wallHeight = value;
                }
                
            }
            else if (string.IsNullOrWhiteSpace(Input_WallHeight.Text))
            {
                // Do Nothing
            }
            else
            {
                MessageBox.Show("The height of the wall must be a number");
            }
        }

        private void CalculatePricePerWall()
        {
            int wallArea = wallHeight * wallLength;
            int elementNeeded;

            if (wallArea < 16)
            {
                elementNeeded = 1;
            } else if (wallArea < 32)
            {
                elementNeeded = 2;
            } else
            {
                elementNeeded = 3;
            }

            pricePerWall = elementNeeded * paintPrice;
        }

        private void CalculateTotal()
        {
            int total = 0;
            total = (int) basePrice + (pricePerWall * wallAmount) + (labourPrice * wallAmount);
            totalPrice = total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculatePricePerWall();
            CalculateTotal();
            Input_TotalPrice.Text = "£" + totalPrice;
        }

        private void WindowsDemoForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            paintPrice = 0;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            paintPrice = 30;
        }
    }
}
