using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Teste.Entities
{
    //https://github.com/DevAmil/kart-rank

    public class Corrida
    {
        #region [ Properties ]

        #region [ Private ]

        private double _DistanciaPista;

        #endregion

        #region [ Public ]

        public Volta MelhorTempo
        {
            get
            {
                var melhorTempo = _ListVoltas.OrderBy(q => q.TempoGasto.TotalMilliseconds).ToList().SingleOrDefault();
                return melhorTempo;
            }
        }

        public Dictionary<string, List<Volta>> _dicionarioVoltasPorPiloto { get; set; }

        public Dictionary<string, TimeSpan> _dicionarioTempoCorrida { get; set; }

        public List<Volta> _ListVoltas { get; set; }

        #endregion

        #endregion

        #region [ Constructor ]

        public Corrida(List<Volta> listVoltas)
        {
            _ListVoltas = listVoltas;
            _dicionarioVoltasPorPiloto = new Dictionary<string, List<Volta>>();
            _dicionarioTempoCorrida = new Dictionary<string, TimeSpan>();

            //Seleciona os ids dos participantes da corrida
            var listIdsParticipantes = _ListVoltas.Select(p => p.Piloto.Id).Distinct();

            //Separa em um dicionario as voltas ordenadas por menor tempo de cada piloto
            foreach (var i in listIdsParticipantes)
                _dicionarioVoltasPorPiloto.Add(i, _ListVoltas.OrderBy(q => q.TempoGasto).Where(p => p.Piloto.Id.Equals(i)).ToList());

            //Calcula distancia da pista
            _DistanciaPista = listVoltas[0].VelocidadeMedia * listVoltas[0].TempoGasto.TotalSeconds;

            //Calcula o tempo total de cada piloto
            foreach (KeyValuePair<string, List<Volta>> dic in _dicionarioVoltasPorPiloto)
            {
                TimeSpan aux = new TimeSpan();
                foreach (var z in dic.Value)
                    aux = aux.Add(z.TempoGasto);
                _dicionarioTempoCorrida.Add(dic.Key, aux);
            }

            //Ordena por tempo os vencedores
            _dicionarioTempoCorrida = _dicionarioTempoCorrida.OrderBy(q => q.Value).ToDictionary(q => q.Key, q => q.Value);

        }

        #endregion

        #region [ Public Methods ]

        public string TempoChegadaPilotos()
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            TimeSpan aux = new TimeSpan();

            //Percorre o tempo de corrida de cada piloto
            foreach (KeyValuePair<string, TimeSpan> i in _dicionarioTempoCorrida)
            {
                if (count.Equals(0))
                {
                    count++;
                    aux = i.Value;
                    sb.Append("Lista de ordem de chegada em tempo:\n\n");
                    sb.Append(count.ToString() + "º Piloto: " + _dicionarioVoltasPorPiloto[i.Key][0].Piloto.Nome + " Tempo: " + i.Value.ToString(@"mm\:ss\.ff", CultureInfo.CurrentCulture) + "\n");
                }
                else
                {
                    count++;
                    //Verifica quais pilotos terminaram a prova de 4 voltas
                    if (_dicionarioVoltasPorPiloto[i.Key].Count < 4)
                        sb.Append(count.ToString() + "º Piloto: " + _dicionarioVoltasPorPiloto[i.Key][0].Piloto.Nome + " ** Não terminou a corrida. **\n");
                    else
                        sb.Append(count.ToString() + "º Piloto: " + _dicionarioVoltasPorPiloto[i.Key][0].Piloto.Nome + " Tempo: " + (i.Value.Subtract(aux).TotalSeconds).ToString("0.00") + " segundos depois.\n");
                }
            }
            return sb.ToString();
        }

        public List<Resultado> RankingMelhorVoltaPorPiloto()
        {
            List<Resultado> listResultado = new List<Resultado>();
            Resultado r;
            int count = 1;

            foreach (KeyValuePair<string, TimeSpan> i in _dicionarioTempoCorrida)
            {
                r = new Resultado();
                var melhorVolta = _dicionarioVoltasPorPiloto[i.Key][0];
                r.NomePiloto = melhorVolta.Piloto.Nome;
                r.NumeroVolta = melhorVolta.NumeroVolta.ToString();
                r.TempoTotalProva = melhorVolta.TempoGasto.ToString(@"hh\:mm\:ss\.fff", CultureInfo.CurrentCulture);
                listResultado.Add(r);
            }

            //Ordena a lista por tempo
            listResultado = listResultado.OrderBy(q => q.TempoTotalProva).ToList();

            //Numera ranking melhores voltas
            listResultado.ForEach(f => f.PosicaoChegada = (count++).ToString() + "º");

            return listResultado;
        }

        public List<Resultado> ListaExibição()
        {
            List<Resultado> listResultado = new List<Resultado>();
            Resultado r;
            int count = 1;

            foreach (KeyValuePair<string, TimeSpan> i in _dicionarioTempoCorrida)
            {
                r = new Resultado();
                r.PosicaoChegada = count.ToString() + "º";
                r.CodigoPiloto = i.Key;
                r.TempoTotalProva = i.Value.ToString(@"hh\:mm\:ss\.fff", CultureInfo.CurrentCulture);
                r.QuantidadeVoltas = _dicionarioVoltasPorPiloto[i.Key].Count;
                r.NomePiloto = _dicionarioVoltasPorPiloto[i.Key][0].Piloto.Nome;
                r.VelocidadeMedia = (_DistanciaPista * _dicionarioVoltasPorPiloto[i.Key].Count / i.Value.TotalSeconds).ToString("0.00");

                listResultado.Add(r);
                count++;
            }
            return listResultado;
        }

        #endregion
    }
}
