// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.3.0

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using Microsoft.Bot.Connector;


namespace EchoBotAppBots.Bots
{
    public class EchoBot : ActivityHandler
    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            await turnContext.SendActivityAsync(MessageFactory.Text($"Echo: {turnContext.Activity.Text}"), cancellationToken);
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text($"Hello and Welcome!"), cancellationToken);
                }
            }
        }

        public async Task StartAsync(IDialogContext context)
        {

        }

        private readonly IDictionary<string, string> options = new Dictionary<string, string>
        {
            { "1", "1. Attach Local-Image " },
            { "2", "2. Attach Internet Image" },
            { "3", "3. File Attachment" },
            { "4", "4. Get local PDF" },
            { "5", "5. Video Attachment" },
            { "6", "6. Youtube video Attachment" },
            { "7", "7. MP3 Attachment" },
        };

        public async virtual Task MessageReceivedAsync(IDialogContext context, iawaita)
        {

        }
    }
}
