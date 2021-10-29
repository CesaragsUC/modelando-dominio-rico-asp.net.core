using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Pagamentos.Business.Entities
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public decimal Valor { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
