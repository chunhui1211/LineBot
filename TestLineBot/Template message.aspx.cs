﻿using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TestLineBot
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        const string channelAccessToken = "";
        const string AdminUserId = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 1, 2);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageAction() { label = "標題-文字回覆", text = "回復文字" });
            actions.Add(new isRock.LineBot.UriAction() { label = "標題-開啟URL", uri = new Uri("http://www.google.com") });
            actions.Add(new isRock.LineBot.PostbackAction() { label = "標題-發生Postback", data = "abc=aaa&def=111" });
            var ButtonTempalteMsg = new isRock.LineBot.ButtonsTemplate()
            {
                title="選項",
                text="請選擇其中之一",
                altText="請在手機上檢視",
                thumbnailImageUrl= new Uri("https://github.com/chunhui1211/BuildSchool2018/blob/master/Bootstrap/Image/S__81010694.jpg?raw=true"),
                actions=actions
            };
            bot.PushMessage(AdminUserId, ButtonTempalteMsg);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageAction() { label = "Yes", text = "Yes" });
            actions.Add(new isRock.LineBot.MessageAction() { label = "No", text = "No" });
            var ButtonTempalteMsg = new isRock.LineBot.ConfirmTemplate()
            {
                text = "請選擇其中之一",
                altText = "請在手機上檢視",
                actions = actions
            };
            bot.PushMessage(AdminUserId, ButtonTempalteMsg);
        }
    }
}