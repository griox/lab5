namespace _5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_click;
            button2.Click += Button2_close;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private double PTbac1(double a, double b)
        {
            if (a == 0)
            {
                MessageBox.Show("loi tham so");
                return double.NaN;
            }
            else
            {
                return -b / a;
            }
        }
        private string PTbac2(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            if(delta < 0)
            {
                return "Phuong trinh vo nghiem";
            }
            else if(delta == 0)
            {
                return $"Phuong trinh co nghiem kep x = {-b/2*a}";
            }
            else if(delta > 0)
            {
                double x1 = (-b+Math.Sqrt(delta)/(2*a));
                double x2 = (-b - Math.Sqrt(delta) / (2 * a));
                return $"x1 ={x1}        x2 ={x2} ";
            }
            else
            {
                return "nhap sai dinh dang ";
            }
        }
        private void Button1_click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                if(double.TryParse(textBox1.Text, out double a) &&double.TryParse(textBox2.Text, out double b))
                {
                    double kq = PTbac1(a, b);
                    textBox4.Text = $"Phuong trinh bac nhat x = {kq}";
                }
                else
                {
                    MessageBox.Show("nhap sai dinh dang he so");
                }
            }
            if(radioButton2.Checked)
            {
                if (double.TryParse(textBox1.Text, out double a) && double.TryParse(textBox2.Text, out double b) && double.TryParse(textBox3.Text,out double c))
                {
                    string kq = PTbac2(a, b, c);
                    textBox4.Text = kq;
                   
                }
            }
        }
        private void Button2_close(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co chac dong ung dung", "xac nhan dong ung dung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
           
        }
        
    }
}
