namespace Tyuiu.SilinEV.Sprint6.Task0.V20
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 37);
            label1.TabIndex = 0;
            label1.Text = "Введите х";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(153, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 43);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 160);
            button1.Name = "button1";
            button1.Size = new Size(87, 27);
            button1.TabIndex = 2;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Формула;
            pictureBox1.Location = new Point(12, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 56);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(112, 92);
            label2.Name = "label2";
            label2.Size = new Size(35, 37);
            label2.TabIndex = 5;
            label2.Text = "=";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(153, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 43);
            textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 206);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Спринт 6 | Таск0 | Вариант 20 | Силин Е. В.|";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox2;
    }
}
