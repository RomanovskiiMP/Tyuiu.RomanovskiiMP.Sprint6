using Tyuiu.RomanovskiiMP.Sprint6.Task7.V28.Lib;

namespace Tyuiu.RomanovskiiMP.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        private int[,]? matrix;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Настройка DataGridView
            SetupDataGridView(dataGridViewIn);
            SetupDataGridView(dataGridViewOut);
        }

        private void SetupDataGridView(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;
                        matrix = ds.LoadFromFileData(filePath);
                        
                        DisplayMatrix(dataGridViewIn, matrix);
                        dataGridViewOut.DataSource = null;
                        dataGridViewOut.Rows.Clear();
                        dataGridViewOut.Columns.Clear();
                        
                        labelInfo.Text = $"Файл загружен: {Path.GetFileName(filePath)} ({matrix.GetLength(0)}x{matrix.GetLength(1)})";
                        buttonDone.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при загрузке файла: " + ex.Message, "Ошибка", 
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Сначала загрузите файл!", "Предупреждение", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataService ds = new DataService();
            
            try
            {
                int[,] processedMatrix = ds.GetMatrix(matrix);
                DisplayMatrix(dataGridViewOut, processedMatrix);
                
                // Подсчитываем количество изменений в 7-й строке
                int changes = 0;
                if (matrix.GetLength(0) > 6)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[6, j] != 13 && processedMatrix[6, j] == 0)
                        {
                            changes++;
                        }
                    }
                }
                
                labelInfo.Text = $"Обработка завершена. В 7-й строке заменено {changes} значений на 0";
                buttonSaveFile.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обработке матрицы: " + ex.Message, "Ошибка", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (dataGridViewOut.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для сохранения!", "Предупреждение", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Application.StartupPath;
                saveFileDialog.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.FileName = "OutPutFileTask7.csv";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DataService ds = new DataService();
                        int[,] processedMatrix = ds.GetMatrix(matrix);
                        ds.SaveToFileData(processedMatrix, saveFileDialog.FileName);
                        
                        MessageBox.Show($"Файл успешно сохранен: {Path.GetFileName(saveFileDialog.FileName)}", 
                                      "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        labelInfo.Text = $"Результат сохранен в файл: {Path.GetFileName(saveFileDialog.FileName)}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при сохранении файла: " + ex.Message, "Ошибка", 
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DisplayMatrix(DataGridView dgv, int[,] matrix)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Добавляем столбцы
            for (int j = 0; j < cols; j++)
            {
                dgv.Columns.Add($"Col{j}", $"Столбец {j + 1}");
                dgv.Columns[j].Width = 80;
            }

            // Добавляем строки
            for (int i = 0; i < rows; i++)
            {
                object[] rowData = new object[cols];
                for (int j = 0; j < cols; j++)
                {
                    rowData[j] = matrix[i, j];
                }
                dgv.Rows.Add(rowData);
                
                // Выделяем 7-ю строку цветом
                if (i == 6)
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 7 выполнил студент группы ИИПб-23-3 Романовский Максим Павлович\n\n" +
                           "Программа загружает CSV файл с матрицей целых чисел,\n" +
                           "обрабатывает 7-ю строку (заменяет числа ≠ 13 на 0)\n" +
                           "и сохраняет результат в новый CSV файл.\n\n" +
                           "Инструкция:\n" +
                           "1. Нажмите 'Открыть файл' для загрузки CSV файла\n" +
                           "2. Нажмите 'Выполнить' для обработки матрицы\n" +
                           "3. Нажмите 'Сохранить файл' для сохранения результата", 
                           "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}