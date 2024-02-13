using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _3_курс_1_задание
{
    class Storage
    {
        static int _LastID;
        private int _ID;
        private double[,] _Matr; 

        public Storage(int Count) // Конструктор 
        {
            _ID = ++_LastID; // ID
            _Matr = Count > 1 ? new double[Count, Count] : new double[2, 2]; // Квадратная Матрица создается с условием что если больше 1,
            for (int i = 0; i < _Matr.GetLength(0); i++)
                for (int j = 0; j < _Matr.GetLength(0); j++)
                    _Matr[j, i] = 1;                                    // то есть от 2 и далее, то Матрица 'Count'x'Count', а если 1 и менее , то Матрица 2x2
        }

        public Storage() : this(2) { } // Конструктор без параметров

        public override string ToString() // Перегрузка метода ToString() для обеспечения правильного отображения экземпляров класса в визуальных компонентах
        {
            string s = "Матрица №" + _ID + ":"; // Номер Матрицы
            double sum = 0.0;
            for (int i = 0; i < _Matr.GetLength(0); i++) // Цикл который считает сумму дробных частей элементов побочной диагонали
            {                                            // GetLenght(0) дает нам размер нашей матрицы слава богу она квадратная
                double e = _Matr[i, _Matr.GetLength(0) - i - 1]; // Получаем элемент(цифирку) побочной диагонали
                double n = e - Math.Truncate(e); // Получаем дробные части тоесть все что после точки а до точки =0 , 10.5 дробная часть = 0.5
                sum += n; // Сумма
            }
            s += string.Format(" {0}", sum); // Добавляем в нашу верхнюю запись с номером матрицы сумму др. ч.
            return s;
        }

        public double this[int Index_i, int Index_j] // Индексатор для корректного доступа к матрице
        {
            get
            {
                if ((Index_i >= 2 && Index_i < _Matr.GetLength(0)) && (Index_j >= 2 && Index_j < _Matr.GetLength(1)))
                    return _Matr[Index_i, Index_j];
                else
                    throw new Exception("Неправильно задан/-ы индекс/-а матрицы: " + Index_i + " " + Index_j);
            }
            set 
            {
                if ((Index_i >= 2 && Index_i < _Matr.GetLength(0)) && (Index_j >= 2 && Index_j < _Matr.GetLength(1)))
                    if (value > 0)
                        _Matr[Index_i, Index_j] = value;
                else
                    throw new Exception("Неправильно задан/-ы индекс/-а матрицы: " + Index_i + " " + Index_j);
            }
        }

        public int Count // Свойство для получения количества элементов матрицы
        {
            get { return _Matr.Length; }
        }

        public int ID // Свойство для получения уникального номера матрицы
        {
            get { return _ID; }
        }

        public int Size // Свойство для получения размера квадратной матрицы
        {
            get { return _Matr.GetLength(0); }
        }

        public double DiffInAmounts() // Метод для расчета разности сумм элементов главной и побочной диагоналей
        {
            double summain = 0.0;
            double sumsecond = 0.0;
            for (int i = 0; i < _Matr.GetLength(0); i++)
            {
                summain += _Matr[i, i];
                sumsecond += _Matr[i, _Matr.GetLength(0) - i - 1];
            }
            return summain - sumsecond;
        }
    }
}
