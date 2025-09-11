namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private Timer _timer;  // �w�ɾ��A�ΨӨC���� TextBox ���e

        public Form1()
        {
            InitializeComponent();

            // ��l�� ComboBox �ﶵ
            comboBox1.Items.AddRange(new string[] { "+", "-", "*", "/" });
            comboBox1.SelectedIndex = 0;  // �w�]��ܥ[�k

            // ��l�Ʃw�ɾ��A�ó]�m���C��Ĳ�o�@��
            _timer = new Timer();
            _timer.Interval = 1000;  // �]�m�� 1000 �@��]1��^
            _timer.Tick += Timer_Tick;
            _timer.Start();  // �Ұʩw�ɾ�
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ���[���ɰ���@���ˬd
            UpdateButtonState();
        }

        // �C���ˬd TextBox �����e�ç�s���s���A
        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        // ��s���s���A���޿�
        private void UpdateButtonState()
        {
            // �ˬd TextBox �O�_���šA��̳��ݭn��g�~�ҥΫ��s
            button1.Enabled = !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text);
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            // �ˬd TextBox �O�_����
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("�ж�g�Ҧ����!", "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1.Enabled = false;  // �T�Ϋ��s
                return;
            }

            // ���o TextBox �����Ʀr
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int result = 0;

            // �ھ� ComboBox ����ܰ��椣�P���B��
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
                        MessageBox.Show("���Ƥ��ର�s!", "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    result = a / b;
                    break;

                default:
                    MessageBox.Show("�L�Ī��B���!", "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // ��ܹB�⵲�G
            label2.Text = "���G: " + result.ToString();
        }
    }
}
