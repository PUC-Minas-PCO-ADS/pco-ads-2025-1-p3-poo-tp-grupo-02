using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using pco_ads_2025_1_p3_poo_tp_grupo_02;

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

        var json = File.ReadAllText(caminhoArquivo);
        return JsonConvert.DeserializeObject<List<Pessoa>>(json, settings) ?? new List<Pessoa>();
    }

    public static void SalvarDados(List<Pessoa> pessoas, string caminhoArquivo)
    {
        var json = JsonConvert.SerializeObject(pessoas, settings);
        File.WriteAllText(caminhoArquivo, json);
    }
}