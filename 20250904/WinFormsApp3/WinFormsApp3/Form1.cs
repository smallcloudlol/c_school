namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private Timer _timer;  // 定時器，用來每秒偵測 TextBox 內容

        public Form1()
        {
            InitializeComponent();

            // 初始化 ComboBox 選項
            comboBox1.Items.AddRange(new string[] { "+", "-", "*", "/" });
            comboBox1.SelectedIndex = 0;  // 預設選擇加法

            // 初始化定時器，並設置為每秒觸發一次
            _timer = new Timer();
            _timer.Interval = 1000;  // 設置為 1000 毫秒（1秒）
            _timer.Tick += Timer_Tick;
            _timer.Start();  // 啟動定時器
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 表單加載時執行一次檢查
            UpdateButtonState();
        }

        // 每秒檢查 TextBox 的內容並更新按鈕狀態
        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        // 更新按鈕狀態的邏輯
        private void UpdateButtonState()
        {
            // 檢查 TextBox 是否為空，兩者都需要填寫才啟用按鈕
            button1.Enabled = !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text);
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            // 檢查 TextBox 是否為空
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("請填寫所有欄位!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1.Enabled = false;  // 禁用按鈕
                return;
            }

            // 取得 TextBox 中的數字
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int result = 0;

            // 根據 ComboBox 的選擇執行不同的運算
            switch (comboBox1.SelectedItem.ToString())
            {
                case "+":
                    result = a + b;
                    break;

                case "-":
                    result = a - b;
                    break;

                case "*":
                    result = a * b;
                    break;

                case "/":
                    if (b == 0)
                    {
                        MessageBox.Show("除數不能為零!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    result = a / b;
                    break;

                default:
                    MessageBox.Show("無效的運算符!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // 顯示運算結果
            label2.Text = "結果: " + result.ToString();
        }
    }
}
