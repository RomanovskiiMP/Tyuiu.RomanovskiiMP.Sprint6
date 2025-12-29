namespace Tyuiu.RomanovskiiMP.Sprint6.Task5.V16
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
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.dataGridViewNumbers = new System.Windows.Forms.DataGridView();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxTask.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumbers)).BeginInit();
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
            this.labelTask.Text = "Прочитать данные из файла InPutFileTask5V16.txt.\r\nВывести данные в DataGridView.\r\nФайл содержит числовые значения, разделенные переносами строк.";
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.dataGridViewNumbers);
            this.groupBoxData.Location = new System.Drawing.Point(12, 110);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(350, 300);
            this.groupBoxData.TabIndex = 1;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Данные из файла";
            // 
            // dataGridViewNumbers
            // 
            this.dataGridViewNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNumbers.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewNumbers.Name = "dataGridViewNumbers";
            this.dataGridViewNumbers.Size = new System.Drawing.Size(338, 275);
            this.dataGridViewNumbers.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(12, 420);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(200, 13);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "Нажмите кнопку для загрузки данных";
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.BackColor = System.Drawing.Color.Green;
            this.buttonLoadFile.Location = new System.Drawing.Point(380, 130);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(100, 50);
            this.buttonLoadFile.TabIndex = 3;
            this.buttonLoadFile.Text = "Загрузить данные";
            this.buttonLoadFile.UseVisualStyleBackColor = false;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpenFile.Location = new System.Drawing.Point(380, 200);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(100, 50);
            this.buttonOpenFile.TabIndex = 4;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonHelp.Location = new System.Drawing.Point(380, 270);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(100, 50);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.buttonLoadFile);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.groupBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 16 | Романовский М.П.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.DataGridView dataGridViewNumbers;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonHelp;
    }
}