// Models/ConsumidorBase.cs
using System.Collections.Generic;

namespace EnergiaApp.Models
{
    public abstract class ConsumidorBase : IConsumidor
    {
        public string Identificador { get; protected set; }
        protected List<IConta> Contas { get; set; } = new List<IConta>();

        public void AdicionarConta(IConta conta)
        {
            Contas.Add(conta);
        }

        public List<IConta> ObterContas()
        {
            return Contas;
        }
    }
}
