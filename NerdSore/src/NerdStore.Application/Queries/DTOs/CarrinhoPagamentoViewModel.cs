using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Vendas.Application.Queries.DTOs
{
    public class CarrinhoPagamentoViewModel
    {
        public string NomeCartao { get; set; }
        public string NumeroCartao { get; set; }
        public string ExpiracaoCartao { get; set; }
        public string CvvCartao { get; set; }
    }
}
