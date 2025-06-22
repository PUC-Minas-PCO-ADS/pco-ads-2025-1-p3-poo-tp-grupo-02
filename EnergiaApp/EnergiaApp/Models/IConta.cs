using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergiaApp.Models
{
    public interface IConta
    {
        double CalcularConsumo();
        double CalcularValorComImpostos();
        double CalcularValorSemImpostos();
        string GetResumoConta();
    }
}
