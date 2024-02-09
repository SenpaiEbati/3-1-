namespace _3_курс_1_задание
{
    partial class Main_F
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListMatr_LB = new System.Windows.Forms.ListBox();
            this.ListMatr_L = new System.Windows.Forms.Label();
            this.Add_B = new System.Windows.Forms.Button();
            this.Change_B = new System.Windows.Forms.Button();
            this.Del_B = new System.Windows.Forms.Button();
            this.DiffSum_L = new System.Windows.Forms.Label();
            this.DiffSum_TB = new System.Windows.Forms.TextBox();
            this.MatrSum_TB = new System.Windows.Forms.TextBox();
            this.MatrSum_L = new System.Windows.Forms.Label();
            this.MatrSum_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListMatr_LB
            // 
            this.ListMatr_LB.FormattingEnabled = true;
            this.ListMatr_LB.Location = new System.Drawing.Point(11, 28);
            this.ListMatr_LB.Name = "ListMatr_LB";
            this.ListMatr_LB.Size = new System.Drawing.Size(274, 225);
            this.ListMatr_LB.TabIndex = 0;
            // 
            // ListMatr_L
            // 
            this.ListMatr_L.AutoSize = true;
            this.ListMatr_L.Location = new System.Drawing.Point(12, 9);
            this.ListMatr_L.Name = "ListMatr_L";
            this.ListMatr_L.Size = new System.Drawing.Size(84, 13);
            this.ListMatr_L.TabIndex = 1;
            this.ListMatr_L.Text = "Список &матриц";
            // 
            // Add_B
            // 
            this.Add_B.Location = new System.Drawing.Point(11, 259);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(75, 23);
            this.Add_B.TabIndex = 2;
            this.Add_B.Text = "&Добавить";
            this.Add_B.UseVisualStyleBackColor = true;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Change_B
            // 
            this.Change_B.Location = new System.Drawing.Point(112, 259);
            this.Change_B.Name = "Change_B";
            this.Change_B.Size = new System.Drawing.Size(75, 23);
            this.Change_B.TabIndex = 3;
            this.Change_B.Text = "&Изменить";
            this.Change_B.UseVisualStyleBackColor = true;
            this.Change_B.Click += new System.EventHandler(this.Change_B_Click);
            // 
            // Del_B
            // 
            this.Del_B.Location = new System.Drawing.Point(210, 259);
            this.Del_B.Name = "Del_B";
            this.Del_B.Size = new System.Drawing.Size(75, 23);
            this.Del_B.TabIndex = 4;
            this.Del_B.Text = "&Удалить";
            this.Del_B.UseVisualStyleBackColor = true;
            this.Del_B.Click += new System.EventHandler(this.Del_B_Click);
            // 
            // DiffSum_L
            // 
            this.DiffSum_L.AutoSize = true;
            this.DiffSum_L.Location = new System.Drawing.Point(301, 28);
            this.DiffSum_L.Name = "DiffSum_L";
            this.DiffSum_L.Size = new System.Drawing.Size(169, 26);
            this.DiffSum_L.TabIndex = 5;
            this.DiffSum_L.Text = "&Разность сумм элементов \r\nглавной и побочной диагоналей";
            // 
            // DiffSum_TB
            // 
            this.DiffSum_TB.Location = new System.Drawing.Point(479, 34);
            this.DiffSum_TB.Name = "DiffSum_TB";
            this.DiffSum_TB.ReadOnly = true;
            this.DiffSum_TB.Size = new System.Drawing.Size(75, 20);
            this.DiffSum_TB.TabIndex = 6;
            // 
            // MatrSum_TB
            // 
            this.MatrSum_TB.Location = new System.Drawing.Point(304, 133);
            this.MatrSum_TB.Name = "MatrSum_TB";
            this.MatrSum_TB.ReadOnly = true;
            this.MatrSum_TB.Size = new System.Drawing.Size(250, 20);
            this.MatrSum_TB.TabIndex = 7;
            // 
            // MatrSum_L
            // 
            this.MatrSum_L.AutoSize = true;
            this.MatrSum_L.Location = new System.Drawing.Point(301, 88);
            this.MatrSum_L.Name = "MatrSum_L";
            this.MatrSum_L.Size = new System.Drawing.Size(168, 39);
            this.MatrSum_L.TabIndex = 8;
            this.MatrSum_L.Text = "Матрицы, имеющие \r\nодинаковые &суммы элементов \r\nпервой и последней строк";
            // 
            // MatrSum_B
            // 
            this.MatrSum_B.Location = new System.Drawing.Point(479, 104);
            this.MatrSum_B.Name = "MatrSum_B";
            this.MatrSum_B.Size = new System.Drawing.Size(75, 23);
            this.MatrSum_B.TabIndex = 9;
            this.MatrSum_B.Text = "&Найти";
            this.MatrSum_B.UseVisualStyleBackColor = true;
            // 
            // Main_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 294);
            this.Controls.Add(this.MatrSum_B);
            this.Controls.Add(this.MatrSum_L);
            this.Controls.Add(this.MatrSum_TB);
            this.Controls.Add(this.DiffSum_TB);
            this.Controls.Add(this.DiffSum_L);
            this.Controls.Add(this.Del_B);
            this.Controls.Add(this.Change_B);
            this.Controls.Add(this.Add_B);
            this.Controls.Add(this.ListMatr_L);
            this.Controls.Add(this.ListMatr_LB);
            this.Name = "Main_F";
            this.Text = "Работа с основными элементами класса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListMatr_LB;
        private System.Windows.Forms.Label ListMatr_L;
        private System.Windows.Forms.Button Add_B;
        private System.Windows.Forms.Button Change_B;
        private System.Windows.Forms.Button Del_B;
        private System.Windows.Forms.Label DiffSum_L;
        private System.Windows.Forms.TextBox DiffSum_TB;
        private System.Windows.Forms.TextBox MatrSum_TB;
        private System.Windows.Forms.Label MatrSum_L;
        private System.Windows.Forms.Button MatrSum_B;
    }
}

