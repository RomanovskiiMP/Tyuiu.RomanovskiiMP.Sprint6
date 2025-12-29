namespace Tyuiu.RomanovskiiMP.Sprint6.Task6.V10.Lib
{
    public class DataService
    {
        /// <summary>
        /// Загружает текст из файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Содержимое файла</returns>
        public string LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            return File.ReadAllText(path);
        }

        /// <summary>
        /// Находит все слова, содержащие букву 'v' (в любом регистре)
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <returns>Строка со словами, содержащими 'v', разделенными пробелами</returns>
        public string CollectTextFromFile(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            // Разделяем текст на слова, удаляя знаки препинания
            char[] separators = { ' ', '\t', '\n', '\r', '.', ',', '!', '?', ':', ';', '"', '\'', '(', ')', '[', ']', '{', '}' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> wordsWithV = new List<string>();

            foreach (string word in words)
            {
                // Проверяем, содержит ли слово букву 'v' (в любом регистре)
                if (word.ToLower().Contains('v'))
                {
                    wordsWithV.Add(word);
                }
            }

            return string.Join(" ", wordsWithV);
        }

        /// <summary>
        /// Проверяет существование файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>True если файл существует</returns>
        public bool FileExists(string path)
        {
            return File.Exists(path);
        }
    }
}