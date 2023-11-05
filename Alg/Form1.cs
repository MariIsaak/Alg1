using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Alg
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        int[] mas;
        int[] mas1;
        int[] mas2;
        int n;
        Random ran = new Random();


        public Form1()
        {
            InitializeComponent();
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Horizontal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(textBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = (int)this.numericUpDown1.Value;
            mas = new int[n];
            mas1 = new int[n];
            mas2 = new int[n];

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < mas.Length; i++)
            {
                int randomNumber = ran.Next(20);
                mas[i] = randomNumber;
                mas1[i] = randomNumber;
                mas2[i] = randomNumber;
                sb.Append(randomNumber.ToString() + " ");
            }
            textBox1.Text = sb.ToString();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar2.Minimum = 0;
            progressBar3.Minimum = 0;

            progressBar1.Maximum = 500;
            progressBar2.Maximum = 500;
            progressBar3.Maximum = 500;
            if (checkBox1.Checked)
            {
                progressBar1.Value = 0;
                stopwatch.Start();
                CocktailShakerSort(mas);
                stopwatch.Stop();
                progressBar1.Value = (int)(stopwatch.ElapsedMilliseconds);
                Application.DoEvents();
                label2.Text = $"{stopwatch.ElapsedMilliseconds} мс";


            }
            if (checkBox2.Checked)
            {
                progressBar2.Value = 0;
                stopwatch.Reset();
                stopwatch.Start();
                HybridSortArray(mas1);
                stopwatch.Stop();

                progressBar2.Value = (int)(stopwatch.ElapsedMilliseconds);
                Application.DoEvents();
                label3.Text = $"{stopwatch.ElapsedMilliseconds} мс";

            }
            if (checkBox3.Checked)
            {
                progressBar3.Value = 0;
                stopwatch.Reset();
                stopwatch.Start();
                StrandSortArray(mas2);

                stopwatch.Stop();
                progressBar3.Value = (int)(stopwatch.ElapsedMilliseconds);
                Application.DoEvents();
                label4.Text = $"{stopwatch.ElapsedMilliseconds} мс";


            }
        }

         void CocktailShakerSort(int[] arr)
        {
            bool swapped;
            int iterations = 0;


            listBox1.Items.Add($"Начальное состояние: {string.Join(", ", arr)}");

            do
            {
                swapped = false;

                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }


                listBox1.Items.Add($"Итерация {iterations + 1}: {string.Join(", ", arr)}");
                iterations++;

                if (!swapped)
                    break;

                swapped = false;

                for (int i = arr.Length - 2; i >= 0; i--)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);


            listBox1.Items.Add($"Сортировка завершена: {string.Join(", ", arr)}");
        }













        public void HybridSortArray(int[] arr)
        {
            HybridSortArray(arr, 0, arr.Length - 1);
        }

        private void HybridSortArray(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int size = right - left + 1;

                int threshold = 10;

                if (size < threshold)
                {

                    InsertionSort(arr, left, right);
                }
                else
                {
                    QuickSort(arr);
                }
            }
        }

        void InsertionSort(int[] arr, int left, int right)
        {
            int iterations = 0;
            for (int i = left + 1; i <= right; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= left && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
                iterations++;
                listBox1.Items.Add($"Сортировка завершена: {string.Join(", ", arr)}");
            }

        }
        public void QuickSort(int[] arr)
        {
            int iterations = 0;
            QuickSort(arr, 0, arr.Length - 1, ref iterations);
        }

        private void QuickSort(int[] arr, int left, int right, ref int iterations)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right, ref iterations);
                QuickSort(arr, left, pivotIndex - 1, ref iterations);
                QuickSort(arr, pivotIndex + 1, right, ref iterations);
            }
        }

        private int Partition(int[] arr, int left, int right, ref int iterations)
        {
            int pivot = arr[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
                iterations++;

                listBox1.Items.Add($"Итерация {iterations + 1}: {string.Join(", ", arr)}");
            }
            Swap(arr, i + 1, right);
            iterations++;
            listBox1.Items.Add($"Итерация {iterations + 1}: {string.Join(", ", arr)}");
            return i + 1;
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }










        private void StrandSortArray(int[] arr)
        {
            List<int> inputList = arr.ToList();
            List<int> result = new List<int>();

            int iterations = 0;

            while (inputList.Count > 0)
            {
                List<int> subsequence = new List<int> { inputList[0] };
                inputList.RemoveAt(0);

                for (int i = 0; i < inputList.Count; i++)
                {
                    if (inputList[i] > subsequence[subsequence.Count - 1])
                    {
                        subsequence.Add(inputList[i]);
                        inputList.RemoveAt(i);
                        i--;
                    }
                }

                result = Merge(result, subsequence);
                iterations++;
                listBox1.Items.Add($"Итерация {iterations + 1}: {string.Join(", ", result)}");

            }

            for (int i = 0; i < result.Count; i++)
            {
                arr[i] = result[i];
            }
        }

        public static List<int> Merge(List<int> list1, List<int> list2)
        {
            List<int> merged = new List<int>();
            int i = 0, j = 0;

            while (i < list1.Count && j < list2.Count)
            {
                if (list1[i] < list2[j])
                {
                    merged.Add(list1[i]);
                    i++;
                }
                else
                {
                    merged.Add(list2[j]);
                    j++;
                }
            }

            while (i < list1.Count)
            {
                merged.Add(list1[i]);
                i++;
            }

            while (j < list2.Count)
            {
                merged.Add(list2[j]);
                j++;
            }

            return merged;
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormA1 formA1 = new FormA1();

            formA1.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormA2 formA2 = new FormA2();

            formA2.Show();
            this.Hide();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormA3 formA3 = new FormA3();

            formA3.Show();
            this.Hide();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            FormA3 formA3 = new FormA3();

            formA3.Show();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormA4 formA4 = new FormA4();

            formA4.Show();
        }
    }

}