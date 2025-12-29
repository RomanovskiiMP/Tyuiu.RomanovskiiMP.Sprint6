using Tyuiu.RomanovskiiMP.Sprint6.Task6.V10.Lib;

namespace Tyuiu.RomanovskiiMP.Sprint6.Task6.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Настройка формы при загрузке
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;
                        string fileContent = ds.LoadFromDataFile(filePath);
                        
                        textBoxIn.Text = fileContent;
                        textBoxOut.Clear();
                        
                        labelInfo.Text = $"Файл загружен: {Path.GetFileName(filePath)}";
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
            DataService ds = new DataService();
            
            try
            {
                string inputText = textBoxIn.Text;
                
                if (string.IsNullOrEmpty(inputText))
                {
                    MessageBox.Show("Сначала загрузите файл с текстом!", "Предупреждение", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string result = ds.CollectTextFromFile(inputText);
                textBoxOut.Text = result;

                if (string.IsNullOrEmpty(result))
                {
                    labelInfo.Text = "В тексте не найдено слов, содержащих букву 'v'";
                }
                else
                {
                    string[] words = result.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    labelInfo.Text = $"Найдено слов с буквой 'v': {words.Length}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обработке текста: " + ex.Message, "Ошибка", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 6 выполнил студент группы ИИПб-23-3 Романовский Максим Павлович\n\n" +
                           "Программа загружает текстовый файл и находит все слова, содержащие букву 'v'.\n\n" +
                           "Инструкция:\n" +
                           "1. Нажмите 'Открыть файл' для загрузки текстового файла\n" +
                           "2. Нажмите 'Выполнить' для поиска слов с буквой 'v'\n" +
                           "3. Результат отобразится в нижнем поле", 
                           "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}