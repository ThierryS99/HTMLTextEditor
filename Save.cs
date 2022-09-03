using System;
using System.IO;

namespace EditorHtml
{
    public class Save
    {
        public static void Perguntar(string text)
        {
            System.Console.WriteLine("--------------------");
            Console.WriteLine("Deseja salvar o arquivo? Pressione 'S' para SIM ou qualquer tecla para descartar o arquivo.");
            char desejaSalvar = char.Parse(Console.ReadLine().ToLower());
            if (desejaSalvar == 's')
            {
                Salvar(text);
            }
            Menu.Show();
        }

        public static void Salvar(string text)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            Console.Write("Qual caminho para salvar o arquivo? ");
            var path = Console.ReadLine();

            using (var arquivo = new StreamWriter(path))
            {
                arquivo.Write(text);
            }

            Console.WriteLine("Arquivo salvo com sucesso! Pressione uma tecla para continuar.");
            Console.ReadKey();
            Menu.Show();
        }
    }
}