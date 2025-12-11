namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton9.Checked = true;
            radioButton8.Checked = true;
            radioButton7.Checked = true;
            buying();
            count();
        }
        private void buying()
        {
            if (radioButton9.Checked && radioButton8.Checked && radioButton7.Checked)
            {
                checkBox1.Enabled = false;
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Enabled = true;
            }
        }
        private void count()
        {
            buying();
            int a = 0;
            if (radioButton1.Checked) a += 250;
            if (radioButton2.Checked) a += 250;
            if (radioButton3.Checked) a += 250;
            if (radioButton4.Checked) a += 280;
            if (radioButton5.Checked) a += 250;
            if (radioButton6.Checked) a += 280;
            if (checkBox1.Checked) a = a + a / 10;
            label1.Text = "Á`»ù:" + a.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            count();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            count();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            count();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            count();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            count();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            count();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            count();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            count();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            count();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            count();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
