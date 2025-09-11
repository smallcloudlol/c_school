namespace WinFormsApp3
{//簡易計算機 20250904
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            if(String.IsNullOrEmpty(textBox1.Text))
                 label3.Text = "空字串"; 
            else
            {
                int a, b;
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                label3.Text = Convert.ToString(a + b);
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            label3.Text =Convert.ToString(a-b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            label3.Text = Convert.ToString(a * b);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            label3.Text = Convert.ToString(a / b);
        }
    }
}
