using Tyuiu.RomanovskiiMP.Sprint6.Task7.V28.Lib;

namespace Tyuiu.RomanovskiiMP.Sprint6.Task7.V28.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidGetMatrix()
    {
        DataService ds = new DataService();
        
        // Создаем тестовую матрицу 7x5
        int[,] testMatrix = new int[7, 5]
        {
            {5, 8, 12, 3, 7},
            {9, 15, 2, 11, 6},
            {4, 13, 18, 9, 14},
            {7, 3, 5, 13, 8},
            {12, 6, 9, 4, 15},
            {8, 13, 7, 2, 11},
            {13, 5, 13, 9, 13}  // 7-я строка: 13 остается, остальные заменяются на 0
        };
        
        int[,] result = ds.GetMatrix(testMatrix);
        
        // Проверяем, что первые 6 строк не изменились
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Assert.AreEqual(testMatrix[i, j], result[i, j], $"Значение в позиции [{i},{j}] должно остаться неизменным");
            }
        }
        
        // Проверяем 7-ю строку (индекс 6)
        Assert.AreEqual(13, result[6, 0], "Значение 13 должно остаться 13");
        Assert.AreEqual(0, result[6, 1], "Значение 5 должно стать 0");
        Assert.AreEqual(13, result[6, 2], "Значение 13 должно остаться 13");
        Assert.AreEqual(0, result[6, 3], "Значение 9 должно стать 0");
        Assert.AreEqual(13, result[6, 4], "Значение 13 должно остаться 13");
    }

    [TestMethod]
    public void ValidGetMatrixWithLessRows()
    {
        DataService ds = new DataService();
        
        // Создаем матрицу с менее чем 7 строками
        int[,] testMatrix = new int[3, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        
        int[,] result = ds.GetMatrix(testMatrix);
        
        // Проверяем, что матрица не изменилась
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Assert.AreEqual(testMatrix[i, j], result[i, j]);
            }
        }
    }

    [TestMethod]
    public void ValidLoadFromFileData()
    {
        DataService ds = new DataService();
        
        // Создаем временный CSV файл
        string testFile = Path.GetTempFileName();
        string csvContent = "1,2,3\n4,5,6\n7,8,9";
        
        try
        {
            File.WriteAllText(testFile, csvContent);
            
            int[,] result = ds.LoadFromFileData(testFile);
            
            Assert.AreEqual(3, result.GetLength(0), "Количество строк должно быть 3");
            Assert.AreEqual(3, result.GetLength(1), "Количество столбцов должно быть 3");
            
            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(5, result[1, 1]);
            Assert.AreEqual(9, result[2, 2]);
        }
        finally
        {
            if (File.Exists(testFile))
                File.Delete(testFile);
        }
    }

    [TestMethod]
    public void ValidSaveToFileData()
    {
        DataService ds = new DataService();
        
        int[,] testMatrix = new int[2, 3]
        {
            {1, 2, 3},
            {4, 5, 6}
        };
        
        string testFile = Path.GetTempFileName();
        
        try
        {
            ds.SaveToFileData(testMatrix, testFile);
            
            string[] lines = File.ReadAllLines(testFile);
            
            Assert.AreEqual(2, lines.Length, "Должно быть 2 строки");
            Assert.AreEqual("1,2,3", lines[0]);
            Assert.AreEqual("4,5,6", lines[1]);
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
            Assert.IsFalse(ds.FileExists("nonexistent_file.csv"));
        }
        finally
        {
            if (File.Exists(testFile))
                File.Delete(testFile);
        }
    }

    [TestMethod]
    [ExpectedException(typeof(FileNotFoundException))]
    public void LoadFromFileDataThrowsExceptionForNonexistentFile()
    {
        DataService ds = new DataService();
        ds.LoadFromFileData("nonexistent_file.csv");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetMatrixThrowsExceptionForNullMatrix()
    {
        DataService ds = new DataService();
        ds.GetMatrix(null!);
    }
}