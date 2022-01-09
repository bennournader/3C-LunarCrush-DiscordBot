using System;
using System.Linq;
using XCommas.Net;
using XCommas.Net.Objects;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Text;
using Discord;
using Discord.WebSocket;

    public class BotInfo
    {
    private int _botId;
    private int _max_ar;
    private int _max_gs;
    private int _accountId;
    private string _market;
    private string _baseType;
    private bool _futures;
    public BotInfo(int accountID,int botId, int max_ar, int max_gs, string market, string baseType, bool futures)
    {
        _botId = botId;
        _max_ar = max_ar;
        _max_gs = max_gs;
        _accountId = accountID;
        _market = market;
        _baseType = baseType;
        _futures = futures;
    }
    public int getAccountID()
    {
        return _accountId;
    }
    public void setAccountID(int accountId)
    {
        _accountId = accountId;
    }
    public int getBotId()
    {
        return _botId;
    }
    public void setBotID(int botId)
    {
        _botId = botId;
    }

    public int getMax_ar()
    {
        return _max_ar;
    }
    public void setMax_ar(int max_ar)
    {
        _max_ar = max_ar;
    }

    public int getMax_gs()
    {
        return _max_gs;
    }
    public void setMax_gs(int max_gs)
    {
        _max_gs = max_gs;
    }
    public string getMarket()
    {
        return _market;
    }
    public void setMarket(string market)
    {
        _market = market;
    }
    public string getBaseType()
    {
        return _baseType;
    }
    public void setBaseType(string basetype)
    {
        _baseType= basetype;
    }
    public bool getFutures()
    {
        return _futures;
    }
    public void setFutures(bool futures)
    {
        _futures = futures;
    }


}
