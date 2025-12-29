namespace Tyuiu.RomanovskiiMP.Sprint6.Task5.V16.Lib
{
    public class DataService
    {
        /// <summary>
        /// Читает числовые данные из файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Массив чисел из файла</returns>
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            List<double> numbers = new List<double>();
            
            string[] lines = File.ReadAllLines(path);
            
            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    if (double.TryParse(line.Trim(), out double number))
                    {
                        numbers.Add(number);
                    }
                }
            }
            
            return numbers.ToArray();
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

        /// <summary>
        /// Получает количество строк в файле
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Количество строк</returns>
        public int GetLineCount(string path)
        {
            if (!File.Exists(path))
            {
                return 0;
            }
            
            return File.ReadAllLines(path).Length;
        }
    }
}
