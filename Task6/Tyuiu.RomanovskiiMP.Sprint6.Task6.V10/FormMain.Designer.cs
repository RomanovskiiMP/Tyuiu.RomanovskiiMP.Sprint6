namespace Tyuiu.RomanovskiiMP.Sprint6.Task6.V10
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
            textBoxIn = new TextBox();
            buttonOpenFile = new Button();
            groupBoxOutput = new GroupBox();
            textBoxOut = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            labelInfo = new Label();
            groupBoxTask.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(760, 100);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(6, 19);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(748, 60);
            labelTask.TabIndex = 0;
            labelTask.Text = "Дан файл InPutFileTask6V10.txt, в котором есть набор символьных данных.\r\nЗагрузить файл в textBoxIn через openFileDialog.\r\nВывести слова, в которых встречается v, в результирующую строку и вывести ее в textBoxOut.";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxIn);
            groupBoxInput.Controls.Add(buttonOpenFile);
            groupBoxInput.Location = new Point(12, 118);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(380, 300);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод";
            // 
            // textBoxIn
            // 
            textBoxIn.Location = new Point(6, 52);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.ReadOnly = true;
            textBoxIn.ScrollBars = ScrollBars.Vertical;
            textBoxIn.Size = new Size(368, 242);
            textBoxIn.TabIndex = 1;
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
            groupBoxOutput.Controls.Add(textBoxOut);
            groupBoxOutput.Location = new Point(398, 118);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(374, 300);
            groupBoxOutput.TabIndex = 2;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод";
            // 
            // textBoxOut
            // 
            textBoxOut.Location = new Point(6, 22);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.ReadOnly = true;
            textBoxOut.ScrollBars = ScrollBars.Vertical;
            textBoxOut.Size = new Size(362, 272);
            textBoxOut.TabIndex = 0;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Green;
            buttonDone.Location = new Point(672, 424);
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
            buttonHelp.Location = new Point(566, 424);
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
            labelInfo.Location = new Point(12, 440);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(200, 15);
            labelInfo.TabIndex = 5;
            labelInfo.Text = "Выберите файл для обработки";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 486);
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
            Text = "Спринт 6 | Таск 6 | Вариант 10 | Романовский М. П.";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTask;
        private Label labelTask;
        private GroupBox groupBoxInput;
        private TextBox textBoxIn;
        private Button buttonOpenFile;
        private GroupBox groupBoxOutput;
        private TextBox textBoxOut;
        private Button buttonDone;
        private Button buttonHelp;
        private Label labelInfo;
    }
}