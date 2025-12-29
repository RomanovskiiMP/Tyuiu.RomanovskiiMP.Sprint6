using Tyuiu.RomanovskiiMP.Sprint6.Task3.V18.Lib;

namespace Tyuiu.RomanovskiiMP.Sprint6.Task3.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int[,] matrix = ds.GetMatrix();

            // Настройка DataGridView для исходного массива
            dataGridViewMatrix.ColumnCount = 5;
            dataGridViewMatrix.RowCount = 5;
            
            // Настройка DataGridView для результата
            dataGridViewResult.ColumnCount = 5;
            dataGridViewResult.RowCount = 5;

            // Настройка размеров колонок и строк
            for (int i = 0; i < 5; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 50;
                dataGridViewMatrix.Rows[i].Height = 50;
                dataGridViewResult.Columns[i].Width = 50;
                dataGridViewResult.Rows[i].Height = 50;
            }

            // Заполнение исходного массива
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            // Отключение возможности редактирования
            dataGridViewMatrix.ReadOnly = true;
            dataGridViewResult.ReadOnly = true;

            // Отключение заголовков
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.ColumnHeadersVisible = false;
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.ColumnHeadersVisible = false;

            // Выделение четвертой строки в исходном массиве
            dataGridViewMatrix.Rows[3].DefaultCellStyle.BackColor = Color.LightBlue;
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int[,] matrix = ds.GetMatrix();
                int[,] result = ds.Calculate(matrix);

                // Заполнение результирующего массива
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        dataGridViewResult.Rows[i].Cells[j].Value = result[i, j];
                        
                        // Выделение измененных значений в четвертой строке
                        if (i == 3 && matrix[i, j] != result[i, j])
                        {
                            dataGridViewResult.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
                        }
                        else if (i == 3)
                        {
                            dataGridViewResult.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-23-3 Романовский Максим Павлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}