namespace Alg
{
    partial class FormA1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA1));
            listBox1 = new ListBox();
            label1 = new Label();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { resources.GetString("listBox1.Items"), "", "Процесс сортировки перемешиванием выглядит следующим образом:", "", "Начинается сортировка с левой части массива.", "Проходим массив слева направо, сравнивая пары соседних элементов. Если текущий элемент больше следующего, меняем их местами.", "Переходим к правой части массива.", "Проходим массив справа налево, снова сравнивая и меняя элементы при необходимости.", "Повторяем шаги 1-4 до тех пор, пока не будет выполнено ни одно обмена элементов во время прохода по массиву.", "Массив считается отсортированным.", "Сортировка перемешиванием получила свое имя из-за аналогии с \"перемешиванием\" элементов в массиве, когда они \"перемешиваются\" и \"поднимаются\" на свои позиции в процессе сортировки.", "", resources.GetString("listBox1.Items1"), "", resources.GetString("listBox1.Items2") });
            listBox1.Location = new Point(12, 252);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 264);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 112);
            label1.Name = "label1";
            label1.Size = new Size(368, 33);
            label1.TabIndex = 1;
            label1.Text = "Сортировка перемешиванием";
            label1.Click += label1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.c703276ad071329e7d867facdf20e4bb;
            pictureBox1.Location = new Point(421, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FormA1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 548);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "FormA1";
            Text = "Сортировка перемешиванием";
            Load += FormA1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
    }
}