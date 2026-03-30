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

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            // 선택된 항목만 삭제
            int idx = listBox1.SelectedIndex;
            if (idx >= 0 && idx < listBox1.Items.Count)
            {
                listBox1.Items.RemoveAt(idx);
                UpdateMessageCount();
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelHistory_Click(object sender, EventArgs e)
        {
            // 전체 초기화
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("삭제할 대화 기록이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var res = MessageBox.Show("모든 대화 기록을 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                UpdateMessageCount();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter로 전송
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enter 키의 기본 동작(빕 소리) 방지
                SendMessage();
                return;
            }

            // Ctrl+V(붙여넣기) 처리: 허용 글자수를 넘길 경우 잘라서 붙여넣고 경고 표시
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true; // 기본 붙여넣기 방지
                IDataObject data = Clipboard.GetDataObject();
                if (data != null && data.GetDataPresent(DataFormats.Text))
                {
                    string clip = (string)data.GetData(DataFormats.Text) ?? string.Empty;
                    int selStart = textBox1.SelectionStart;
                    int selLen = textBox1.SelectionLength;
                    int currentLen = textBox1.Text.Length - selLen; // 선택 영역은 대체되므로 빼줌
                    int allowed = textBox1.MaxLength - currentLen;
                    if (allowed <= 0)
                    {
                        MessageBox.Show("입력은 최대 50자까지 허용됩니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string toInsert = clip.Length > allowed ? clip.Substring(0, allowed) : clip;
                    string newText = textBox1.Text.Substring(0, selStart) + toInsert + textBox1.Text.Substring(selStart + selLen);
                    textBox1.Text = newText;
                    textBox1.SelectionStart = selStart + toInsert.Length;

                    if (clip.Length > allowed)
                    {
                        MessageBox.Show("입력은 최대 50자입니다. 초과된 부분은 잘려 저장됩니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                return;
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

            // 안전: 길이 초과 검사 (MaxLength가 있더라도 방어적 체크)
            if (typed_msg.Length > 50)
            {
                MessageBox.Show("메시지는 최대 50자까지 전송할 수 있습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
