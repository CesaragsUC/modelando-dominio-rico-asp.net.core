using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Pagamentos.AntiCorruption.Interfaces
{
    public interface IConfigurationManager
    {
        string GetValue(string node);
    }
}
