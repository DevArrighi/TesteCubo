using System;
using System.Collections.Generic;
using System.Linq;

namespace Teste.Common
{
    public static class LeitorLog
    {
        #region [ Methods ]

        #region  [ Public ]

        /// <summary>
        /// Método responsável por ler arquivo de log e padronizar as linhas encontradas.
        /// </summary>
        /// <param name="path">Caminho do arquivo de log</param>
        /// <returns>Retorna as linhas padronizadas</returns>
        public static List<string> LerArquivo(string path)
        {
            //Carregar o arquivo atraves do path parametrizado
            var conteudo = System.IO.File.ReadAllText(@"C:\Users\Felipe\Desktop\grid1.txt");

            //Quebra texto em linhas
            var linhas = conteudo.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            //Remove primeira linha
            linhas.RemoveAt(0);

            //Percorre as linhas padronizando o formato
            for (int i = 0; i < linhas.Count; i++)
                linhas[i] = NormalizaString(linhas[i]);

            return linhas;
        }

        #endregion

        #region [ Private ]

        private static string NormalizaString(string texto)
        {
            if (texto.Contains("\t") || texto.Contains("  ") || texto.Contains("&&"))
            {
                texto = texto.Replace(" – ", "&");
                texto = texto.Replace("\t", " ");
                texto = texto.Replace("  ", "&");
                texto = texto.Replace("&&", "&");
                texto = texto.Replace("& ", "&");
                texto = texto.Replace(" &", "&");
                return NormalizaString(texto);
            }
            else
                return texto;
        }

        #endregion

        #endregion
    }
}
