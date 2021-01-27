using System;

namespace Exam
{
    static public class Game
    {
        static Random rnd = new Random();
        static private bool[] letterOpenArray;
        static public int ClosedLettersNum { get; set; }
        static public int LivesNum { get; set; }
        static private string openLetters;
        static private string word;
        static public string Word
        {
            get
            {
                return word;
            }
            set
            {
                word = value;
                letterOpenArray = new bool[word.Length];
                ClosedLettersNum = word.Length;
                openLetters = string.Empty;
            }
        }
        static public bool IsLetterOpenByIndex(int index)
        {
            return letterOpenArray[index];
        }

        static public void AscWord(string[] words)
        {
            string word = words[rnd.Next(words.Length)];
        }

        static public void SetLetterOpenArray(string word)
        {
            letterOpenArray = new bool[word.Length];
        }

        static public void OpenLetter(char letter)
        {
            if (Game.Word.Contains(letter) && !openLetters.Contains(letter))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == letter)
                    {
                        letterOpenArray[i] = true;
                        ClosedLettersNum--;
                        if (!openLetters.Contains(letter)) openLetters += letter;
                    }
                }
            }
            else
            {
                LivesNum--;
            }
        }
    }
}
