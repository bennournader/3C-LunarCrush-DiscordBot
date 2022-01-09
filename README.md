                                          **3commas BotAssistant Discord Bot**
Updates a 3Commas composite bot's pairs based on lunarcrush's altrank and galaxy scores directly through discord commands. Use $help to see the possible commands.

Create a new C# console program and add XCommas.Net and Discord.Net nuget package and paste all the files into project directory.

Update 3commas key, 3Commas secret, Discord channel id, Discord server id, Discord token variables.

**Useful Commands:**

• **$addBA**: Adds a new bot to Bot Assistant:
 $addBA {AccountID} {BotID} {max_altrank} {max_galaxyscore} {market: binance/ftx} {baseType: ETH/USDT/USD} {futures true or false} 
 
• **$removeBA:** Removes a bot fom Bot Assistant: $removeBA {BotID} 

• **$clear:** Clears discord channel chat: $clear {number of messages to delete} 

• **$run:** Refresh Bot Assistant: $run



By default it runs every 5 min you can update that according to your needs.

Credits to https://github.com/jay23606

Author Discord: Nader#4311

_Works on binance / binance futures / ftx / ftx futures / kucoin_
