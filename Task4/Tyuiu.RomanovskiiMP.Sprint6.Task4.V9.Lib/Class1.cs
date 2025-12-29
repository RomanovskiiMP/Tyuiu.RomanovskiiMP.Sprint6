namespace Tyuiu.RomanovskiiMP.Sprint6.Task4.V9.Lib
{
    public class DataService
    {
        /// <summary>
        /// Вычисляет значение функции F(x) = (2*x - 3) / (cos(x) - 2*x) + 5*x - sin(x)
        /// </summary>
        /// <param name="x">Значение переменной x</param>
        /// <returns>Результат вычисления функции</returns>
        public double GetMassFunction(double x)
        {
            double result;
            double denominator = Math.Cos(x) - 2 * x;
            
            // Проверка деления на ноль
            if (Math.Abs(denominator) < 1e-10)
            {
                return 0;
            }
            
            // F(x) = (2*x - 3) / (cos(x) - 2*x) + 5*x - sin(x)
            result = (2 * x - 3) / denominator + 5 * x - Math.Sin(x);
            
            return Math.Round(result, 2);
        }

        /// <summary>
        /// Производит табулирование функции на заданном диапазоне
        /// </summary>
        /// <param name="startValue">Начальное значение диапазона</param>
        /// <param name="stopValue">Конечное значение диапазона</param>
        /// <returns>Массив значений функции</returns>
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                valueArray[count] = GetMassFunction(x);
                count++;
            }
            
            return valueArray;
        }

        /// <summary>
        /// Сохраняет результаты табулирования в файл
        /// </summary>
        /// <param name="startValue">Начальное значение диапазона</param>
        /// <param name="stopValue">Конечное значение диапазона</param>
        /// <param name="filePath">Путь к файлу для сохранения</param>
        public void SaveToFile(int startValue, int stopValue, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double y = GetMassFunction(x);
                    writer.WriteLine($"{x}\t{y:F2}");
                }
            }
        }
    }
}
