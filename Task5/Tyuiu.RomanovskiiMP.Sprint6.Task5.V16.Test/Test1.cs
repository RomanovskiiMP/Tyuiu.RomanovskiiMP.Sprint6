using Tyuiu.RomanovskiiMP.Sprint6.Task5.V16.Lib;

namespace Tyuiu.RomanovskiiMP.Sprint6.Task5.V16.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidLoadFromDataFile()
    {
        DataService ds = new DataService();
        
        // Создаем временный файл для тестирования
        string testFile = Path.GetTempFileName();
        try
        {
            File.WriteAllText(testFile, "1.5\n-2.3\n0\n4.7\n");
            
            double[] result = ds.LoadFromDataFile(testFile);
            
            Assert.AreEqual(4, result.Length);
            Assert.AreEqual(1.5, result[0], 0.01);
            Assert.AreEqual(-2.3, result[1], 0.01);
            Assert.AreEqual(0, result[2], 0.01);
            Assert.AreEqual(4.7, result[3], 0.01);
        }
        finally
        {
            if (File.Exists(testFile))
                File.Delete(testFile);
        }
    }

    [TestMethod]
    public void ValidFileExists()
    {
        DataService ds = new DataService();
        
        string testFile = Path.GetTempFileName();
        try
        {
            Assert.IsTrue(ds.FileExists(testFile));
            Assert.IsFalse(ds.FileExists("nonexistent_file.txt"));
        }
        finally
        {
            if (File.Exists(testFile))
                File.Delete(testFile);
        }
    }

    [TestMethod]
    public void ValidGetLineCount()
    {
        DataService ds = new DataService();
        
        string testFile = Path.GetTempFileName();
        try
        {
            File.WriteAllLines(testFile, new[] { "1.5", "-2.3", "0" });
            
            int count = ds.GetLineCount(testFile);
            Assert.AreEqual(3, count);
        }
        finally
        {
            if (File.Exists(testFile))
                File.Delete(testFile);
        }
    }

    [TestMethod]
    [ExpectedException(typeof(FileNotFoundException))]
    public void LoadFromDataFileThrowsExceptionForNonexistentFile()
    {
        DataService ds = new DataService();
        ds.LoadFromDataFile("nonexistent_file.txt");
    }
}
