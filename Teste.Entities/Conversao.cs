using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Teste.Entities
{
    public static class Conversao
    {
        public static List<Volta> ConverterLogParaVoltas(List<string> listaLog)
        {
            var listaVoltas = new List<Volta>();
            var auxiliar = new List<string>();
            Volta volta;
            TimeSpan auxSpan;
            double auxDouble;


            for (int i = 0; i < listaLog.Count; i++)
            {
                volta = new Volta();
                auxiliar = listaLog[i].Split('&').ToList();

                //Hora inicial
                if (TimeSpan.TryParse(auxiliar[0], out auxSpan))
                    volta.Hora = auxSpan;

                //Codigo Piloto
                volta.Piloto.Id = auxiliar[1];

                //Nome Piloto
                volta.Piloto.Nome = auxiliar[2];

                //Numero volta
                volta.NumeroVolta = Convert.ToInt32(auxiliar[3]);

                //Tempo Gasto
                if (TimeSpan.TryParseExact(auxiliar[4].PadLeft(9, '0'), @"mm\:ss\.fff", CultureInfo.CurrentCulture, out auxSpan))
                    volta.TempoGasto = auxSpan;

                //Velocidade Média
                if (double.TryParse(auxiliar[5], out auxDouble))
                    volta.VelocidadeMedia = auxDouble;

                listaVoltas.Add(volta);
            }
            return listaVoltas;
        }
    }
}
