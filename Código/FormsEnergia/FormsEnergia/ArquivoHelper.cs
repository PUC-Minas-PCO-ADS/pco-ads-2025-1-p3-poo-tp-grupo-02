using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FormsEnergia
{
    public static class ArquivoHelper
    {
        private static readonly JsonSerializerSettings settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Auto,
            Formatting = Formatting.Indented
        };

        public static List<Pessoa> CarregarDados(string caminhoArquivo)
        {
            if (!File.Exists(caminhoArquivo)) return new List<Pessoa>();

            try
            {
                var json = File.ReadAllText(caminhoArquivo);
                return JsonConvert.DeserializeObject<List<Pessoa>>(json, settings) ?? new List<Pessoa>();
            }
            catch
            {
                // Em caso de erro na leitura ou deserialização
                return new List<Pessoa>();
            }
        }

        public static void SalvarDados(List<Pessoa> pessoas, string caminhoArquivo)
        {
            var json = JsonConvert.SerializeObject(pessoas, settings);
            File.WriteAllText(caminhoArquivo, json);
        }
    }
}
