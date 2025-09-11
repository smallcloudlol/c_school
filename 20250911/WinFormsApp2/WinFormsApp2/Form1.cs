namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 默認選擇加法
            radioButton1.Checked = true;
        }

        // 當 textBox1 或 textBox2 內容改變時，更新結果
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            int num1, num2;
            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                int result = PerformCalculation(num1, num2);
                label1.Text = result.ToString(); // 顯示計算結果
            }
            else
            {
                label1.Text = "請輸入有效的數字";
            }
        }

        // 根據選擇的運算符進行計算
        private int PerformCalculation(int num1, int num2)
        {
            if (radioButton1.Checked) // 加法
            {
                return num1 + num2;
            }
            else if (radioButton2.Checked) // 減法
            {
                return num1 - num2;
            }
            else if (radioButton3.Checked) // 乘法
            {
                return num1 * num2;
            }
            else if (radioButton4.Checked) // 除法
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

        // 更新 label2 和 label3 的文本，並計算結果
        private void UpdateLabelsAndCalculate(string label2Text, string label3Text)
        {
            label2.Text = label2Text;
            label3.Text = label3Text;

            int num1, num2;
            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                int result = PerformCalculation(num1, num2);
                label1.Text = result.ToString(); // 顯示計算結果
            }
        }

        // 當選擇加法運算時
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelsAndCalculate("加數", "加數");
        }

        // 當選擇減法運算時
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelsAndCalculate("被減數", "減數");
        }

        // 當選擇乘法運算時
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelsAndCalculate("被乘數", "乘數");
        }

        // 當選擇除法運算時
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelsAndCalculate("被除數", "除數");
        }

        // 當 textBox1 內容變化時
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // 直接調用 PerformCalculation
            int num1, num2;
            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                int result = PerformCalculation(num1, num2);
                label1.Text = result.ToString(); // 顯示計算結果
            }
            else
            {
                label1.Text = "請輸入有效的數字";
            }
        }

        // 當 textBox2 內容變化時
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            int num1, num2;

            // 嘗試將 textBox1 和 textBox2 的值轉換為整數
            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                // 根據 textBox2 的值來決定是否啟用除法選項
                if (num2 == 0)
                {
                    radioButton4.Enabled = false; // 禁用除法選項
                }
                else
                {
                    radioButton4.Enabled = true; // 啟用除法選項
                }

                // 計算並顯示結果
                int result = PerformCalculation(num1, num2);
                label1.Text = result.ToString(); // 顯示計算結果
            }
            else
            {
                // 如果有一個或兩個文本框中的數字無效，顯示錯誤信息
                label1.Text = "請輸入有效的數字";
            }
        }
    }
}
