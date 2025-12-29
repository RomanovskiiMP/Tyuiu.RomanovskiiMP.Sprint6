using Tyuiu.RomanovskiiMP.Sprint6.Task2.V8.Lib;

namespace Tyuiu.RomanovskiiMP.Sprint6.Task2.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue.Text);

                int len = stopValue - startValue + 1;
                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                // Очищаем DataGridView
                dataGridViewFunction.Rows.Clear();

                // Заполняем DataGridView
                for (int i = 0; i <= len - 1; i++)
                {
                    dataGridViewFunction.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    startValue++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введены неверные данные: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-3 Романовский Максим Павлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            textBoxStartValue.Text = "-5";
            textBoxStopValue.Text = "5";
        }

        private void buttonExecute_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Выполнить";
        }

        private void buttonExecute_MouseDown(object sender, MouseEventArgs e)
        {
            buttonExecute.BackColor = Color.Blue;
        }

        private void buttonExecute_MouseLeave(object sender, EventArgs e)
        {
            buttonExecute.BackColor = Color.Green;
        }
    }
}