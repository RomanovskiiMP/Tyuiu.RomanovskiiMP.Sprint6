namespace Tyuiu.RomanovskiiMP.Sprint6.Task2.V8.Lib
{
    public class DataService
    {
        /// <summary>
        /// Вычисляет значение функции F(x) = cos(2x) + sin(x) / (x + 2,5) + 2x
        /// </summary>
        /// <param name="x">Значение переменной x</param>
        /// <returns>Результат вычисления функции</returns>
        public double GetMassFunction(double x)
        {
            double result;
            double denominator = x + 2.5;
            
            // Проверка деления на ноль
            if (Math.Abs(denominator) < 1e-10)
            {
                return 0;
            }
            
            // F(x) = cos(2x) + sin(x) / (x + 2,5) + 2x
            result = Math.Cos(2 * x) + Math.Sin(x) / denominator + 2 * x;
            
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
