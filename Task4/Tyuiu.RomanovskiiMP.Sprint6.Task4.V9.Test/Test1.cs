using Tyuiu.RomanovskiiMP.Sprint6.Task4.V9.Lib;

namespace Tyuiu.RomanovskiiMP.Sprint6.Task4.V9.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidGetMassFunction()
    {
        DataService ds = new DataService();
        
        int startValue = -5;
        int stopValue = 5;
        
        double[] result = ds.GetMassFunction(startValue, stopValue);
        
        // Проверяем что массив имеет правильную длину
        Assert.AreEqual(11, result.Length);
        
        // Проверяем несколько значений
        double[] expected = new double[11];
        for (int i = 0; i <= 10; i++)
        {
            expected[i] = ds.GetMassFunction(startValue + i);
        }
        
        for (int i = 0; i < result.Length; i++)
        {
            Assert.AreEqual(expected[i], result[i], 0.01);
        }
    }

    [TestMethod]
    public void ValidGetMassFunctionSingleValue()
    {
        DataService ds = new DataService();
        
        // Тест для x = 1
        double result = ds.GetMassFunction(1);
        // F(1) = (2*1 - 3) / (cos(1) - 2*1) + 5*1 - sin(1)
        // F(1) = -1 / (cos(1) - 2) + 5 - sin(1)
        double denominator = Math.Cos(1) - 2;
        double expected = Math.Round(-1 / denominator + 5 - Math.Sin(1), 2);
        Assert.AreEqual(expected, result, 0.01);
    }

    [TestMethod]
    public void ValidSaveToFile()
    {
        DataService ds = new DataService();
        
        string testFile = Path.GetTempFileName();
        try
        {
            ds.SaveToFile(-2, 2, testFile);
            
            // Проверяем что файл создан и содержит данные
            Assert.IsTrue(File.Exists(testFile));
            
            string[] lines = File.ReadAllLines(testFile);
            Assert.AreEqual(5, lines.Length); // -2, -1, 0, 1, 2
            
            // Проверяем формат первой строки
            string[] parts = lines[0].Split('\t');
            Assert.AreEqual(2, parts.Length);
            Assert.AreEqual("-2", parts[0]);
        }
        finally
        {
            if (File.Exists(testFile))
                File.Delete(testFile);
        }
    }
}
