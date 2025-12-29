using Tyuiu.RomanovskiiMP.Sprint6.Task2.V8.Lib;

namespace Tyuiu.RomanovskiiMP.Sprint6.Task2.V8.Test;

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
        
        // Тест для x = 0
        double result = ds.GetMassFunction(0);
        // F(0) = cos(0) + sin(0) / (0 + 2.5) + 2*0 = 1 + 0/2.5 + 0 = 1
        double expected = Math.Round(Math.Cos(0) + Math.Sin(0) / 2.5 + 0, 2);
        Assert.AreEqual(expected, result, 0.01);
    }

    [TestMethod]
    public void ValidCheckDivisionByZero()
    {
        DataService ds = new DataService();
        
        // Тест для x = -2.5 (деление на ноль)
        double result = ds.GetMassFunction(-2.5);
        Assert.AreEqual(0, result);
    }
}
