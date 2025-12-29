using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.RomanovskiiMP.Sprint6.Task4.V9
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            ChartArea chartArea1 = new ChartArea();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.labelFormula = new System.Windows.Forms.Label();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.labelStopValue = new System.Windows.Forms.Label();
            this.labelStartValue = new System.Windows.Forms.Label();
            this.textBoxStopValue = new System.Windows.Forms.TextBox();
            this.textBoxStartValue = new System.Windows.Forms.TextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBoxChart = new System.Windows.Forms.GroupBox();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxTask.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.groupBoxChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.labelFormula);
            this.groupBoxTask.Controls.Add(this.labelTask);
            this.groupBoxTask.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(760, 100);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(6, 19);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(740, 39);
            this.labelTask.TabIndex = 0;
            this.labelTask.Text = "Протабулировать функцию F(x) на заданном диапазоне.\r\nРезультат вывести в TextBox и построить график функции.\r\nСохранить в файл OutPutFileTask4V9.txt по нажатию кнопки. При делении на ноль вернуть 0.";
            // 
            // labelFormula
            // 
            this.labelFormula.AutoSize = true;
            this.labelFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormula.Location = new System.Drawing.Point(6, 70);
            this.labelFormula.Name = "labelFormula";
            this.labelFormula.Size = new System.Drawing.Size(450, 20);
            this.labelFormula.TabIndex = 1;
            this.labelFormula.Text = "F(x) = (2*x - 3) / (cos(x) - 2*x) + 5*x - sin(x)";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxStopValue);
            this.groupBoxInput.Controls.Add(this.textBoxStartValue);
            this.groupBoxInput.Controls.Add(this.labelStopValue);
            this.groupBoxInput.Controls.Add(this.labelStartValue);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 130);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(250, 100);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";
            // 
            // labelStartValue
            // 
            this.labelStartValue.AutoSize = true;
            this.labelStartValue.Location = new System.Drawing.Point(6, 22);
            this.labelStartValue.Name = "labelStartValue";
            this.labelStartValue.Size = new System.Drawing.Size(67, 13);
            this.labelStartValue.TabIndex = 0;
            this.labelStartValue.Text = "Старт шага:";
            // 
            // labelStopValue
            // 
            this.labelStopValue.AutoSize = true;
            this.labelStopValue.Location = new System.Drawing.Point(125, 22);
            this.labelStopValue.Name = "labelStopValue";
            this.labelStopValue.Size = new System.Drawing.Size(69, 13);
            this.labelStopValue.TabIndex = 1;
            this.labelStopValue.Text = "Конец шага:";
            // 
            // textBoxStartValue
            // 
            this.textBoxStartValue.Location = new System.Drawing.Point(6, 38);
            this.textBoxStartValue.Name = "textBoxStartValue";
            this.textBoxStartValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartValue.TabIndex = 2;
            // 
            // textBoxStopValue
            // 
            this.textBoxStopValue.Location = new System.Drawing.Point(125, 38);
            this.textBoxStopValue.Name = "textBoxStopValue";
            this.textBoxStopValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopValue.TabIndex = 3;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.textBoxResult);
            this.groupBoxOutput.Controls.Add(this.labelResult);
            this.groupBoxOutput.Location = new System.Drawing.Point(280, 130);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(200, 350);
            this.groupBoxOutput.TabIndex = 2;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод данных";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(6, 22);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(59, 13);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(6, 38);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(188, 306);
            this.textBoxResult.TabIndex = 1;
            // 
            // groupBoxChart
            // 
            this.groupBoxChart.Controls.Add(this.chartFunction);
            this.groupBoxChart.Location = new System.Drawing.Point(500, 130);
            this.groupBoxChart.Name = "groupBoxChart";
            this.groupBoxChart.Size = new System.Drawing.Size(272, 350);
            this.groupBoxChart.TabIndex = 3;
            this.groupBoxChart.TabStop = false;
            this.groupBoxChart.Text = "График функции";
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea1);
            this.chartFunction.Location = new System.Drawing.Point(6, 19);
            this.chartFunction.Name = "chartFunction";
            this.chartFunction.Size = new System.Drawing.Size(260, 325);
            this.chartFunction.TabIndex = 0;
            this.chartFunction.Text = "chart1";
            // 
            // buttonExecute
            // 
            this.buttonExecute.BackColor = System.Drawing.Color.Green;
            this.buttonExecute.Location = new System.Drawing.Point(187, 250);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 50);
            this.buttonExecute.TabIndex = 4;
            this.buttonExecute.Text = "Выполнить";
            this.buttonExecute.UseVisualStyleBackColor = false;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave.Location = new System.Drawing.Point(187, 320);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 50);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonHelp.Location = new System.Drawing.Point(187, 390);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 50);
            this.buttonHelp.TabIndex = 6;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 492);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.groupBoxChart);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 9 | Романовский М.П.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.groupBoxChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.Label labelFormula;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxStopValue;
        private System.Windows.Forms.TextBox textBoxStartValue;
        private System.Windows.Forms.Label labelStopValue;
        private System.Windows.Forms.Label labelStartValue;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.GroupBox groupBoxChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonHelp;
    }
}