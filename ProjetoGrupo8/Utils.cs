using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGrupo8
{
    public class Utils
    {
        public static void EscreverTxt(List<Pessoa> pessoas, string arquivoNome)
        {
            FileStream fs = new FileStream(arquivoNome, FileMode.OpenOrCreate);
            try
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    foreach (var pessoa in pessoas)
                    {
                        writer.Write(pessoa);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void LerTxt(string arquivoNome)
        {
            try
            {
                using (StreamReader reader = new StreamReader(arquivoNome))
                {
                    string line = reader.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
