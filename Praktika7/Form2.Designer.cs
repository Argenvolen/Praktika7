namespace Praktika7
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Side1 = new Label();
            label1 = new Label();
            Side1TextBox = new TextBox();
            Side2TextBox = new TextBox();
            resultTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // Side1
            // 
            Side1.AutoSize = true;
            Side1.Location = new Point(96, 60);
            Side1.Name = "Side1";
            Side1.Size = new Size(60, 15);
            Side1.TabIndex = 2;
            Side1.Text = "Сторона1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 211);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Сторона2";
            // 
            // Side1TextBox
            // 
            Side1TextBox.Location = new Point(96, 124);
            Side1TextBox.Name = "Side1TextBox";
            Side1TextBox.Size = new Size(100, 23);
            Side1TextBox.TabIndex = 4;
            Side1TextBox.TextChanged += Side1TextBox_TextChanged;
            // 
            // Side2TextBox
            // 
            Side2TextBox.Location = new Point(96, 276);
            Side2TextBox.Name = "Side2TextBox";
            Side2TextBox.Size = new Size(100, 23);
            Side2TextBox.TabIndex = 5;
            Side2TextBox.TextChanged += Side1TextBoxSide1TextBox_TextChanged;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(286, 60);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(414, 239);
            resultTextBox.TabIndex = 6;
            resultTextBox.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(286, 343);
            button1.Name = "button1";
            button1.Size = new Size(127, 52);
            button1.TabIndex = 7;
            button1.Text = "Порахувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(575, 343);
            button2.Name = "button2";
            button2.Size = new Size(125, 52);
            button2.TabIndex = 8;
            button2.Text = "Завершити роботу";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(433, 343);
            button3.Name = "button3";
            button3.Size = new Size(126, 52);
            button3.TabIndex = 9;
            button3.Text = "Очистити";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(resultTextBox);
            Controls.Add(Side2TextBox);
            Controls.Add(Side1TextBox);
            Controls.Add(label1);
            Controls.Add(Side1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Side1;
        private Label label1;
        private TextBox Side1TextBox;
        private TextBox Side2TextBox;
        private TextBox resultTextBox;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}