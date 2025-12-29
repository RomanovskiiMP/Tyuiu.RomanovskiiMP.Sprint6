using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.RomanovskiiMP.Sprint6.Task4.V9.Lib;

namespace Tyuiu.RomanovskiiMP.Sprint6.Task4.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            textBoxStartValue.Text = "-5";
            textBoxStopValue.Text = "5";
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

                // Очистка TextBox и Chart
                textBoxResult.Text = "";
                chartFunction.Series.Clear();

                // Создание серии для графика
                Series series = new Series("F(x)");
                series.ChartType = SeriesChartType.Spline;
                series.Color = Color.Blue;
                series.BorderWidth = 2;

                // Заполнение TextBox и Chart
                for (int i = 0; i <= len - 1; i++)
                {
                    textBoxResult.AppendText($"X = {startValue}\tF(X) = {valueArray[i]:F2}" + Environment.NewLine);
                    series.Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }

                chartFunction.Series.Add(series);
                chartFunction.ChartAreas[0].AxisX.Title = "X";
                chartFunction.ChartAreas[0].AxisY.Title = "F(X)";
                chartFunction.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                chartFunction.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введены неверные данные: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int startValue = Convert.ToInt32(textBoxStartValue.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue.Text);

                string fileName = "OutPutFileTask4V9.txt";
                string filePath = Path.Combine(Application.StartupPath, fileName);

                ds.SaveToFile(startValue, stopValue, filePath);

                MessageBox.Show($"Файл {fileName} сохранен успешно!\nПуть: {filePath}", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-23-3 Романовский Максим Павлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}