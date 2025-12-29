namespace Tyuiu.RomanovskiiMP.Sprint6.Task3.V18
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
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.groupBoxMatrix = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.labelMatrix = new System.Windows.Forms.Label();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxTask.SuspendLayout();
            this.groupBoxMatrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.labelTask);
            this.groupBoxTask.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(560, 80);
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
            this.labelTask.Text = "Дан массив 5 на 5 элементов. Заменить чётные значения в четвёртой строке на 0.\r\nРезультат вывести в DataGridView.\r\nЧетвертая строка выделена синим цветом, измененные значения - зеленым.";
            // 
            // groupBoxMatrix
            // 
            this.groupBoxMatrix.Controls.Add(this.dataGridViewMatrix);
            this.groupBoxMatrix.Controls.Add(this.labelMatrix);
            this.groupBoxMatrix.Location = new System.Drawing.Point(12, 110);
            this.groupBoxMatrix.Name = "groupBoxMatrix";
            this.groupBoxMatrix.Size = new System.Drawing.Size(280, 300);
            this.groupBoxMatrix.TabIndex = 1;
            this.groupBoxMatrix.TabStop = false;
            this.groupBoxMatrix.Text = "Исходный массив";
            // 
            // labelMatrix
            // 
            this.labelMatrix.AutoSize = true;
            this.labelMatrix.Location = new System.Drawing.Point(6, 22);
            this.labelMatrix.Name = "labelMatrix";
            this.labelMatrix.Size = new System.Drawing.Size(94, 13);
            this.labelMatrix.TabIndex = 0;
            this.labelMatrix.Text = "Исходный массив:";
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(6, 38);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.Size = new System.Drawing.Size(268, 256);
            this.dataGridViewMatrix.TabIndex = 1;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.dataGridViewResult);
            this.groupBoxResult.Controls.Add(this.labelResult);
            this.groupBoxResult.Location = new System.Drawing.Point(310, 110);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(280, 300);
            this.groupBoxResult.TabIndex = 2;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результат";
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
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(6, 38);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(268, 256);
            this.dataGridViewResult.TabIndex = 1;
            // 
            // buttonExecute
            // 
            this.buttonExecute.BackColor = System.Drawing.Color.Green;
            this.buttonExecute.Location = new System.Drawing.Point(515, 430);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 50);
            this.buttonExecute.TabIndex = 3;
            this.buttonExecute.Text = "Выполнить";
            this.buttonExecute.UseVisualStyleBackColor = false;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonHelp.Location = new System.Drawing.Point(434, 430);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 50);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 492);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxMatrix);
            this.Controls.Add(this.groupBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 18 | Романовский М.П.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxMatrix.ResumeLayout(false);
            this.groupBoxMatrix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.GroupBox groupBoxMatrix;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.Label labelMatrix;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonHelp;
    }
}