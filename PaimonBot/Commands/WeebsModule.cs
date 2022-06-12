using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

namespace PaimonBot.Commands;

public class WeebsModule : BaseCommandModule
{
    [Command("anime")]
    public async Task AnimeCommand(CommandContext ctx, string source, string title)
    {
        ctx.Message.Attachments
    }
}