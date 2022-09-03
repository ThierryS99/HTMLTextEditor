using System;
using System.IO;

namespace EditorHtml
{
    public class AbrirArquivo
    {
        public static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");

            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("Pressione uma tecla para retornar ao menu!");
            Console.ReadLine();
            Menu.Show();
        }
    }
}