namespace Calculator
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double number1 = 0;
            double number2 = 0;

            bool ok1 = double.TryParse(tx1.Text, out number1);
            bool ok2= double.TryParse(tx2.Text, out number2);

            if(!ok1 || !ok2)
            {
                MessageBox.Show("Incorrect number provided");
                return;
            }

            string ope = txoperator.Text;

            if(!string.IsNullOrEmpty(ope))
            {
                switch(ope)
                {
                    case "+":
                        lblResult.Text = (number1 + number2).ToString();
                        break;
                    case "-":
                        lblResult.Text = (number1 - number2).ToString();
                        break;
                    case "*":
                        lblResult.Text = (number1 * number2).ToString();
                        break;
                    case "/":
                        if(number2 != 0)
                        {
                            lblResult.Text = (number1 / number2).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Division by 0 is not allowed!");
                            tx2.Text = " ";
                            return;
                        }
                            break;

                    default:
                        lblResult.Text = "Unknown operator!";
                        break;
                }
            }
        }
    }
}
