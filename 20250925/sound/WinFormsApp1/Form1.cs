using System.Media;
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    
    public partial class Form1 : Form
    {
        int a = 0;
        int rnd;
        int b;

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
             a = 0;
            
            buying();
            if (radioButton1.Checked) a += 250;
            if (radioButton2.Checked) a += 250;
            if (radioButton3.Checked) a += 250;
            if (radioButton4.Checked) a += 280;
            if (radioButton5.Checked) a += 250;
            if (radioButton6.Checked) a += 280;
            if (checkBox1.Checked) a = a + a / 10;
            
            if (button1.Enabled == true)
            {
                if (a >= 600) button1.Visible = true;
                else button1.Visible = false;
            }

            label1.Text = "羆基:" + a.ToString();
            if (a>=600) mdfk();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            count();
            pictureBox1.Image = Properties.Resources._1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            count();
            pictureBox1.Image = Properties.Resources._2;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            count();
            pictureBox1.Image = null;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            count();
            pictureBox1.Image = Properties.Resources._3;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            count();
            pictureBox1.Image = Properties.Resources._4;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            count();
            pictureBox1.Image = null;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            count();
            pictureBox1.Image = Properties.Resources._5;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            count();
            pictureBox1.Image = Properties.Resources._6;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            count();
            pictureBox1.Image = null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            count();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random t = new Random();
            b = t.Next(10000000, 99999999);
            button1.Enabled = false;
            if (button1.Enabled == true) return;
            Random r = new Random();
            rnd = r.Next(1, 5);
            mdfk();
        }
        private void mdfk()
        {
            if (rnd == 1)
            {

                SoundPlayer player = new SoundPlayer(Resources._666);


                a = (int)(a * 0.5);
                button1.Text = "5ч";
                label1.Text = "羆基:" + a.ToString();
            }
            if (rnd == 2)
            {
                a = (int)(a * 0.7);
                button1.Text = "7ч";
                label1.Text = "羆基:" + a.ToString();
            }
            if (rnd == 3)
            {
                a = (int)(a * 0.9);
                button1.Text = "9ч";
                label1.Text = "羆基:" + a.ToString();
            }
            if (rnd == 4)
            {

                button1.Text = "皇谅磃臮";
                label1.Text = label1.Text + "肂秘癳ч基ㄩ10じ\r\nч基ㄩ腹:"+b;
            }
        }
    }
}
