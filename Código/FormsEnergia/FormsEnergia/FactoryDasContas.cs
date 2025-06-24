using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsEnergia
{
    public static class ContaFactory
    {
        public static Conta CriarConta(string tipoConta)
        {
            if (tipoConta.ToLower() == "residencial")
            {
                return new ContaResidencial();
            }
            else if (tipoConta.ToLower() == "comercial")
            {
                return new ContaComercial();
            }
            else
            {
                throw new ArgumentException("Tipo de conta inválido.");
            }
        }

    }
}
