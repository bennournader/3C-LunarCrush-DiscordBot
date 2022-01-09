using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("run")]
        public async Task Run()
        {
            await ReplyAsync("Refreshing bot assistant ...");
            Program.MainAsync().GetAwaiter().GetResult();
        }
    [Command("addBA")]
    public async Task AddBA(params string[] args)
    {
        if (args.Length == 0 || args.Length < 7)
        {
            await ReplyAsync("Input Full Bot Details");
            return;
        }
        int accountId = int.Parse(args[0]);
        int botId = int.Parse(args[1]);
        int maxar = int.Parse(args[2]);
        int maxgs = int.Parse(args[3]);
        string market = args[4];
        string basetype = args[5];
        bool futures = bool.Parse(args[6]);

        Program.biList.Add(new BotInfo(accountId, botId, maxar, maxgs, market, basetype, futures));

        await ReplyAsync("Your Bot: " + botId + " **successfully Added** :sunglasses:");

        Program.MainAsync().GetAwaiter().GetResult();
    }

    [Command("help")]
        public async Task help()
        {
            await ReplyAsync(":exclamation: **Useful Commands** :exclamation: \n" +
                "> • $addBA: *Adds a new bot to Bot Assistant*: " +
                "  \n **$addBA {AccountID} {BotID} {max_altrank} {max_galaxyscore} {market: binance/ftx} {baseType: ETH/USDT/USD} {futures true or false}** \n " + 
                "> • $removeBA: *Removes a bot fom Bot Assistant*: **$removeBA {BotID}** \n " +
                "> • $clear: *Clears discord channel chat*: **$clear {number of messages to delete}** \n " +
                "> • $run: *Refresh Bot Assistant*: **$run** ");
        }


        [Command("removeBA")]
        public async Task removeBA(params string[] args)
        {
            if (args.Length == 0 || !int.TryParse(args[0], out int BotID))
            {
                await ReplyAsync("Input Bot ID");
                return;
            }
            int index=0;
            for(int i=0; i < Program.biList.Count; i++)
            {
                if (Program.biList[i].getBotId()==int.Parse(args[0]))
                {
                    index = i;
                }
            }

            Program.biList.RemoveAt(index);
            await ReplyAsync($"Your Bot: {BotID}" + " **successfully removed** :sunglasses:");
            Program.MainAsync().GetAwaiter().GetResult();
        }

        [Command("clear", RunMode = RunMode.Async)]
        [Summary("Deletes the specified amount of messages.")]
        [RequireUserPermission(GuildPermission.Administrator)]
        [RequireBotPermission(ChannelPermission.ManageMessages)]
        public async Task PurgeChat(uint amount)
        {
            IEnumerable<IMessage> messages = await Context.Channel.GetMessagesAsync((int)(amount + 1)).FlattenAsync();
            await ((ITextChannel)Context.Channel).DeleteMessagesAsync(messages);
            const int delay = 3000;
            IUserMessage m = await ReplyAsync($"I have deleted {amount} messages for you :smile:");
            await Task.Delay(delay);
            await m.DeleteAsync();
        }

  


}