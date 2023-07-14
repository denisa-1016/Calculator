namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string option;
        int num1;
        int num2;
        int result;

        private void button1_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button2.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button3.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button4.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button6.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button7.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button8.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button9.Text;

        }

        private void button0_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + button0.Text;

        }

        private void plus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txt.Text);
            txt.Clear();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txt.Text);
            txt.Clear();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txt.Text);
            txt.Clear();
        }

        private void devide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txt.Text);
            txt.Clear();
        }

        private void egal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txt.Text);

            if (option == "+")
            {
                result = num1 + num2;
            }

            if (option == "-")
            {
                result = num1 - num2;
            }

            if (option == "*")
            {
                result = num1 * num2;
            }

            if (option == "/")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    MessageBox.Show("Error: Division by zero is not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            txt.Text = result.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt.Clear();
            num1 = 0;
            num2 = 0;
            result = 0;
        }
    }
}