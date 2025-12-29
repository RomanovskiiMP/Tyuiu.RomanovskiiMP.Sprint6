using Tyuiu.RomanovskiiMP.Sprint6.Task5.V16.Lib;

namespace Tyuiu.RomanovskiiMP.Sprint6.Task5.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Настройка DataGridView
            dataGridViewNumbers.ColumnCount = 2;
            dataGridViewNumbers.Columns[0].Name = "№";
            dataGridViewNumbers.Columns[1].Name = "Значение";
            dataGridViewNumbers.Columns[0].Width = 50;
            dataGridViewNumbers.Columns[1].Width = 100;
            dataGridViewNumbers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewNumbers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNumbers.ReadOnly = true;
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "..", "..", "..", "..", "InPutFileTask5V16.txt");
                filePath = Path.GetFullPath(filePath);

                if (!ds.FileExists(filePath))
                {
                    MessageBox.Show($"Файл не найден: {filePath}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double[] numbers = ds.LoadFromDataFile(filePath);

                // Очистка DataGridView
                dataGridViewNumbers.Rows.Clear();

                // Заполнение DataGridView
                for (int i = 0; i < numbers.Length; i++)
                {
                    dataGridViewNumbers.Rows.Add(i + 1, numbers[i]);
                }

                labelInfo.Text = $"Загружено {numbers.Length} чисел из файла InPutFileTask5V16.txt";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "..", "..", "..", "..", "InPutFileTask5V16.txt");
                filePath = Path.GetFullPath(filePath);

                if (File.Exists(filePath))
                {
                    System.Diagnostics.Process.Start("notepad.exe", filePath);
                }
                else
                {
                    MessageBox.Show($"Файл не найден: {filePath}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-3 Романовский Максим Павлович\n\n" +
                           "Программа читает числовые данные из файла InPutFileTask5V16.txt и отображает их в таблице.", 
                           "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}