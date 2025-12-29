namespace Tyuiu.RomanovskiiMP.Sprint6.Task0.V15
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
            this.labelTask = new System.Windows.Forms.Label();
            this.labelFormula = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.groupBoxTask.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(6, 19);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(350, 13);
            this.labelTask.TabIndex = 0;
            this.labelTask.Text = "Вычислить выражение по формуле при x = 3";
            // 
            // labelFormula
            // 
            this.labelFormula.AutoSize = true;
            this.labelFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormula.Location = new System.Drawing.Point(6, 45);
            this.labelFormula.Name = "labelFormula";
            this.labelFormula.Size = new System.Drawing.Size(180, 20);
            this.labelFormula.TabIndex = 1;
            this.labelFormula.Text = "F(x) = x³ + 2x² + 5x + 4";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(6, 22);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(67, 13);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "Переменная X:";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(9, 38);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 3;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(6, 22);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(59, 13);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(9, 38);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(150, 20);
            this.textBoxResult.TabIndex = 5;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(300, 200);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 30);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Выполнить";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.labelTask);
            this.groupBoxTask.Controls.Add(this.labelFormula);
            this.groupBoxTask.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(388, 80);
            this.groupBoxTask.TabIndex = 7;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.labelX);
            this.groupBoxInput.Controls.Add(this.textBoxX);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 110);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(180, 80);
            this.groupBoxInput.TabIndex = 8;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.labelResult);
            this.groupBoxOutput.Controls.Add(this.textBoxResult);
            this.groupBoxOutput.Location = new System.Drawing.Point(220, 110);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(180, 80);
            this.groupBoxOutput.TabIndex = 9;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод данных";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 250);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxTask);
            this.Controls.Add(this.buttonCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 15 | Романовский М.П.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label labelFormula;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.GroupBox groupBoxOutput;
    }
}