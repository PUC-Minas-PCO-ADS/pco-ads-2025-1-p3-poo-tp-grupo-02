// Models/ConsumidorPJ.cs
namespace EnergiaApp.Models
{
    public class ConsumidorPJ : ConsumidorBase
    {
        public ConsumidorPJ(string cnpj)
        {
            Identificador = cnpj;
        }
    }
}
