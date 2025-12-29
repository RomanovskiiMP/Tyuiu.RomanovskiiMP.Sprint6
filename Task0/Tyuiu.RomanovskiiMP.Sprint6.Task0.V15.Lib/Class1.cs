namespace Tyuiu.RomanovskiiMP.Sprint6.Task0.V15.Lib
{
    public class DataService
    {
        /// <summary>
        /// Вычисляет значение функции F(x) = x³ + 2x² + 5x + 4
        /// </summary>
        /// <param name="x">Значение переменной x</param>
        /// <returns>Результат вычисления функции</returns>
        public double Calculate(double x)
        {
            return Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5 * x + 4;
        }
    }
}
