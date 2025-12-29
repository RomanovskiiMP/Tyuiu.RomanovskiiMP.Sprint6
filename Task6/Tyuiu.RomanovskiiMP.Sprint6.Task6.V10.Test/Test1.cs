using Tyuiu.RomanovskiiMP.Sprint6.Task6.V10.Lib;

namespace Tyuiu.RomanovskiiMP.Sprint6.Task6.V10.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidCollectTextFromFile()
    {
        DataService ds = new DataService();
        
        string testText = "Hello world! This is a sample text with various words. " +
                         "Some words contain the letter v like: victory, seven, above, and never. " +
                         "Programming involves solving problems.";
        
        string result = ds.CollectTextFromFile(testText);
        
        // Ожидаемые слова с буквой 'v': various, victory, seven, above, never, involves, solving
        string[] expectedWords = { "various", "victory", "seven", "above", "never", "involves", "solving" };
        
        foreach (string word in expectedWords)
        {
            Assert.IsTrue(result.Contains(word), $"Результат должен содержать слово '{word}'");
        }
    }

    [TestMethod]
    public void ValidCollectTextFromFileEmptyString()
    {
        DataService ds = new DataService();
        
        string result = ds.CollectTextFromFile("");
        
        Assert.AreEqual("", result);
    }

    [TestMethod]
    public void ValidCollectTextFromFileNoWordsWithV()
    {
        DataService ds = new DataService();
        
        string testText = "Hello world! This is a sample text without the target letter.";
        
        string result = ds.CollectTextFromFile(testText);
        
        Assert.AreEqual("", result);
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
    public void ValidLoadFromDataFile()
    {
        DataService ds = new DataService();
        
        string testFile = Path.GetTempFileName();
        string testContent = "Test content with victory and love words.";
        
        try
        {
            File.WriteAllText(testFile, testContent);
            
            string result = ds.LoadFromDataFile(testFile);
            
            Assert.AreEqual(testContent, result);
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