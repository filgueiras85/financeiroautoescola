using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class Frequencia
    {

        public Frequencia() { DiferencaDias = 0; Descricao = ""; }

        public int DiferencaDias { get; set; }

        public String Descricao { get; set; }

    }

    class ListaFrequencia
    {
        public ListaFrequencia() { PreencherLista(); }

        public List<Frequencia> ListFrequencia { get; set; }

        private void PreencherLista()
        {
            ListFrequencia = new List<Frequencia>();
            ListFrequencia.Add(new Frequencia() { DiferencaDias = 1, Descricao = "Uma única vez" });
            ListFrequencia.Add(new Frequencia() { DiferencaDias = 1, Descricao = "Diariamente" });
            ListFrequencia.Add(new Frequencia() { DiferencaDias = 7, Descricao = "Semanal" });
            ListFrequencia.Add(new Frequencia() { DiferencaDias = 15, Descricao = "A cada 15 dias" });
            ListFrequencia.Add(new Frequencia() { DiferencaDias = 30, Descricao = "Mensal" });
            ListFrequencia.Add(new Frequencia() { DiferencaDias = 60, Descricao = "Bimestral" });
            ListFrequencia.Add(new Frequencia() { DiferencaDias = 91, Descricao = "Trimestral" });
            ListFrequencia.Add(new Frequencia() { DiferencaDias = 182, Descricao = "Semestral" });
            ListFrequencia.Add(new Frequencia() { DiferencaDias = 365, Descricao = "Anual" });
        }
    }
}
