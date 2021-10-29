using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Pagamentos.Business.Entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }
}
