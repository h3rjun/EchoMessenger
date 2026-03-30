namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string typed_msg;

                typed_msg = textBox1.Text;
                string result = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} {typed_msg}";

                listBox1.Items.Add(result);
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}
