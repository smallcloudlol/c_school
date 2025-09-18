namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            radioButton3.Checked = true;
            textBox1.Text = "10";
            textBox2.Text = "2";
        }

        
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            int num1, num2;
            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                int result = PerformCalculation(num1, num2);
                label1.Text = result.ToString(); 
            }
            else
            {
                label1.Text = "Error";
            }
        }

        
        private int PerformCalculation(int num1, int num2)
        {
            if (radioButton1.Checked) 
            {
                return num1 + num2;
            }
            else if (radioButton2.Checked) 
            {
                return num1 - num2;
            }
            else if (radioButton3.Checked) 
            {
                return num1 * num2;
            }
            else if (radioButton4.Checked) 
            {
                if (num2 == 0)
                {
                    MessageBox.Show("除數不能為 0！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                return num1 / num2;
            }
            else
            {
                MessageBox.Show("請選擇一個運算符號。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        
        private void UpdateLabelsAndCalculate(string label2Text, string label3Text)
        {
            label2.Text = label2Text;
            label3.Text = label3Text;

            int num1, num2;
            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                int result = PerformCalculation(num1, num2);
                label1.Text = result.ToString(); 
            }
        }

       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelsAndCalculate("加數", "加數");
        }

        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelsAndCalculate("被減數", "減數");
        }

        
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelsAndCalculate("被乘數", "乘數");
        }

       
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelsAndCalculate("被除數", "除數");
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            int num1, num2;
            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                int result = PerformCalculation(num1, num2);
                label1.Text = result.ToString(); 
            }
            else
            {
                label1.Text = "請輸入有效的數字";
            }
        }

        
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            int num1, num2;

            
            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                
                if (num2 == 0)
                {
                    radioButton4.Enabled = false; 
                }
                else
                {
                    radioButton4.Enabled = true; 
                }

                int result = PerformCalculation(num1, num2);
                label1.Text = result.ToString(); 
            }
            else
            {
                label1.Text = "Error";
            }
        }
    }
}
