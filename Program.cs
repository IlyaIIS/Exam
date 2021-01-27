using System;

namespace Exam
{
    class Program
    {
        static void Main()
        {
            DataWorker.ReadWordsFile("words.txt");
            do
            {
                DoGameСycle();
            } while (Interface.AskRepeat());
        }

        static public void DoGameСycle()
        {
            Game.Word = DataWorker.ChooseWord();

            Interface.AskLives();
            Interface.PrintInterface();

            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);

                Game.OpenLetter(key.KeyChar);
                Interface.PrintInterface();
            } while (Game.ClosedLettersNum != 0 && Game.LivesNum > 0);

            Interface.PrintFinal();
        }

    }
}
