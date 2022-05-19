using System;
using System.Threading;

namespace PersonalityCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteIntroduction();
            Console.WriteLine();
            WriteQuestion(1);
            WriteAnswers(1);
            Console.WriteLine();
            string input = AskForInput();

            while (!InputIsValid(input))
            {
                input = ReAskForInput();
            }

            Console.Clear();

            CalculatePersonality(input);

            Console.Clear();

            WriteResult(input);

            Console.ReadLine();
        }

        private static string ReAskForInput()
        {
            Console.Write("\b");
            ClearCurrentConsoleLine();
            Console.Write("Ungültige Eingabe, probiere es erneut!");
            Thread.Sleep(3000);
            ClearCurrentConsoleLine();
            return AskForInput();
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        private static void WriteResult(string input)
        {
            switch (input)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Du gehörst zu der Sorte Mensch, die gerne Bananen mag.");
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Du gehörst zu der Sorte Mensch, die gerne Äpfel mag.");
                    break;
                case "C":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du gehörst zu der Sorte Mensch, die gerne Kirschen mag.");
                    break;
                case "D":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Du gehörst zu der Sorte Mensch, die gerne Blaubeeren mag.");
                    break;
                default:
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void CalculatePersonality(string input)
        {
            Console.Write("Werte Eingaben aus");
            for (int i = 0; i < 15; i++)
            {
                Console.Write(".");
                Thread.Sleep(300);
            }
            Console.Write("\n");

            Console.Write("Ermittle Faktoren");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.Write("\n");

            Console.Write("Berechne Persönlichkeit ");
            WriteSpinningWheel(12);
            Console.Write("\n");

            Console.Write("Füttere Einhorn");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(".");
                Thread.Sleep(400);
            }
            Console.Write("\n");

            Console.WriteLine("fertig!");
            Thread.Sleep(3000);


        }

        private static void WriteSpinningWheel(int timesSpinning)
        {
            int speed = 100;
            for (int i = 0; i < timesSpinning; i++)
            {
                Console.Write("|");
                Thread.Sleep(speed);
                Console.Write("\b");
                Console.Write("/");
                Thread.Sleep(speed);
                Console.Write("\b");
                Console.Write("-");
                Thread.Sleep(speed);
                Console.Write("\b");
                Console.Write("\\");
                Thread.Sleep(speed);
                Console.Write("\b");
                Console.Write("|");
                Thread.Sleep(speed);
                Console.Write("\b");
                Console.Write("/");
                Thread.Sleep(speed);
                Console.Write("\b");
                Console.Write("-");
                Thread.Sleep(speed);
                Console.Write("\b");
                Console.Write("\\");
                Thread.Sleep(speed);
                Console.Write("\b");

            }
        }

        private static bool InputIsValid(string input)
        {
            return input switch
            {
                "A" or "B" or "C" or "D" => true,
                _ => false,
            };
        }

        private static string AskForInput()
        {
            Console.Write("Bitte gib den passenden Buchstaben zur gewünschten Auswahl ein: ");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            return consoleKeyInfo.Key.ToString();
        }

        private static void WriteAnswers(int answerNumber)
        {
            switch (answerNumber)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("A - Banane");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("B - Apfel");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("C - Kirsche");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("D - Blaubeere");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                default:
                    break;
            }
        }

        private static void WriteQuestion(int questionNumber)
        {
            switch (questionNumber)
            {
                case 1:
                    Console.WriteLine("Wähle eine Frucht, die Du gerne isst:");
                    break;
                default:
                    break;
            }
        }

        private static void WriteIntroduction()
        {
            Console.WriteLine("Dies ist ein Test um deine persönlichen Vorlieben zu bestimmen.");
        }
    }
}
