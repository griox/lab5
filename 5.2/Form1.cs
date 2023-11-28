namespace _5._2
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
        private void Button_thuchien(object sender, EventArgs e)
        {
            if(!double.TryParse(textBox1.Text, out double a))
            {
                MessageBox.Show("khong hop le ");
                return;
            }
        }
    }
}
