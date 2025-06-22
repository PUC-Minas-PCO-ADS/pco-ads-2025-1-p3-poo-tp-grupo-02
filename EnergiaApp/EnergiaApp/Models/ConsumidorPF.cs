// Models/ConsumidorPF.cs
namespace EnergiaApp.Models
{
    public class ConsumidorPF : ConsumidorBase
    {
        public ConsumidorPF(string cpf)
        {
            Identificador = cpf;
        }
    }
}
