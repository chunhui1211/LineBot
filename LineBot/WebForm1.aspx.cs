using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace LineBot
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("/P9PjPSbe2fsvsz0LEB1/yoIBxz4qLV5H8RfpGmXmgEi67nzwBlsXvNSTagzwFC8ez1J5Ui6HkjnjKg0cw0Tby9tBI/dfODff2CFn2IMBFNUqBKlpcw9bu5T+ygnWkq3cip1ZLQ8eL+l1ajShTqG7wdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage("Uc9d21bb74f13334be35b46b6581b9416", "testxxxx");
           // bot.PushMessage("Uc9d21bb74f13334be35b46b6581b9416", 1,2);

        }
    }
}