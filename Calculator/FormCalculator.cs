namespace Calculator
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        string command = "";
        double num1, num2;

        private void FormCalculator_Load(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            inputTextBox.Clear();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length < 11) { inputTextBox.Text += "1"; }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length < 11) { inputTextBox.Text += "2"; }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length < 11) { inputTextBox.Text += "3"; }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length < 11) { inputTextBox.Text += "4"; }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length < 11) { inputTextBox.Text += "5"; }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length < 11) { inputTextBox.Text += "6"; }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length < 11) { inputTextBox.Text += "7"; }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length < 11) { inputTextBox.Text += "8"; }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length < 11) { inputTextBox.Text += "9"; }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length < 11)
            {
                inputTextBox.Text += "0";
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length > 0)
            {
                inputTextBox.Text = inputTextBox.Text.Remove(inputTextBox.Text.Length - 1);
            }
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length > 0 && !inputTextBox.Text.Contains(','))
            {
                inputTextBox.Text += ",";
            }
        }

        private void button_sign_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length > 0)
            {
                inputTextBox.Text = Convert.ToString(Convert.ToDouble(inputTextBox.Text) * (-1));
            }
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            outputTextBox.Clear();
            command = "";
            num1 = 0;
            num2 = 0;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length > 0 && outputTextBox.Text.Length == 0)
            {
                try
                {
                    num1 = Convert.ToDouble(inputTextBox.Text);
                    command = "+";
                    outputTextBox.Text = num1.ToString() + " + ";
                    inputTextBox.Clear();
                }
                catch
                {
                    MessageBox.Show("Неккоректное число!");
                    inputTextBox.Clear();
                }
            }
        }

        private void button_subtraction_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length > 0 && outputTextBox.Text.Length == 0)
            {
                try
                {
                    num1 = Convert.ToDouble(inputTextBox.Text);
                    command = "-";
                    outputTextBox.Text = num1.ToString() + " - ";
                    inputTextBox.Clear();
                }
                catch
                {
                    MessageBox.Show("Неккоректное число!");
                    inputTextBox.Clear();
                }
            }
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length > 0 && outputTextBox.Text.Length == 0)
            {
                try
                {
                    num1 = Convert.ToDouble(inputTextBox.Text);
                    command = "x";
                    outputTextBox.Text = num1.ToString() + " x ";
                    inputTextBox.Clear();
                }
                catch
                {
                    MessageBox.Show("Неккоректное число!");
                    inputTextBox.Clear();
                }
            }
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length > 0 && outputTextBox.Text.Length == 0)
            {
                try
                {
                    num1 = Convert.ToDouble(inputTextBox.Text);
                    command = "÷";
                    outputTextBox.Text = num1.ToString() + " ÷ ";
                    inputTextBox.Clear();
                }
                catch
                {
                    MessageBox.Show("Неккоректное число!");
                    inputTextBox.Clear();
                }
            }
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length > 0 && outputTextBox.Text.Length > 0)
            {
                try
                {
                    num2 = Convert.ToDouble(inputTextBox.Text);
                    double result = calculation(num1, num2, command);
                    if (errorZero != 1)
                    {
                        inputTextBox.Text = result.ToString();
                    }
                    else
                    {
                        outputTextBox.Text = "Деление на ноль!";
                        inputTextBox.Clear();
                        errorZero = 0;
                        return;
                    }
                    outputTextBox.Clear();
                }
                catch
                {
                    MessageBox.Show("Неккоректное число!");
                    inputTextBox.Clear();
                }
            }
        }

        int errorZero = 0;
        private double calculation(double num1, double num2, string command)
        {
            double result = 0;
            switch (command)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "x":
                    result = num1 * num2;
                    break;
                case "÷":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        result = 0;
                        errorZero = 1;
                    }
                    break;
            }
            return result;
        }
    }
}