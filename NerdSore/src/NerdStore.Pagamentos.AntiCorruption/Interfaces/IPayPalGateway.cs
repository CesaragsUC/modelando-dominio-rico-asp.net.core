using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Pagamentos.AntiCorruption.Interfaces
{
    public interface IPayPalGateway
    {
        string GetPayPalServiceKey(string apiKey, string encriptionKey);
        string GetCardHashKey(string serviceKey, string cartaoCredito);
        bool CommitTransaction(string cardHashKey, string orderId, decimal amount);
    }
}
