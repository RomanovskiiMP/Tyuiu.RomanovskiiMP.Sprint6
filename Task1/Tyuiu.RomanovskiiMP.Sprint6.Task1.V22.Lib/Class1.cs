namespace Tyuiu.RomanovskiiMP.Sprint6.Task1.V22.Lib
{
    public class DataService
    {
        /// <summary>
        /// Вычисляет значение функции F(x) = 3x + 2 − (2x − x) / (cos(x) + 1)
        /// </summary>
        /// <param name="x">Значение переменной x</param>
        /// <returns>Результат вычисления функции</returns>
        public double GetMassFunction(double x)
        {
            double result;
            double denominator = Math.Cos(x) + 1;
            
            // Проверка деления на ноль
            if (Math.Abs(denominator) < 1e-10)
            {
                return 0;
            }
            
            // F(x) = 3x + 2 − (2x − x) / (cos(x) + 1)
            // Упрощаем: (2x - x) = x
            result = 3 * x + 2 - x / denominator;
            
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
    }
}
