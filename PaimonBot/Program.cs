// See https://aka.ms/new-console-template for more information

using DSharpPlus;
using DSharpPlus.CommandsNext;
using PaimonBot.Commands;

Console.WriteLine("Starting bot process...");
MainAsync().GetAwaiter().GetResult();

static async Task MainAsync()
{
    var discord = new DiscordClient(new DiscordConfiguration()
    {
        Token = "OTgyNzg5ODI0MjQ1Mjg4OTcw.GzuS-8.U8CB-rE7QtDFApVim7SVnpx6h63nDdkpRdKXIs",
        TokenType = TokenType.Bot
    });
    
    var commands = discord.UseCommandsNext(new CommandsNextConfiguration()
    {
        StringPrefixes = new[] { "!" }
    });
    
    commands.RegisterCommands<WeebsModule>();
    
    await discord.ConnectAsync();
    await Task.Delay(-1);
}