using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Alg
{
    public partial class FormA4 : Form
    {
        private Stopwatch stopwatch;

        public FormA4()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            DataTable table = new DataTable();

            // Добавьте столбцы в таблицу

            table.Columns.Add("Сортировка");
            table.Columns.Add("Худший и средний случай");
            table.Columns.Add("Лучший случай");
            table.Columns.Add("Преимущества");
            table.Columns.Add("Недостатки");
            // Добавьте строки данных в таблицу
            table.Rows.Add("Шейкерная", "O(n^2)", "O(n)", "Прост в реализации, устойчив к малым и частично упорядоченным данным.", "Медленный для больших данных, имеет квадратичную временную сложность в худшем случае.");
            table.Rows.Add("Гибридная", "от O(n log n) до O(n^2)", "O(n), O(n log n)", "Могут быть эффективными на разных типах данных, учитывая их особенности.", "Сложнее в реализации, требует анализа данных для выбора подходящего алгоритма.");
            table.Rows.Add("Нитевидная", "O(n^2)", "O(n)", "Прост в реализации, устойчив к частично упорядоченным данным.", "Медленный для больших данных, имеет квадратичную временную сложность.");

            // Свяжите DataGridView с созданной таблицей
            dataGridView1.DataSource = table;
        }

        private void DrawHistogram(int[] executionTimes)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormA4_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }



}