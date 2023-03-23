using Microsoft.Extensions.Configuration;

namespace DiscordCrawlerBot;

internal class Program
{
    private static string _token;

    static void Main(string[] args)
    {
        var cfg = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
        _token = cfg["CrawlerDiscord"];
    }
}