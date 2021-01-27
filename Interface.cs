using System;

namespace Exam
{
    static public class Interface
    {
        static public void PrintInterface()
        {
            Console.Clear();

            for (int i = 0; i < Game.Word.Length; i++)
            {
                if (Game.IsLetterOpenByIndex(i))
                    Console.Write(Game.Word[i]);
                else
                    Console.Write('_');
            }
            Console.WriteLine("\nКоличество жизней: " + Game.LivesNum + "\nНе забудьте сменить раскладу на русскую!");
        }

        static public void AskLives()
        {
            Console.Clear();
            Console.Write("Введите количество жизней: ");
            string str = Console.ReadLine();
            Game.LivesNum = Int32.Parse(str);
        }

        static public void PrintFinal()
        {
            Console.Clear();

            Console.WriteLine("Загаданное слово: " + Game.Word);

            if (Game.LivesNum == 0)
                Console.WriteLine("Вы проиграли ):");
            else
                Console.WriteLine("Вы выиграли!");

            Console.ReadKey(true);
        }

        static public bool AskRepeat()
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                Console.WriteLine("Нажмите Enter, чтобы повторить или Escape, чтобы выйти");
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape);

            return key.Key == ConsoleKey.Enter;
        }
    }
}
