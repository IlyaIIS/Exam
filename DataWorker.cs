using System;
using System.IO;

namespace Exam
{
    static public class DataWorker
    {
        static Random rnd = new Random();
        static string[] Words { get; set; }
        static public void ReadWordsFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            Words = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                Words[i] = lines[i];
            }
        }

        static public string ChooseWord()
        {
            return Words[rnd.Next(Words.Length)];
        }
    }
}
