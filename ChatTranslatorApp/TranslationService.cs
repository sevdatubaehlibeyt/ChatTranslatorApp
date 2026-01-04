using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

public class TranslationService
{
    private readonly HttpClient client = new HttpClient();

    private readonly Dictionary<string, string> langCodes = new Dictionary<string, string>()
    {
        { "Türkçe", "TR" },
        { "İngilizce", "EN" },
        { "Almanca", "DE" },
        { "İtalyanca", "IT" },
        { "Arapça", "AR" },
        { "Korece", "KO" }
    };

    public async Task<string> TranslateAsync(string text, string fromLang, string toLang)
    {
        string from = langCodes[fromLang];
        string to = langCodes[toLang];

        string url = $"https://api.mymemory.translated.net/get?q={Uri.EscapeDataString(text)}&langpair={from}|{to}";

        var response = await client.GetStringAsync(url);
        var json = JObject.Parse(response);

        return json["responseData"]["translatedText"]?.ToString();
    }
}
