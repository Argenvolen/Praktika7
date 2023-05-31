namespace Praktika7
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
            calculateButton = new Button();
            Side1 = new Label();
            Side2 = new Label();
            side1TextBox = new TextBox();
            side2TextBox = new TextBox();
            exitButton = new Button();
            Side3 = new Label();
            side3TextBox = new TextBox();
            resultTextBox = new TextBox();
            buttonClear = new Button();
            button32 = new Button();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(206, 351);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(122, 65);
            calculateButton.TabIndex = 0;
            calculateButton.Text = "Порахувати";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // Side1
            // 
            Side1.AutoSize = true;
            Side1.Location = new Point(68, 37);
            Side1.Name = "Side1";
            Side1.Size = new Size(60, 15);
            Side1.TabIndex = 1;
            Side1.Text = "Сторона1";
            // 
            // Side2
            // 
            Side2.AutoSize = true;
            Side2.Location = new Point(68, 129);
            Side2.Name = "Side2";
            Side2.Size = new Size(60, 15);
            Side2.TabIndex = 2;
            Side2.Text = "Сторона2";
            // 
            // side1TextBox
            // 
            side1TextBox.Location = new Point(68, 75);
            side1TextBox.Name = "side1TextBox";
            side1TextBox.Size = new Size(100, 23);
            side1TextBox.TabIndex = 3;
            side1TextBox.TextChanged += perimeterTextBox_TextChanged;
            // 
            // side2TextBox
            // 
            side2TextBox.Location = new Point(68, 186);
            side2TextBox.Name = "side2TextBox";
            side2TextBox.Size = new Size(100, 23);
            side2TextBox.TabIndex = 4;
            side2TextBox.TextChanged += areaTextBox_TextChanged;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(562, 351);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(124, 65);
            exitButton.TabIndex = 5;
            exitButton.Text = "Заверишити роботу";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Side3
            // 
            Side3.AutoSize = true;
            Side3.Location = new Point(68, 251);
            Side3.Name = "Side3";
            Side3.Size = new Size(60, 15);
            Side3.TabIndex = 6;
            Side3.Text = "Сторона3";
            // 
            // side3TextBox
            // 
            side3TextBox.Location = new Point(68, 303);
            side3TextBox.Name = "side3TextBox";
            side3TextBox.Size = new Size(100, 23);
            side3TextBox.TabIndex = 7;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(206, 60);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(480, 266);
            resultTextBox.TabIndex = 8;
            resultTextBox.TextChanged += textBox1_TextChanged;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(382, 351);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(124, 65);
            buttonClear.TabIndex = 9;
            buttonClear.Text = "Очистити";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // button32
            // 
            button32.Location = new Point(553, 251);
            button32.Name = "button32";
            button32.Size = new Size(124, 65);
            button32.TabIndex = 10;
            button32.Text = "Перехід на другу форму";
            button32.UseVisualStyleBackColor = true;
            button32.Click += button32_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button32);
            Controls.Add(buttonClear);
            Controls.Add(resultTextBox);
            Controls.Add(side3TextBox);
            Controls.Add(Side3);
            Controls.Add(exitButton);
            Controls.Add(side2TextBox);
            Controls.Add(side1TextBox);
            Controls.Add(Side2);
            Controls.Add(Side1);
            Controls.Add(calculateButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private Label Side1;
        private Label Side2;
        private TextBox side1TextBox;
        private TextBox side2TextBox;
        private Button exitButton;
        private Label Side3;
        private TextBox side3TextBox;
        private TextBox resultTextBox;
        private Button buttonClear;
        private Button button32;
    }
}