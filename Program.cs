using System;
using System.Text.RegularExpressions;

namespace поиск_последовательности
{
    internal class Program
    {
        public static int count_max(string path)
        {
            try
            {
                string text = File.ReadAllText(path);

                string regularka = @"(?:AB|CB)+";
                MatchCollection matches = Regex.Matches(text, regularka);
                int maxCount = 0;
                foreach (Match match in matches)
                {
                    maxCount = Math.Max(maxCount, match.Length / 2);
                }
                return maxCount;

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден.");
                return -1;

            }
        }
            static void Main(string[] args)
            {
                string mypath = "C:\\My works for college\\поиск_последовательности\\bin\\Debug\\ABC.txt";
                int max = count_max(mypath);

                if (max != -1)
                {
                    Console.WriteLine($"Максимальное количество подряд идущих пар: {max}");
                }
            }
        }
    }

