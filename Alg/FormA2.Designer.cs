namespace Alg
{
    partial class FormA2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA2));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 100);
            label1.Name = "label1";
            label1.Size = new Size(283, 33);
            label1.TabIndex = 2;
            label1.Text = "Гибридная сортировка";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = Properties.Resources.d9bc1db0358174dae769d5ca0e89ca77;
            pictureBox1.Location = new Point(382, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._0b3cee866fc270233e94e7aa94403e6e1111;
            pictureBox2.Location = new Point(578, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(162, 186);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Гибридная сортировка - это комбинированный метод сортировки, который объединяет два или более ", "алгоритма сортировки для достижения лучших результатов в разных ситуациях. Идея заключается в том, чтобы использовать ", "один алгоритм сортировки для определенных условий или размеров входных данных и переключаться на другой алгоритм для других условий.", "", resources.GetString("listBox1.Items"), "", "", "Общая идея гибридной сортировки Insertion Sort и Quick Sort следующая:", "1. Проверьте размер входного массива. Если он меньше порогового значения, используйте сортировку вставками.", "2. Если размер массива больше порогового значения, примените быструю сортировку.", "3. В случае быстрой сортировки, выберите опорный элемент (пивот) и разделите массив на две части.", "4. Рекурсивно применяйте гибридную сортировку к обеим частям массива.", "5. Когда размер части становится меньше порогового значения, примените сортировку вставками к этой части.", "", "Гибридная сортировка Insertion Sort и Quick Sort представляет собой компромисс между эффективностью сортировки в малых и больших массивах.", "", resources.GetString("listBox1.Items1"), "", resources.GetString("listBox1.Items2") });
            listBox1.Location = new Point(12, 242);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 264);
            listBox1.TabIndex = 5;
            // 
            // FormA2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 548);
            Controls.Add(listBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "FormA2";
            RightToLeftLayout = true;
            Text = "Гибридная сортировка";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ListBox listBox1;
    }
}