namespace Tyuiu.RomanovskiiMP.Sprint6.Task2.V8
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.labelFormula = new System.Windows.Forms.Label();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.labelStopValue = new System.Windows.Forms.Label();
            this.labelStartValue = new System.Windows.Forms.Label();
            this.textBoxStopValue = new System.Windows.Forms.TextBox();
            this.textBoxStartValue = new System.Windows.Forms.TextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxTask.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.labelFormula);
            this.groupBoxTask.Controls.Add(this.labelTask);
            this.groupBoxTask.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(560, 100);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(6, 19);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(540, 39);
            this.labelTask.TabIndex = 0;
            this.labelTask.Text = "Протабулировать функцию F(x) на заданном диапазоне.\r\nРезультат вывести в DataGridView. Округлить до двух знаков после запятой.\r\nПри делении на ноль вернуть значение 0.";
            // 
            // labelFormula
            // 
            this.labelFormula.AutoSize = true;
            this.labelFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormula.Location = new System.Drawing.Point(6, 70);
            this.labelFormula.Name = "labelFormula";
            this.labelFormula.Size = new System.Drawing.Size(350, 20);
            this.labelFormula.TabIndex = 1;
            this.labelFormula.Text = "F(x) = cos(2x) + sin(x) / (x + 2,5) + 2x";
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
            this.groupBoxOutput.Controls.Add(this.dataGridViewFunction);
            this.groupBoxOutput.Controls.Add(this.labelResult);
            this.groupBoxOutput.Location = new System.Drawing.Point(280, 130);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(292, 300);
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
            // dataGridViewFunction
            // 
            this.dataGridViewFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.FX});
            this.dataGridViewFunction.Location = new System.Drawing.Point(6, 38);
            this.dataGridViewFunction.Name = "dataGridViewFunction";
            this.dataGridViewFunction.RowHeadersVisible = false;
            this.dataGridViewFunction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewFunction.Size = new System.Drawing.Size(280, 256);
            this.dataGridViewFunction.TabIndex = 1;
            // 
            // X
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.X.DefaultCellStyle = dataGridViewCellStyle1;
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // FX
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.FX.DefaultCellStyle = dataGridViewCellStyle2;
            this.FX.HeaderText = "F(X)";
            this.FX.Name = "FX";
            this.FX.Width = 50;
            // 
            // buttonExecute
            // 
            this.buttonExecute.BackColor = System.Drawing.Color.Green;
            this.buttonExecute.Location = new System.Drawing.Point(187, 250);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 50);
            this.buttonExecute.TabIndex = 3;
            this.buttonExecute.Text = "Выполнить";
            this.buttonExecute.UseVisualStyleBackColor = false;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            this.buttonExecute.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonExecute_MouseDown);
            this.buttonExecute.MouseEnter += new System.EventHandler(this.buttonExecute_MouseEnter);
            this.buttonExecute.MouseLeave += new System.EventHandler(this.buttonExecute_MouseLeave);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonHelp.Location = new System.Drawing.Point(106, 250);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 50);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 8 | Романовский М.П.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn FX;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}