namespace Calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn9.Text;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn8.Text;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn7.Text;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn6.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn5.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn4.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn3.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn2.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn1.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtValue.Text += btn0.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.Length == 0)
                return;
            txtValue.Text = txtValue.Text.Substring(0, txtValue.Text.Length - 1);
        }
        private void btnPercentage_Click(object sender, EventArgs e)
        {
            double value;

            if (double.TryParse(txtValue.Text, out value))
            {
                value = value / 100;
                txtValue.Text = value.ToString();
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.Length == 0)
                return;

            if (txtValue.Text.EndsWith("+") || txtValue.Text.EndsWith("-"))
                return;

            txtValue.Text += btnSubtract.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.Length == 0)
                return;

            if (txtValue.Text.EndsWith("+") || txtValue.Text.EndsWith("-"))
                return;

            txtValue.Text += btnPlus.Text;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtValue.Text)) return;

            try
            {
                string expression = txtValue.Text
                                        .Replace(" ", "");

                if (expression.Contains("/0"))
                {
                    MessageBox.Show("ไม่สามารถหารด้วยศูนย์ได้", "ข้อผิดพลาด");
                    return;
                }

                var result = new System.Data.DataTable().Compute(expression, null);

                txtValue.Text = result.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("รูปแบบตัวเลขไม่ถูกต้อง", "ข้อผิดพลาด");
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.Length == 0)
            {
                txtValue.Text += "0.";
                return;
            }

            // Check if the last character is an operator
            if (txtValue.Text.EndsWith("+") || txtValue.Text.EndsWith("-"))
            {
                txtValue.Text += "0.";
                return;
            }

            txtValue.Text += btnDecimal.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Clear();
        }
    }
}
