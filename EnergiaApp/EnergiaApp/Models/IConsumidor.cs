using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergiaApp.Models
{
    public interface IConsumidor
    {
        string Identificador { get; }
        void AdicionarConta(IConta conta);
        List<IConta> ObterContas();
    }
}
