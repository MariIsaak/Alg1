namespace Alg
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
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 169);
            button1.Name = "button1";
            button1.Size = new Size(221, 36);
            button1.TabIndex = 1;
            button1.Text = "Сгенероровать массив";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(236, 68);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(79, 27);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(218, 22);
            label1.TabIndex = 3;
            label1.Text = "Введите размер массива";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 120);
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Horizontal;
            textBox1.Size = new Size(291, 27);
            textBox1.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 30);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(245, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Сортировка перемешиванием";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 75);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(192, 24);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "Гибридная сортировка";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 120);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(200, 24);
            checkBox3.TabIndex = 8;
            checkBox3.Text = "Нитевидная сортировка";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Location = new Point(364, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 160);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выберите:";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Location = new Point(364, 191);
            button2.Name = "button2";
            button2.Size = new Size(122, 32);
            button2.TabIndex = 10;
            button2.Text = "Сортировать";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(44, 253);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(956, 324);
            listBox1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_clipart_computer_icons_question_mark_others_miscellaneous_cdr;
            pictureBox1.Location = new Point(938, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.png_clipart_computer_icons_question_mark_others_miscellaneous_cdr;
            pictureBox2.Location = new Point(938, 91);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.png_clipart_computer_icons_question_mark_others_miscellaneous_cdr;
            pictureBox3.Location = new Point(938, 136);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.ControlLightLight;
            progressBar1.ForeColor = SystemColors.MenuHighlight;
            progressBar1.Location = new Point(638, 50);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(201, 29);
            progressBar1.TabIndex = 15;
            progressBar1.Click += progressBar1_Click;
            // 
            // progressBar2
            // 
            progressBar2.BackColor = SystemColors.ControlLightLight;
            progressBar2.Location = new Point(638, 95);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(201, 29);
            progressBar2.TabIndex = 16;
            progressBar2.Click += progressBar2_Click;
            // 
            // progressBar3
            // 
            progressBar3.BackColor = SystemColors.ControlLightLight;
            progressBar3.Location = new Point(638, 145);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(201, 29);
            progressBar3.TabIndex = 17;
            progressBar3.Click += progressBar3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(845, 56);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 18;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(845, 100);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 19;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(845, 149);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 20;
            label4.Text = "label4";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Location = new Point(638, 191);
            button3.Name = "button3";
            button3.Size = new Size(184, 32);
            button3.TabIndex = 21;
            button3.Text = "Сравнительный анализ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1037, 606);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Тренажер алгоритмов";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private GroupBox groupBox1;
        private Button button2;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
    }
}