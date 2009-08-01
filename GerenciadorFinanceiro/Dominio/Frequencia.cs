using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Dominio
{
    class Frequencia
    {

        public Frequencia() { QntdParcela = 0; Descricao = ""; }

        public int QntdParcela { get; set; }

        public String Descricao { get; set; }

    }

    class ListaFrequencia
    {
        public ListaFrequencia() { PreencherLista(); }

        public List<Frequencia> ListFrequencia { get; set; }

        private void PreencherLista()
        {
            ListFrequencia = new List<Frequencia>();
            ListFrequencia.Add(new Frequencia() { QntdParcela = 1, Descricao = "Uma única vez" });
            ListFrequencia.Add(new Frequencia() { QntdParcela = 1, Descricao = "Diariamente" });
            ListFrequencia.Add(new Frequencia() { QntdParcela = 7, Descricao = "Semanal" });
            ListFrequencia.Add(new Frequencia() { QntdParcela = 15, Descricao = "A cada 15 dias" });
            ListFrequencia.Add(new Frequencia() { QntdParcela = 30, Descricao = "Mensal" });
            ListFrequencia.Add(new Frequencia() { QntdParcela = 60, Descricao = "Bimestral" });
            ListFrequencia.Add(new Frequencia() { QntdParcela = 91, Descricao = "Trimestral" });
            ListFrequencia.Add(new Frequencia() { QntdParcela = 182, Descricao = "Semestral" });
            ListFrequencia.Add(new Frequencia() { QntdParcela = 365, Descricao = "Anual" });
        }
    }
}
