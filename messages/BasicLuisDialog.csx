using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

// For more information about this template visit http://aka.ms/azurebots-csharp-luis
[Serializable]
public class BasicLuisDialog : LuisDialog<object>
{
    public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute(Utils.GetAppSetting("LuisAppId"), Utils.GetAppSetting("LuisAPIKey"))))
    {
    }

    [LuisIntent("None")]
    public async Task NoneIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the none intent! You said: {result.Query}");
        context.Wait(MessageReceived);
    }

    [LuisIntent("GuessWhat")]
    public async Task GuessWhat(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Chicken Butt");
        context.Wait(MessageReceived);
    }

    [LuisIntent("GivingAmount")]
    public async Task GivingAmount(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"{result.Entities.Where(enitity => entity === "constituentName").First()} has given $40.");
        context.Wait(MessageReceived);
    }
}