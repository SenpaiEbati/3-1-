using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_курс_1_задание
{
    public partial class Dialog_F : Form
    {
        public Dialog_F()
        {
            InitializeComponent();
        }

        private void Count_NUD_ValueChanged(object sender, EventArgs e)
        {
            Matr_DGV.RowCount = Convert.ToInt32(Count_NUD.Value);
            Matr_DGV.ColumnCount = Convert.ToInt32(Count_NUD.Value);
        }

        private void Dialog_F_Load(object sender, EventArgs e)
        {
            Matr_DGV.RowCount = Convert.ToInt32(Count_NUD.Value);
            Matr_DGV.ColumnCount = Convert.ToInt32(Count_NUD.Value);
        }

        private void Dialog_F_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                int i = 0;
                int j = 0;
                try
                {
                    for (i = 0; i < Matr_DGV.RowCount; i++)
                    {
                        for (j = 0; j < Matr_DGV.ColumnCount; j++)
                        {
                            if (Matr_DGV[j, i].Value == null)
                            {
                                Matr_DGV.Focus();
                                Matr_DGV.CurrentCell = Matr_DGV[j, i];
                                throw new Exception("Не введено значение элемента " +
                                    "[" + (i + 1) + "," + (j + 1) + "] в матрицу");
                            }
                            double Temp = Convert.ToDouble(Matr_DGV[j, i].Value);
                            if (Temp <= 0)
                            {
                                Matr_DGV.Focus();
                                Matr_DGV.CurrentCell = Matr_DGV[j, i];
                                throw new Exception("Неправильное значение элемента " +
                                    "[" + (i + 1) + "," + (j + 1) + "] матрицы. " +
                                    "Элементы матрицы должны быть больше 0");
                            }
                        }
                    }
                }
                catch (FormatException)
                {
                    e.Cancel = true;
                    Matr_DGV.Focus();
                    Matr_DGV.CurrentCell = Matr_DGV[j, i];
                    MessageBox.Show("Неправильное значение элемента " +
                                    "[" + (i + 1) + "," + (j + 1) + "] матрицы. " +
                                    "Элементы матрицы должны быть дробным числом", "Требуется исправление",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception E) 
                {
                    e.Cancel= true;
                    MessageBox.Show(E.Message,  "Требуется исправление",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
