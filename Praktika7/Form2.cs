using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika7
{
    public partial class Form2 : Form
    {
        private Rectangle rectangle;
        public Form2()
        {
            InitializeComponent();
            rectangle = new Rectangle(0, 0);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float Side1, Side2;
            if (float.TryParse(Side1TextBox.Text, out Side1) &&
                float.TryParse(Side2TextBox.Text, out Side2))
            {
                rectangle = new Rectangle(Side1, Side2);
                float perimeter = rectangle.PerimeterR();
                float area = rectangle.AreaR();

                resultTextBox.Text = $"Perimeter: {perimeter}\r\nArea: {area}";
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid side lengths.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Side1TextBox.Clear();
            Side2TextBox.Clear();
            resultTextBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Side1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Side1TextBoxSide1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
