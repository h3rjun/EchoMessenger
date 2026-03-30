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
            labelCount = new Label();
            btnDelHistory = new Button();
            btnDeleteSelected = new Button();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Chartreuse;
            btnSend.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnSend.Location = new Point(603, 374);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(146, 53);
            btnSend.TabIndex = 0;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("맑은 고딕", 20.25F);
            listBox1.FormattingEnabled = true;
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
            textBox1.Location = new Point(34, 374);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(550, 35);
            textBox1.TabIndex = 4;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            labelCount.Location = new Point(581, 14);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(128, 30);
            labelCount.TabIndex = 5;
            labelCount.Text = "메시지 수: 0";
            // 
            // btnDelHistory
            // 
            btnDelHistory.BackColor = Color.NavajoWhite;
            btnDelHistory.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnDelHistory.Location = new Point(581, 49);
            btnDelHistory.Name = "btnDelHistory";
            btnDelHistory.Size = new Size(168, 36);
            btnDelHistory.TabIndex = 6;
            btnDelHistory.Text = "대화 기록 삭제";
            btnDelHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnDelHistory.UseVisualStyleBackColor = false;
            btnDelHistory.Click += btnDelHistory_Click;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.BackColor = Color.LightCoral;
            btnDeleteSelected.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnDeleteSelected.Location = new Point(603, 326);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(146, 42);
            btnDeleteSelected.TabIndex = 7;
            btnDeleteSelected.Text = "삭제";
            btnDeleteSelected.UseVisualStyleBackColor = false;
            btnDeleteSelected.Click += btnDeleteSelected_Click;
            // 
            // Form1
            // 
            AcceptButton = btnSend;
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteSelected);
            Controls.Add(btnDelHistory);
            Controls.Add(labelCount);
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
        private Label labelCount;
        private Button btnDelHistory;
        private Button btnDeleteSelected;
    }
}
