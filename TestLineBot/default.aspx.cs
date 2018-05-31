using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestLineBot
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "/P9PjPSbe2fsvsz0LEB1/yoIBxz4qLV5H8RfpGmXmgEi67nzwBlsXvNSTagzwFC8ez1J5Ui6HkjnjKg0cw0Tby9tBI/dfODff2CFn2IMBFNUqBKlpcw9bu5T+ygnWkq3cip1ZLQ8eL+l1ajShTqG7wdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId= "Uc9d21bb74f13334be35b46b6581b9416";

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
            bot.PushMessage(AdminUserId, 1,2);
        }
    }
}