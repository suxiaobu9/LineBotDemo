using isRock.LineBot;
using LineBotDemo.Attribute;
using LineBotDemo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

/// <summary>
/// ngrok http 63996 -host-header=”localhost:63996" -region ap
/// </summary>
namespace LineBotDemo.Controllers
{
    [Route("api/[controller]")]
    public class LineBotController : isRock.LineBot.LineWebHookControllerBase
    {
        public LineBotController(IOptions<LineBot> lintBot)
        {
            _lineBot = lintBot.Value;
            this.ChannelAccessToken = _lineBot.ChannelAccessToken;
        }

        private readonly LineBot _lineBot;

        [HttpPost]
        [LineVerifySignature]
        public IActionResult Post()
        {
            try
            {
                foreach (var lineEvent in this.ReceivedMessage.events)
                {
                    if (lineEvent == null ||
                        lineEvent.replyToken == "00000000000000000000000000000000")
                        return Ok();

                    //準備回覆訊息
                    if (lineEvent.type.ToLower() != "message" || lineEvent.message.type != "text")
                        return Ok();

                    switch (lineEvent.message.text.ToLower())
                    {
                        case "/quickreply":
                            var quickReplyMsg = new TextMessage("拒絕融資推銷");
                            quickReplyMsg.quickReply.items.AddRange(new QuickReplyItemBase[]
                            {
                                new QuickReplyMessageAction("不需要","不需要"),
                                new QuickReplyMessageAction("再見","再見"),
                                new QuickReplyMessageAction("我超有錢","我超有錢"),
                                new QuickReplyDatetimePickerAction("選擇時間",DateTime.Now.ToString("yyyy-MM-dd"),DatetimePickerModes.date),
                                new QuickReplyPostbackAction("PostBack Data 1","Quick Reply PostBack Data","顯示的文字",""),
                                new QuickReplyPostbackAction("PostBack Data 2","Quick Reply PostBack Data","",""),
                                new QuickReplyLocationAction("地點")
                            });
                            this.ReplyMessage(lineEvent.replyToken, quickReplyMsg);
                            break;
                        case "/imagemap":
                            var imgmapMsg = new ImagemapMessage
                            {
                                baseUrl = new Uri(@"https://i.imgur.com/7pxFJW8.jpg"),
                                baseSize = new System.Drawing.Size(816, 649)
                            };
                            var largeNumber = new string[] { "壹", "貳", "參", "肆", "伍", "陸", "漆", "捌", "玖" };

                            var address = new List<List<int>>
                            {
                                new List<int>{ 666, 111, 90, 90 },
                                new List<int>{ 719, 287, 90, 90 },
                                new List<int>{ 655, 458, 90, 90 },
                                new List<int>{ 490, 561, 90, 90 },
                                new List<int>{ 265, 568, 90, 90 },
                                new List<int>{ 79, 465, 90, 90 },
                                new List<int>{ 30, 283, 90, 90 },
                                new List<int>{ 56, 105, 90, 90 },
                                new List<int>{ 357, 341, 90, 90 },
                            };

                            for (var i = 0; i < largeNumber.Length && i < address.Count; i++)
                            {
                                imgmapMsg.actions.Add(new ImagemapMessageAction
                                {
                                    text = largeNumber[i],
                                    area = new ImagemapArea(address[i][0], address[i][1], address[i][2], address[i][3])
                                });
                            }
                            imgmapMsg.actions.Add(new ImagemapUriAction { linkUri = new Uri(@"https://i.imgur.com/7pxFJW8.jpg"), area = new ImagemapArea(297, 71, 234, 201) });
                            this.ReplyMessage(lineEvent.replyToken, imgmapMsg);
                            break;
                        case "/flexmessage":

                            //定義一則訊息
                            var baseFlexMessages = @"
                            [
                                {
                                    ""type"": ""text"",
                                    ""text"": ""來源 : $source$""
                                },
                                {
                                    ""type"": ""flex"",
                                    ""altText"": ""Sample Flex Message"",
                                    ""contents"": $flex$
                                }
                            ]";

                            var flexMessage = baseFlexMessages.Replace("$flex$", SampleFlexMessage.Sample1)
                                                              .Replace("$source$", SampleFlexMessage.Source1);

                            this.ReplyMessageWithJSON(lineEvent.replyToken, flexMessage);

                            break;
                        case "/flexmessage2":

                            //定義一則訊息
                            var baseFlexMessages2 = @"
                            [
                                {
                                    ""type"": ""text"",
                                    ""text"": ""來源 : $source$""
                                },
                                {
                                    ""type"": ""flex"",
                                    ""altText"": ""Sample Flex Message"",
                                    ""contents"": $flex$
                                }
                            ]";

                            var flexMessage2 = baseFlexMessages2.Replace("$flex$", SampleFlexMessage.Sample2)
                                                              .Replace("$source$", SampleFlexMessage.Source2);

                            this.ReplyMessageWithJSON(lineEvent.replyToken, flexMessage2);

                            break;
                        case "/lineurlscheme":
                            this.ReplyMessage(lineEvent.replyToken, "https://developers.line.biz/en/docs/messaging-api/using-line-url-scheme/#available-line-url-schemes");
                            break;
                        case "/liff":
                            //var liff = isRock.LIFF.Utility.AddLiffApp(_lineBot.ChannelAccessToken, new Uri("https://bu9lifftest.azurewebsites.net"), isRock.LIFF.ViewType.full);
                            this.ReplyMessage(lineEvent.replyToken, "line://app/1655852489-2yE1NxMX");
                            break;
                        case "/templatemessage":
                            var templateAction = new List<TemplateActionBase>();
                            templateAction.AddRange(new TemplateActionBase[]
                            {
                                new MessageAction
                                {
                                    label = "回覆訊息",
                                    text = "測試訊息"
                                },
                                new UriAction
                                {
                                    label = "開啟網頁",
                                    uri = new Uri("https://www.google.com.tw/")
                                },
                                new PostbackAction
                                {
                                    label = "PostBack",
                                    data = "Postback Data"
                                }
                            });
                            var buttomTemplate = new ButtonsTemplate
                            {
                                altText = "無法顯示",
                                text = "測試text",
                                title = "測試title",
                                thumbnailImageUrl = new Uri(@"https://i.imgur.com/7pxFJW8.jpg"),
                                actions = templateAction //設定回覆動作
                            };
                            this.ReplyMessage(lineEvent.replyToken, buttomTemplate);
                            break;
                        case "/templatemessage2":
                            var templateAction2 = new List<TemplateActionBase>();
                            templateAction2.AddRange(new TemplateActionBase[]
                            {
                                new MessageAction
                                {
                                    label = "回覆訊息",
                                    text = "測試訊息"
                                },
                                new UriAction
                                {
                                    label = "開啟網頁",
                                    uri = new Uri("https://www.google.com.tw/")
                                },
                                new PostbackAction
                                {
                                    label = "PostBack",
                                    data = "Postback Data"
                                }
                            });
                            var carouseTemplate2 = new CarouselTemplate
                            {
                                altText = "無法顯示",
                                columns = new List<Column>
                                {
                                    new Column
                                    {
                                        actions = templateAction2,
                                        text = "測試text",
                                        title = "測試title",
                                        thumbnailImageUrl = new Uri(@"https://i.imgur.com/7pxFJW8.jpg")
                                    },
                                    new Column
                                    {
                                        actions = templateAction2,
                                        text = "測試text",
                                        title = "測試title",
                                        thumbnailImageUrl = new Uri(@"https://i.imgur.com/7pxFJW8.jpg")
                                    },
                                    new Column
                                    {
                                        actions = templateAction2,
                                        text = "測試text",
                                        title = "測試title",
                                        thumbnailImageUrl = new Uri(@"https://i.imgur.com/7pxFJW8.jpg")
                                    }
                                }

                            };
                            this.ReplyMessage(lineEvent.replyToken, carouseTemplate2);
                            break;
                        case "/templatemessage3":
                            var templateAction3 = new List<TemplateActionBase>();
                            templateAction3.AddRange(new TemplateActionBase[]
                            {

                                new UriAction
                                {
                                    label = "開啟網頁",
                                    uri = new Uri("https://www.google.com.tw/")
                                },
                                new PostbackAction
                                {
                                    label = "PostBack",
                                    data = "Postback Data"
                                }
                            });
                            var confirmTemplate = new ConfirmTemplate
                            {
                                altText = "無法顯示",
                                text = "測試text",
                                actions = templateAction3
                            };
                            this.ReplyMessage(lineEvent.replyToken, confirmTemplate);
                            break;
                        default:
                            return Ok();
                    }
                }
            }
            catch (Exception ex)
            {
                this.PushMessage(_lineBot.AdminUserId, "發生錯誤:\n" + ex.Message);
            }

            return Ok();
        }


    }
}
