namespace lab11
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
            button1 = new Button();
            button2 = new Button();
            vScrollBar1 = new VScrollBar();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 34);
            button1.Name = "button1";
            button1.Size = new Size(191, 29);
            button1.TabIndex = 0;
            button1.Text = "Вычисление в цикле";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 79);
            button2.Name = "button2";
            button2.Size = new Size(191, 29);
            button2.TabIndex = 1;
            button2.Text = "Вычисление по формуле";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(218, 9);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 125);
            vScrollBar1.TabIndex = 4;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 27);
            textBox1.TabIndex = 5;
            textBox1.Text = "Ответ";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 38);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 6;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(vScrollBar1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private VScrollBar vScrollBar1;
        private TextBox textBox1;
        private Label label1;
    }
}
