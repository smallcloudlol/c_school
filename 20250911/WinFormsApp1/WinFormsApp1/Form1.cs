namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d, e1, f, g;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);
            d = a; f = b;
            g = a / 10;
            if (g > b / 2) g = b / 2;
            e1 = g + c;
            label4.Text = Convert.ToString(d) + "�ӻ氮�A " + Convert.ToString(e1) + "�����J�O�A" + Convert.ToString(f) + "�ӳJ�|�C";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
