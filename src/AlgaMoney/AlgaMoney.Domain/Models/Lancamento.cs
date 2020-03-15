using System;
using System.Collections.Generic;
using System.Text;

namespace AlgaMoney.Domain.Models
{
    public class Lancamento
    {
        public long Id { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public decimal Valor { get; private set; }
        public string Observao { get; private set; }
        public long IdCategoria { get; private set; }
        public long IdTipoLancamento { get; private set; }
    }
}
