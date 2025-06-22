using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnergiaApp.Models;

namespace EnergiaApp.Services
{
    public interface IArquivoService
    {
        void Salvar(List<IConsumidor> consumidores, string caminho);
        List<IConsumidor> Carregar(string caminho);
    }
}
