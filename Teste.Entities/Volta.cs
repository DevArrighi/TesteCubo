using System;

namespace Teste.Entities
{
    public class Volta
    {
        public Volta()
        {
            Piloto = new Piloto();
        }

        public Piloto Piloto { get; set; }

        public TimeSpan Hora { get; set; }

        public TimeSpan HoraTermino
        {
            get
            {
                return Hora.Add(TempoGasto);
            }
        }

        public int NumeroVolta { get; set; }

        public TimeSpan TempoGasto { get; set; }

        public double VelocidadeMedia { get; set; }
    }
}
