namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // �q�{��ܥ[�k
            radioButton1.Checked = true;
        }

        // �� textBox1 �� textBox2 ���e���ܮɡA��s���G
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            int num1, num2;
            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                int result = PerformCalculation(num1, num2);
                label1.Text = result.ToString(); // ��ܭp�⵲�G
            }
            else
            {
                label1.Text = "�п�J���Ī��Ʀr";
            }
        }

        // �ھڿ�ܪ��B��Ŷi��p��
        private int PerformCalculation(int num1, int num2)
        {
            if (radioButton1.Checked) // �[�k
            {
                return num1 + num2;
            }
            else if (radioButton2.Checked) // ��k
            {
                return num1 - num2;
            }
            else if (radioButton3.Checked) // ���k
            {
                return num1 * num2;
            }
            else if (radioButton4.Checked) // ���k
            {
                if (num2 == 0)
                {
                    MessageBox.Show("���Ƥ��ର 0�I", "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                return num1 / num2;
            }
            else
            {
                MessageBox.Show("�п�ܤ@�ӹB��Ÿ��C", "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        // ��s label2 �M label3 ���奻�A�íp�⵲�G
        private void UpdateLabelsAndCalculate(string label2Text, string label3Text)
        {
            label2.Text = label2Text;
            label3.Text = label3Text;

            int num1, num2;
            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                int result = PerformCalculation(num1, num2);
                label1.Text = result.ToString(); // ��ܭp�⵲�G
            }
        }

        // ���ܥ[�k�B���
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelsAndCalculate("�[��", "�[��");
        }

        // ���ܴ�k�B���
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelsAndCalculate("�Q���", "���");
        }

        // ���ܭ��k�B���
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelsAndCalculate("�Q����", "����");
        }

        // ���ܰ��k�B���
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelsAndCalculate("�Q����", "����");
        }

        // �� textBox1 ���e�ܤƮ�
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // �����ե� PerformCalculation
            int num1, num2;
            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                int result = PerformCalculation(num1, num2);
                label1.Text = result.ToString(); // ��ܭp�⵲�G
            }
            else
            {
                label1.Text = "�п�J���Ī��Ʀr";
            }
        }

        // �� textBox2 ���e�ܤƮ�
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            int num1, num2;

            // ���ձN textBox1 �M textBox2 �����ഫ�����
            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                // �ھ� textBox2 ���ȨӨM�w�O�_�ҥΰ��k�ﶵ
                if (num2 == 0)
                {
                    radioButton4.Enabled = false; // �T�ΰ��k�ﶵ
                }
                else
                {
                    radioButton4.Enabled = true; // �ҥΰ��k�ﶵ
                }

                // �p�����ܵ��G
                int result = PerformCalculation(num1, num2);
                label1.Text = result.ToString(); // ��ܭp�⵲�G
            }
            else
            {
                // �p�G���@�өΨ�Ӥ奻�ؤ����Ʀr�L�ġA��ܿ��~�H��
                label1.Text = "�п�J���Ī��Ʀr";
            }
        }
    }
}
