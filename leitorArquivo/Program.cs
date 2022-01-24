using System;
using System.IO;

namespace leitorArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //busca o arquivo na pasta selecionada
                const string filePath = @"C:\AquivoText\Arquivo1.txt";

                using var file = new StreamReader(filePath);

                string line;

                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
    
        }
    }
}
