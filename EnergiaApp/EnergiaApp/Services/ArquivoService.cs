// Services/ArquivoService.cs
using EnergiaApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace EnergiaApp.Services
{
    public class ArquivoService : IArquivoService
    {
        public void Salvar(List<IConsumidor> consumidores, string caminho)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(consumidores, options);
                File.WriteAllText(caminho, json);
                Console.WriteLine($"Salvando arquivo em: {caminho}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }

        }

        public List<IConsumidor> Carregar(string caminho)
        {
            try
            {
                string json = File.ReadAllText(caminho);
                var consumidores = JsonSerializer.Deserialize<List<ConsumidorBase>>(json);
                return new List<IConsumidor>(consumidores);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar: {ex.Message}");
                return new List<IConsumidor>();
            }
        }
    }
}
