using Tyuiu.RomanovskiiMP.Sprint6.Task0.V15.Lib;

namespace Tyuiu.RomanovskiiMP.Sprint6.Task0.V15.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidCalculate()
    {
        DataService ds = new DataService();
        double x = 3;
        double expected = 64; // 3³ + 2*3² + 5*3 + 4 = 27 + 18 + 15 + 4 = 64
        double actual = ds.Calculate(x);
        Assert.AreEqual(expected, actual);
    }
}
