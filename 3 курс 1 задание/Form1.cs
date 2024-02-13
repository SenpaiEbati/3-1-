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
    public partial class Main_F : Form
    {
        public Main_F()
        {
            InitializeComponent();
        }

        private void SetEnabledButtons() 
        {
            Change_B.Enabled = ListMatr_LB.SelectedItem != null;
            Del_B.Enabled = Change_B.Enabled;

            MatrSum_B.Enabled = ListMatr_LB.Items.Count > 0;
            if (ListMatr_LB.SelectedIndex >= 0)
            {
                Storage Temp = ListMatr_LB.SelectedItem as Storage;
                DiffInAmounts_TB.Text = Temp.DiffInAmounts().ToString();
            }
            else
                DiffInAmounts_TB.Text = "";
        }

        private void Add_B_Click(object sender, EventArgs e)
        {
            Dialog_F Dialog = new Dialog_F();
            Dialog.Text = "Добавление матрицы";

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                Storage Temp = new Storage(Dialog.Matr_DGV.RowCount);
                for (int i = 0; i < Dialog.Matr_DGV.RowCount; i++)
                    for (int j = 0; j < Dialog.Matr_DGV.ColumnCount; j++)
                        Temp[i, j] = Convert.ToDouble(Dialog.Matr_DGV[j, i].Value);
                ListMatr_LB.Items.Add(Temp);

                SetEnabledButtons();
                MatrSum_TB.Text = "";
            }
        }

        private void Change_B_Click(object sender, EventArgs e)
        {
            if (ListMatr_LB.SelectedIndex >= 0)
            {
                Dialog_F Dialog = new Dialog_F();
                Dialog.Text = "Изменение элементов матрицы";
                Storage Temp = ListMatr_LB.SelectedItem as Storage;
                Dialog.Count_NUD.Value = Temp.Size;

                Dialog.Matr_DGV.RowCount = Temp.Size;
                Dialog.Matr_DGV.ColumnCount = Temp.Size;
                for (int i = 0; i < Temp.Size; i++)
                    for (int j = 0; j < Temp.Size; j++)
                        Dialog.Matr_DGV[j, i].Value = Temp[i, j];

                Dialog.Count_NUD.Enabled = false;
                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < Dialog.Matr_DGV.RowCount; i++)
                        for (int j = 0; j < Dialog.Matr_DGV.ColumnCount; j++)
                            Temp[i, j] = Convert.ToDouble(Dialog.Matr_DGV[j, i].Value);

                    ListMatr_LB.Items[ListMatr_LB.SelectedIndex] = Temp;
                    SetEnabledButtons();
                    MatrSum_TB.Text = "";
                }
            }
            else
                MessageBox.Show("Не выбрана матрица для изменения параметров", "Информация", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Del_B_Click(object sender, EventArgs e)
        {
            if (ListMatr_LB.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбраную матрицу?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ListMatr_LB.Items.RemoveAt(ListMatr_LB.SelectedIndex);
                    SetEnabledButtons();
                    MatrSum_TB.Text = "";
                }
            }
            else
                MessageBox.Show("Не выбрана матрица для изменения параметров", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ListMatr_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnabledButtons();
        }

        private void MatrSum_B_Click(object sender, EventArgs e)
        {
            if (ListMatr_LB.Items.Count > 0) {
                int nomatr = 0;
                MatrSum_TB.Clear();
                for (int i = 0; i < ListMatr_LB.Items.Count; i++) {
                    Storage Temp_i = ListMatr_LB.Items[i] as Storage;
                    double sum_a = 0.0;
                    double sum_b = 0.0;

                    for (int j = 0; j < Temp_i.Size; j++) {
                        sum_a += Temp_i[0, j];
                        sum_b += Temp_i[Temp_i.Size - 1, j];
                    }
                    if (((sum_a - sum_b) < 0.00000000001) && (sum_a - sum_b) > -0.00000000001)
                    {
                        if ((MatrSum_TB.Text.Length == 0) || (MatrSum_TB.Text == "Нет матриц удовлетворяющие условию")) {
                            MatrSum_TB.Text = "Матрица №" + Temp_i.ID + " " + sum_a;
                        }
                        else
                        {
                            MatrSum_TB.Text += Environment.NewLine + "Матрица №" + Temp_i.ID + " " + sum_a;
                        }
                    }
                    else
                        nomatr++;
                }
                if (nomatr == ListMatr_LB.Items.Count)
                    MatrSum_TB.Text = "Нет матриц удовлетворяющие условию";
            }
            else
                MessageBox.Show("Не введены данные хотя бы по одной матрице", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Main_F_Load(object sender, EventArgs e)
        {
            SetEnabledButtons();
        }
    }
}
