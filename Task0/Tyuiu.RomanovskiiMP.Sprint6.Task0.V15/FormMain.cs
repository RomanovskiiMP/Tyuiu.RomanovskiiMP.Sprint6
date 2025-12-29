using Tyuiu.RomanovskiiMP.Sprint6.Task0.V15.Lib;

namespace Tyuiu.RomanovskiiMP.Sprint6.Task0.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                double x = 3; // По условию x = 3
                double result = ds.Calculate(x);
                textBoxResult.Text = Math.Round(result, 3).ToString("F3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            textBoxX.Text = "3"; // Устанавливаем значение x = 3 по умолчанию
        }
    }
}