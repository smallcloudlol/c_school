namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button2.Text = "Y";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Text = "N";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            MessageBox.Show("按三小", "手很賤阿", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
