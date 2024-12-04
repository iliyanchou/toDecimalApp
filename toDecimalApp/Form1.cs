
namespace toDecimalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nBaseIn.Text) )
            {
                Number inNum = new Number();
                inNum.system = (int)n.Value;
                inNum.number = nBaseIn.Text;
                inNum.lenght = nBaseIn.TextLength;
                DecimalOut.Text = Convert.ToString(inNum.getDecimal());

            }
        }
    }
}
