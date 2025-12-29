namespace Tyuiu.RomanovskiiMP.Sprint6.Task7.V28
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            groupBoxInput = new GroupBox();
            dataGridViewIn = new DataGridView();
            buttonOpenFile = new Button();
            groupBoxOutput = new GroupBox();
            dataGridViewOut = new DataGridView();
            buttonSaveFile = new Button();
            buttonDone = new Button();
            buttonHelp = new Button();
            labelInfo = new Label();
            groupBoxTask.SuspendLayout();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(860, 100);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(6, 19);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(848, 75);
            labelTask.TabIndex = 0;
            labelTask.Text = "Дан файл InPutFileTask7V28.csv, в котором хранится матрица целочисленных значений.\r\nЗагрузить через openFileDialog в объект dataGridViewIn.\r\nИзменить в седьмой строке числа не равные 13 на 0.\r\nРезультат вывести в объект dataGridViewOut.\r\nСохранить результат в файл OutPutFileTask7.csv через saveFileDialog.";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(dataGridViewIn);
            groupBoxInput.Controls.Add(buttonOpenFile);
            groupBoxInput.Location = new Point(12, 118);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(420, 350);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Location = new Point(6, 52);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.Size = new Size(408, 292);
            dataGridViewIn.TabIndex = 1;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(6, 22);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(100, 23);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.Text = "Открыть файл";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewOut);
            groupBoxOutput.Controls.Add(buttonSaveFile);
            groupBoxOutput.Location = new Point(452, 118);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(420, 350);
            groupBoxOutput.TabIndex = 2;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(6, 52);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.Size = new Size(408, 292);
            dataGridViewOut.TabIndex = 1;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Enabled = false;
            buttonSaveFile.Location = new Point(6, 22);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(100, 23);
            buttonSaveFile.TabIndex = 0;
            buttonSaveFile.Text = "Сохранить файл";
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Green;
            buttonDone.Enabled = false;
            buttonDone.Location = new Point(772, 474);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(100, 50);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.CornflowerBlue;
            buttonHelp.Location = new Point(666, 474);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(100, 50);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(12, 490);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(200, 15);
            labelInfo.TabIndex = 5;
            labelInfo.Text = "Выберите CSV файл для обработки";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 536);
            Controls.Add(labelInfo);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 28 | Романовский М. П.";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTask;
        private Label labelTask;
        private GroupBox groupBoxInput;
        private DataGridView dataGridViewIn;
        private Button buttonOpenFile;
        private GroupBox groupBoxOutput;
        private DataGridView dataGridViewOut;
        private Button buttonSaveFile;
        private Button buttonDone;
        private Button buttonHelp;
        private Label labelInfo;
    }
}