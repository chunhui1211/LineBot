 using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestLineBot.Controllers
{
    public class LineBotWebHookController : isRock.LineBot.LineWebHookControllerBase
    {
        const string channelAccessToken = "";
        const string AdminUserId= "";

        [Route("api/LineWebHookSample")]
        [HttpPost]
        public IHttpActionResult POST()
        {
            try
            {
                //設定ChannelAccessToken(或抓取Web.Config)
                this.ChannelAccessToken = channelAccessToken;
                //取得Line Event(範例，只取第一個)
                var LineEvent = this.ReceivedMessage.events.FirstOrDefault();
                //配合Line verify  replyToken 回復訊息用的
                if (LineEvent.replyToken == "00000000000000000000000000000000") return Ok();
                //回覆訊息
                isRock.LineBot.Bot bot = new isRock.LineBot.Bot(channelAccessToken);
                //var UserInfo = bot.GetUserInfo(LineEvent.source.userId);
                //this.GetUserInfo(LineEvent.source.userId);

                if (LineEvent.type == "message")
                {
                    if (LineEvent.message.type == "text") //收到文字
                    {
                        if (LineEvent.message.text == "你的名字")
                        {
                            this.ReplyMessage(LineEvent.replyToken, "嘟少爺");
                        }
                        else if (LineEvent.message.text == "你會幹嘛")
                        {
                            this.ReplyMessage(LineEvent.replyToken, "我可以回答你任何問題。");
                        }
                        else if (LineEvent.message.text == "你最愛誰")
                        {
                            this.ReplyMessage(LineEvent.replyToken, "我最愛你了");
                        }
                        //else
                        //{
                        //    this.ReplyMessage(LineEvent.replyToken, "旺旺旺");
                        //}

                    }
                    //if (LineEvent.message.type == "sticker") //收到貼圖
                    //    this.ReplyMessage(LineEvent.replyToken, 1, 2);
                    //if (LineEvent.message.type == "location") //GPS
                    //    this.ReplyMessage(LineEvent.replyToken, $"你的位置在{LineEvent.message.latitude},{LineEvent.message.longitude}");
                    //if (LineEvent.message.type == "image")
                    //{
                    //    var bytes = this.GetUserUploadedContent(LineEvent.message.id);//取得圖片Bytes
                    //    var guid = Guid.NewGuid().ToString();//儲存為圖檔
                    //    var filename = $"{guid}.png";
                    //    var path = System.Web.Hosting.HostingEnvironment.MapPath("~/temp/");
                    //    System.IO.File.WriteAllBytes(path + filename, bytes);
                    //    var baseUrl = Request.RequestUri.GetLeftPart(UriPartial.Authority);//取得 base URL
                    //    var url = $"{baseUrl}/temp/{filename}";//組出外部可以讀取的檔名
                    //    this.ReplyMessage(LineEvent.replyToken, $"你的圖片位於\n{url}");
                    //}
                }
                if (LineEvent.type == "postback")
                {
                    var data = LineEvent.postback.data;
                    this.ReplyMessage(LineEvent.replyToken, $"觸發了postback\n資料為:{data}");
                    //var dt = LineEvent.postback.Params.date;
                    //this.ReplyMessage(LineEvent.replyToken, $"觸發了postback\n資料為:{data}\n選擇結果:{dt}");
                }
                //response OK
                return Ok();
            }
            catch (Exception ex)
            {
                //如果發生錯誤，傳訊息給Admin
                this.PushMessage(AdminUserId, "發生錯誤:\n" + ex.Message);
                //response OK
                return Ok();
            }
        }
    }
}
