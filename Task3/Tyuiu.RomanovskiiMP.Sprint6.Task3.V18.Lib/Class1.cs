namespace Tyuiu.RomanovskiiMP.Sprint6.Task3.V18.Lib
{
    public class DataService
    {
        /// <summary>
        /// Заменяет четные значения в четвертой строке массива на 0
        /// </summary>
        /// <param name="matrix">Двумерный массив 5x5</param>
        /// <returns>Обработанный массив</returns>
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            
            // Создаем копию массива
            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix[i, j];
                }
            }
            
            // Заменяем четные значения в четвертой строке (индекс 3) на 0
            for (int j = 0; j < columns; j++)
            {
                if (result[3, j] % 2 == 0)
                {
                    result[3, j] = 0;
                }
            }
            
            return result;
        }

        /// <summary>
        /// Возвращает исходный массив из задания
        /// </summary>
        /// <returns>Исходный массив 5x5</returns>
        public int[,] GetMatrix()
        {
            int[,] matrix = new int[5, 5] 
            {
                { -19, -19,  1,  18,  75 },
                {   3,  -4, -6, -12, -15 },
                {   6,   2,  2, -14,  -9 },
                { -10,  15, -5,   6, -13 },
                { -15,  -9,  7,   1,   0 }
            };
            
            return matrix;
        }
    }
}
