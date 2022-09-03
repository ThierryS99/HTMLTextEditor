using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOption();
            HandleMenuOption();

        }
        public static void DrawScreen()
        {
            ExtremidadeCaixa();
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
            ExtremidadeCaixa();
        }

        public static void ExtremidadeCaixa()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void WriteOption()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("EDITOR HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("---------------------------");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir Arquivo");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair da aplicação");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption()
        {
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: EditorNew.Show(); break;
                case 2: AbrirArquivo.Abrir(); break;
                case 0:
                    {
                        Console.Clear();
                        System.Environment.Exit(0); break;
                    }
                default: Show(); break;
            }
        }
    }
}