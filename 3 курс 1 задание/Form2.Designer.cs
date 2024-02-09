namespace _3_курс_1_задание
{
    partial class Dialog_F
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ok_B = new System.Windows.Forms.Button();
            this.Cancel_B = new System.Windows.Forms.Button();
            this.Count_L = new System.Windows.Forms.Label();
            this.Matr_L = new System.Windows.Forms.Label();
            this.Count_NUD = new System.Windows.Forms.NumericUpDown();
            this.Matr_DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Count_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matr_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Ok_B
            // 
            this.Ok_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok_B.Location = new System.Drawing.Point(345, 8);
            this.Ok_B.Name = "Ok_B";
            this.Ok_B.Size = new System.Drawing.Size(75, 23);
            this.Ok_B.TabIndex = 0;
            this.Ok_B.Text = "OK";
            this.Ok_B.UseVisualStyleBackColor = true;
            // 
            // Cancel_B
            // 
            this.Cancel_B.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B.Location = new System.Drawing.Point(345, 49);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(75, 23);
            this.Cancel_B.TabIndex = 1;
            this.Cancel_B.Text = "Отмена";
            this.Cancel_B.UseVisualStyleBackColor = true;
            // 
            // Count_L
            // 
            this.Count_L.AutoSize = true;
            this.Count_L.Location = new System.Drawing.Point(13, 13);
            this.Count_L.Name = "Count_L";
            this.Count_L.Size = new System.Drawing.Size(156, 13);
            this.Count_L.TabIndex = 2;
            this.Count_L.Text = "Размер квадратной матрицы";
            // 
            // Matr_L
            // 
            this.Matr_L.AutoSize = true;
            this.Matr_L.Location = new System.Drawing.Point(13, 62);
            this.Matr_L.Name = "Matr_L";
            this.Matr_L.Size = new System.Drawing.Size(51, 13);
            this.Matr_L.TabIndex = 3;
            this.Matr_L.Text = "Матрица";
            // 
            // Count_NUD
            // 
            this.Count_NUD.Location = new System.Drawing.Point(175, 11);
            this.Count_NUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Count_NUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Count_NUD.Name = "Count_NUD";
            this.Count_NUD.Size = new System.Drawing.Size(66, 20);
            this.Count_NUD.TabIndex = 4;
            this.Count_NUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Matr_DGV
            // 
            this.Matr_DGV.AllowUserToAddRows = false;
            this.Matr_DGV.AllowUserToDeleteRows = false;
            this.Matr_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matr_DGV.ColumnHeadersVisible = false;
            this.Matr_DGV.Location = new System.Drawing.Point(12, 78);
            this.Matr_DGV.Name = "Matr_DGV";
            this.Matr_DGV.RowHeadersVisible = false;
            this.Matr_DGV.Size = new System.Drawing.Size(408, 350);
            this.Matr_DGV.TabIndex = 5;
            // 
            // Dialog_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.Matr_DGV);
            this.Controls.Add(this.Count_NUD);
            this.Controls.Add(this.Matr_L);
            this.Controls.Add(this.Count_L);
            this.Controls.Add(this.Cancel_B);
            this.Controls.Add(this.Ok_B);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Dialog_F";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Count_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matr_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok_B;
        private System.Windows.Forms.Button Cancel_B;
        private System.Windows.Forms.Label Count_L;
        private System.Windows.Forms.Label Matr_L;
        public System.Windows.Forms.NumericUpDown Count_NUD;
        public System.Windows.Forms.DataGridView Matr_DGV;
    }
}