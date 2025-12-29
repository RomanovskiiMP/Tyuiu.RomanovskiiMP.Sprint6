using Tyuiu.RomanovskiiMP.Sprint6.Task3.V18.Lib;

namespace Tyuiu.RomanovskiiMP.Sprint6.Task3.V18.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidCalculate()
    {
        DataService ds = new DataService();
        
        int[,] matrix = ds.GetMatrix();
        int[,] result = ds.Calculate(matrix);
        
        // Проверяем размеры массива
        Assert.AreEqual(5, result.GetLength(0));
        Assert.AreEqual(5, result.GetLength(1));
        
        // Проверяем что четные значения в четвертой строке (индекс 3) заменены на 0
        int[,] expected = new int[5, 5] 
        {
            { -19, -19,  1,  18,  75 },
            {   3,  -4, -6, -12, -15 },
            {   6,   2,  2, -14,  -9 },
            {   0,  15, -5,   0, -13 }, // четные значения (-10, 6) заменены на 0, нечетные остались
            { -15,  -9,  7,   1,   0 }
        };
        
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Assert.AreEqual(expected[i, j], result[i, j], $"Ошибка в позиции [{i},{j}]");
            }
        }
    }

    [TestMethod]
    public void ValidGetMatrix()
    {
        DataService ds = new DataService();
        int[,] matrix = ds.GetMatrix();
        
        // Проверяем размеры
        Assert.AreEqual(5, matrix.GetLength(0));
        Assert.AreEqual(5, matrix.GetLength(1));
        
        // Проверяем несколько значений
        Assert.AreEqual(-19, matrix[0, 0]);
        Assert.AreEqual(18, matrix[0, 3]);
        Assert.AreEqual(-10, matrix[3, 0]);
        Assert.AreEqual(6, matrix[3, 3]);
    }

    [TestMethod]
    public void ValidEvenNumbersInFourthRow()
    {
        DataService ds = new DataService();
        
        int[,] matrix = ds.GetMatrix();
        int[,] result = ds.Calculate(matrix);
        
        // В четвертой строке (индекс 3) исходного массива: -10, 15, -5, 6, -13
        // Четные: -10, 6 должны стать 0
        // Нечетные: 15, -5, -13 должны остаться без изменений
        
        Assert.AreEqual(0, result[3, 0]);  // -10 -> 0
        Assert.AreEqual(15, result[3, 1]); // 15 остается
        Assert.AreEqual(-5, result[3, 2]); // -5 остается
        Assert.AreEqual(0, result[3, 3]);  // 6 -> 0
        Assert.AreEqual(-13, result[3, 4]); // -13 остается
    }
}
