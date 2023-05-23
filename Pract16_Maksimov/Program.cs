namespace Pract16_Maksimov
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            Console.Write("Введите слово для поиска: ");
            string searchWord = Console.ReadLine();
            string filePath = "File.txt";
            try
            {
                if( new FileInfo( "File.txt" ).Length == 0 )
                {
                    throw new Exception("Файл пуст");
                }
                string text = File.ReadAllText(filePath);

                int count = CountOccurrences(text, searchWord, StringComparison.OrdinalIgnoreCase);

                Console.WriteLine($"Было найдено {count} вхождений (ий) поискового запроса \"{searchWord}\".");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден.");
            }
        }

        static int CountOccurrences(string text, string searchWord, StringComparison comparison)
        {
            int count = 0;
            int index = 0;

            while ((index = text.IndexOf(searchWord, index, comparison)) != -1)
            {
                count++;
                index += searchWord.Length;
            }

            return count;
        }
    }
}