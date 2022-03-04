namespace calc
{
    public partial class Form1 : Form
    {
        public TextBox ActiveTextBox { get; set; }
        private double num1;
        private double num2; 
        public double answer { get; set; }

        public Form1()
        {
            InitializeComponent();
            ActiveTextBox = this.txt1st;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txt1st.Text, out num1))
            {
                MessageBox.Show("נא להכניס מספר גדול מ-0");
            }
            if (!double.TryParse(txt2nd.Text, out num2))
            {
                MessageBox.Show("נא להכניס מספר גדול מ-0");
            }
            switch (lbl_opr.Text)
            {
                case "+":
                    txtAnswer.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    txtAnswer.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    txtAnswer.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    txtAnswer.Text = (num1 / num2).ToString();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "1";
        }

        private void txt1st_Enter(object sender, EventArgs e)
        {
            ActiveTextBox = sender as TextBox;
        }

        private void txtAction_Enter(object sender, EventArgs e)
        {
            ActiveTextBox = sender as TextBox;
        }

        private void btn_num2_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "2";
        }

        private void btn_num3_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "3";
        }

        private void btn_num4_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "4";
        }

        private void btn_num5_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "5";
        }

        private void btn_num6_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "6";
        }

        private void btn_num7_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "7";
        }

        private void btn_num8_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "8";
        }

        private void btn_num9_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "9";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            this.lbl_opr.Text = "+";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            this.lbl_opr.Text = "-";
        }

        private void btn_nultiply_Click(object sender, EventArgs e)
        {
            this.lbl_opr.Text = "*";
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            this.lbl_opr.Text = "/";
        }

        private void txt2nd_Enter(object sender, EventArgs e)
        {
            ActiveTextBox = sender as TextBox;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}