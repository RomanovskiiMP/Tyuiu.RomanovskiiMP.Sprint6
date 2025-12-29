using Tyuiu.RomanovskiiMP.Sprint6.Task1.V22.Lib;

namespace Tyuiu.RomanovskiiMP.Sprint6.Task1.V22
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

                string strLine;
                int len = stopValue - startValue + 1;
                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |{1,10:f2}|", startValue, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }

                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введены неверные данные: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-3 Романовский Максим Павлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            textBoxStartValue.Text = "-5";
            textBoxStopValue.Text = "5";
        }
    }
}