namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSend = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Chartreuse;
            btnSend.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnSend.Location = new Point(603, 342);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(146, 78);
            btnSend.TabIndex = 0;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("맑은 고딕", 20.25F);
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "첫번째 줄", "두번째 줄", "세번째 줄" });
            listBox1.Location = new Point(34, 93);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(715, 226);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(394, 50);
            label1.TabIndex = 3;
            label1.Text = "📸 Echo Messenger";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            textBox1.Location = new Point(34, 367);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(541, 35);
            textBox1.TabIndex = 4;
            textBox1.Text = "여기에 메시지 입력하세요";
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(btnSend);
            Name = "Form1";
            Text = "Echo Messenger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private ListBox listBox1;
        private Label label1;
        private TextBox textBox1;
    }
}
