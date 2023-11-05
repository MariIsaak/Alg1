namespace Alg
{
    partial class FormA3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA3));
            label1 = new Label();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 92);
            label1.Name = "label1";
            label1.Size = new Size(296, 33);
            label1.TabIndex = 2;
            label1.Text = "Нитевидная сортировка";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Strand sort (нитевидная сортировка) - это один из алгоритмов сортировки, который использует принцип разделения и слияния. ", "Он получил свое название от аналогии с процессом уплетения нитей, где одна нить \"встраивается\" в другую. Алгоритм нитевидной сортировки работает следующим образом:", "", "1. Начните с пустого \"результата\" массива.", resources.GetString("listBox1.Items"), "3. Когда текущая нить завершена (все элементы добавлены), объедините эту нить с \"результатом\".", "4. Повторяйте шаги 2-3, пока не пройдете по всем элементам исходного массива.", "5. Теперь у вас есть первый отсортированный подмассив. Повторяйте процесс с оставшимися нитями, пока все они не будут объединены в один отсортированный массив.", "", "Нитевидная сортировка обычно используется для сортировки связанных списков, где она может быть более эффективной, чем на массивах.", "Время выполнения нитевидной сортировки может быть сравнимо с временем выполнения других алгоритмов сортировки, и оно зависит от структуры данных и входных данных.", "", "", "Общая сложность нитевидной сортировки может варьироваться в зависимости от конкретных условий, но она часто составляет O(n^2), что делает этот алгоритм не самым быстрым. ", resources.GetString("listBox1.Items1"), "", resources.GetString("listBox1.Items2") });
            listBox1.Location = new Point(12, 240);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 264);
            listBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sort_strand;
            pictureBox1.Location = new Point(396, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(358, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormA3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 548);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "FormA3";
            Text = "Нитевидная сортировка";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
    }
}