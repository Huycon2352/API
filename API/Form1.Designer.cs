namespace API
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
            textBox1 = new TextBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(241, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 27);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(418, 162);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Push";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ButtonHighlight;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(92, 208);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(659, 220);
            richTextBox1.TabIndex = 3;
            richTextBox1.TabStop = false;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(276, 18);
            label1.Name = "label1";
            label1.Size = new Size(276, 41);
            label1.TabIndex = 4;
            label1.Text = "Hello Im Mr smart";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 69);
            label2.Name = "label2";
            label2.Size = new Size(375, 20);
            label2.TabIndex = 5;
            label2.Text = "I can give u some information about a City or a Country";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 166);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 6;
            label3.Text = "Enter city or Country";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
