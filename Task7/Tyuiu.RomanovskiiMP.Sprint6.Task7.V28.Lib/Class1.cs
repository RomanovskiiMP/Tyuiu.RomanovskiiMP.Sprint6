namespace Tyuiu.RomanovskiiMP.Sprint6.Task7.V28.Lib
{
    public class DataService
    {
        /// <summary>
        /// Загружает CSV файл и возвращает матрицу целых чисел
        /// </summary>
        /// <param name="path">Путь к CSV файлу</param>
        /// <returns>Двумерный массив целых чисел</returns>
        public int[,] LoadFromFileData(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            string[] lines = File.ReadAllLines(path);
            if (lines.Length == 0)
            {
                throw new InvalidOperationException("Файл пуст");
            }

            // Определяем размеры матрицы
            int rows = lines.Length;
            string[] firstRowValues = lines[0].Split(',');
            int cols = firstRowValues.Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(',');
                if (values.Length != cols)
                {
                    throw new InvalidOperationException($"Неверное количество столбцов в строке {i + 1}");
                }

                for (int j = 0; j < cols; j++)
                {
                    if (!int.TryParse(values[j].Trim(), out int value))
                    {
                        throw new InvalidOperationException($"Неверное значение '{values[j]}' в строке {i + 1}, столбце {j + 1}");
                    }
                    matrix[i, j] = value;
                }
            }

            return matrix;
        }

        /// <summary>
        /// Обрабатывает матрицу: в седьмой строке (индекс 6) заменяет все числа, не равные 13, на 0
        /// </summary>
        /// <param name="matrix">Исходная матрица</param>
        /// <returns>Обработанная матрица</returns>
        public int[,] GetMatrix(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Создаем копию матрицы
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j];
                }
            }

            // Обрабатываем седьмую строку (индекс 6), если она существует
            if (rows > 6)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (result[6, j] != 13)
                    {
                        result[6, j] = 0;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Сохраняет матрицу в CSV файл
        /// </summary>
        /// <param name="matrix">Матрица для сохранения</param>
        /// <param name="path">Путь к файлу</param>
        public void SaveToFileData(int[,] matrix, string path)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            List<string> lines = new List<string>();

            for (int i = 0; i < rows; i++)
            {
                List<string> rowValues = new List<string>();
                for (int j = 0; j < cols; j++)
                {
                    rowValues.Add(matrix[i, j].ToString());
                }
                lines.Add(string.Join(",", rowValues));
            }

            File.WriteAllLines(path, lines);
        }

        /// <summary>
        /// Проверяет существование файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>True если файл существует</returns>
        public bool FileExists(string path)
        {
            return File.Exists(path);
        }
    }
}