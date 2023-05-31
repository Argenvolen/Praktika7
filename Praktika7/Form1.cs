namespace Praktika7
{
    public partial class Form1 : Form
    {
        private Triangle triangle;
        public Form1()
        {
            InitializeComponent();
            triangle = new Triangle(0, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            float side1, side2, side3;
            if (float.TryParse(side1TextBox.Text, out side1) &&
                float.TryParse(side2TextBox.Text, out side2) &&
                float.TryParse(side3TextBox.Text, out side3))
            {
                triangle = new Triangle(side1, side2, side3);
                float perimeter = triangle.Perimeter();
                float area = triangle.Area();

                resultTextBox.Text = $"Perimeter: {perimeter}\r\nArea: {area}";
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid side lengths.");
            }
        }
        private void areaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void perimeterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            side1TextBox.Clear();
            side2TextBox.Clear();
            side3TextBox.Clear();
            resultTextBox.Clear();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}