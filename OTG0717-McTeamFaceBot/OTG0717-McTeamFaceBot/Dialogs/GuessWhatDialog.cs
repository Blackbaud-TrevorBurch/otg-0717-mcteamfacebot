using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Dialogs;
using System.Threading.Tasks;

namespace OTG0717_McTeamFaceBot.Dialogs
{
    [Serializable]
    public class GuessWhatDialog : IDialog<object>
    {
        public async Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);
        }

        public virtual async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var message = await result;
            if (message.Text.ToLower().Contains("guess what"))
            {
                await context.PostAsync("chicken butt!!");
            }
        }


    }
}