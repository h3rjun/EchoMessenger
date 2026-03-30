using System;
using System.Windows.Forms;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateMessageCount();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enter 키의 기본 동작(빕 소리) 방지
                SendMessage();
            }
        }

        private void SendMessage()
        {
            // 앞뒤 불필요한 공백 제거
            string typed_msg = textBox1.Text?.Trim() ?? string.Empty;
            if (typed_msg.Length == 0)
            {
                // 빈 문자열(또는 공백만)인 경우 전송 방지
                return;
            }

            // 타임스탬프 추가: [HH:mm:ss]
            string result = $"[{DateTime.Now:HH:mm:ss}] {typed_msg}";

            listBox1.Items.Add(result);

            // 메시지 카운트 업데이트
            UpdateMessageCount();

            // 입력창 비우고 포커스 유지
            textBox1.Clear();
            textBox1.Focus();
        }

        private void UpdateMessageCount()
        {
            labelCount.Text = $"메시지 수: {listBox1.Items.Count}";
        }
    }
}
