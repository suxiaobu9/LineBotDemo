using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LineBotDemo.Model
{
    public class SampleFlexMessage
    {
        public static string Source1 => @"https://gist.github.com/PamornT/086a249fad9b99a6d49db4b1b57ee116";
        public static string Sample1 => @"
{
  ""type"": ""bubble"",
  ""size"": ""mega"",
  ""header"": {
    ""type"": ""box"",
    ""layout"": ""vertical"",
    ""contents"": [
      {
        ""type"": ""box"",
        ""layout"": ""vertical"",
        ""contents"": [
          {
            ""type"": ""text"",
            ""text"": ""FROM"",
            ""color"": ""#ffffff66"",
            ""size"": ""sm""
          },
          {
            ""type"": ""text"",
            ""text"": ""這邊"",
            ""color"": ""#ffffff"",
            ""size"": ""xl"",
            ""flex"": 4,
            ""weight"": ""bold""
          }
        ]
      },
      {
    ""type"": ""box"",
        ""layout"": ""vertical"",
        ""contents"": [
          {
        ""type"": ""text"",
            ""text"": ""TO"",
            ""color"": ""#ffffff66"",
            ""size"": ""sm""
          },
          {
        ""type"": ""text"",
            ""text"": ""那邊"",
            ""color"": ""#ffffff"",
            ""size"": ""xl"",
            ""flex"": 4,
            ""weight"": ""bold""
          }
        ]
      }
    ],
    ""paddingAll"": ""20px"",
    ""backgroundColor"": ""#0367D3"",
    ""spacing"": ""md"",
    ""height"": ""154px"",
    ""paddingTop"": ""22px""
  },
  ""body"": {
    ""type"": ""box"",
    ""layout"": ""vertical"",
    ""contents"": [
      {
        ""type"": ""box"",
        ""layout"": ""horizontal"",
        ""contents"": [
          {
            ""type"": ""text"",
            ""text"": ""Jul 19, 2019"",
            ""size"": ""sm"",
            ""gravity"": ""center"",
            ""align"": ""end""
          },
          {
            ""type"": ""box"",
            ""layout"": ""vertical"",
            ""contents"": [
              {
                ""type"": ""filler""
              },
              {
                ""type"": ""box"",
                ""layout"": ""vertical"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": ""📄""
                  }
                ],
                ""cornerRadius"": ""30px"",
                ""height"": ""20px"",
                ""width"": ""20px"",
                ""offsetStart"": ""7px""
              },
              {
                ""type"": ""filler""
              }
            ],
            ""flex"": 0,
            ""backgroundColor"": ""#848484"",
            ""width"": ""30px"",
            ""height"": ""30px"",
            ""cornerRadius"": ""30px""
          },
          {
            ""type"": ""text"",
            ""text"": ""訂單狀態"",
            ""gravity"": ""center"",
            ""flex"": 1,
            ""size"": ""sm""
          }
        ],
        ""spacing"": ""lg"",
        ""cornerRadius"": ""30px"",
        ""margin"": ""xl""
      },
      {
        ""type"": ""box"",
        ""layout"": ""horizontal"",
        ""contents"": [
          {
            ""type"": ""box"",
            ""layout"": ""baseline"",
            ""contents"": [
              {
                ""type"": ""text"",
                ""text"": ""18:12:26"",
                ""size"": ""xs"",
                ""color"": ""#8c8c8c"",
                ""align"": ""end""
              }
            ],
            ""flex"": 2
          },
          {
            ""type"": ""box"",
            ""layout"": ""vertical"",
            ""contents"": [
              {
                ""type"": ""box"",
                ""layout"": ""horizontal"",
                ""contents"": [
                  {
                    ""type"": ""filler""
                  },
                  {
                    ""type"": ""box"",
                    ""layout"": ""vertical"",
                    ""contents"": [
                      {
                        ""type"": ""filler""
                      }
                    ],
                    ""width"": ""2px"",
                    ""backgroundColor"": ""#B7B7B7""
                  },
                  {
                    ""type"": ""filler""
                  }
                ],
                ""flex"": 1
              }
            ],
            ""width"": ""30px""
          },
          {
            ""type"": ""text"",
            ""text"": ""成立訂單"",
            ""gravity"": ""top"",
            ""flex"": 2,
            ""size"": ""xs"",
            ""color"": ""#8c8c8c""
          }
        ],
        ""spacing"": ""lg"",
        ""height"": ""40px""
      },
      {
        ""type"": ""box"",
        ""layout"": ""horizontal"",
        ""contents"": [
          {
            ""type"": ""text"",
            ""text"": ""Jul 20, 2019"",
            ""size"": ""sm"",
            ""gravity"": ""center"",
            ""align"": ""end""
          },
          {
            ""type"": ""box"",
            ""layout"": ""vertical"",
            ""contents"": [
              {
                ""type"": ""filler""
              },
              {
                ""type"": ""box"",
                ""layout"": ""vertical"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": ""🚚""
                  }
                ],
                ""cornerRadius"": ""30px"",
                ""height"": ""20px"",
                ""width"": ""20px"",
                ""offsetStart"": ""7px""
              },
              {
                ""type"": ""filler""
              }
            ],
            ""flex"": 0,
            ""backgroundColor"": ""#A9D0F5"",
            ""width"": ""30px"",
            ""height"": ""30px"",
            ""cornerRadius"": ""30px""
          },
          {
            ""type"": ""text"",
            ""text"": ""運輸狀態"",
            ""gravity"": ""center"",
            ""flex"": 1,
            ""size"": ""xs""
          }
        ],
        ""cornerRadius"": ""30px"",
        ""spacing"": ""lg""
      },
      {
        ""type"": ""box"",
        ""layout"": ""horizontal"",
        ""contents"": [
          {
            ""type"": ""box"",
            ""layout"": ""baseline"",
            ""contents"": [
              {
                ""type"": ""text"",
                ""text"": ""15:12:26"",
                ""size"": ""xs"",
                ""color"": ""#8c8c8c"",
                ""align"": ""end""
              }
            ],
            ""flex"": 2
          },
          {
            ""type"": ""box"",
            ""layout"": ""vertical"",
            ""contents"": [
              {
                ""type"": ""box"",
                ""layout"": ""horizontal"",
                ""contents"": [
                  {
                    ""type"": ""filler""
                  },
                  {
                    ""type"": ""box"",
                    ""layout"": ""vertical"",
                    ""contents"": [
                      {
                        ""type"": ""filler""
                      }
                    ],
                    ""width"": ""2px"",
                    ""backgroundColor"": ""#B7B7B7""
                  },
                  {
                    ""type"": ""filler""
                  }
                ],
                ""flex"": 1
              }
            ],
            ""width"": ""30px""
          },
          {
            ""type"": ""text"",
            ""text"": ""取件完成"",
            ""gravity"": ""top"",
            ""flex"": 2,
            ""size"": ""xs"",
            ""color"": ""#8c8c8c""
          }
        ],
        ""spacing"": ""lg"",
        ""height"": ""40px""
      },
      {
        ""type"": ""box"",
        ""layout"": ""horizontal"",
        ""contents"": [
          {
            ""type"": ""text"",
            ""text"": ""Jul 20, 2019"",
            ""size"": ""sm"",
            ""gravity"": ""center"",
            ""align"": ""end""
          },
          {
            ""type"": ""box"",
            ""layout"": ""vertical"",
            ""contents"": [
              {
                ""type"": ""filler""
              },
              {
                ""type"": ""box"",
                ""layout"": ""vertical"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": ""🚚""
                  }
                ],
                ""cornerRadius"": ""30px"",
                ""height"": ""20px"",
                ""width"": ""20px"",
                ""offsetStart"": ""7px""
              },
              {
                ""type"": ""filler""
              }
            ],
            ""flex"": 0,
            ""backgroundColor"": ""#A9D0F5"",
            ""width"": ""30px"",
            ""height"": ""30px"",
            ""cornerRadius"": ""30px""
          },
          {
            ""type"": ""text"",
            ""text"": ""運輸狀態"",
            ""gravity"": ""center"",
            ""flex"": 1,
            ""size"": ""xs""
          }
        ],
        ""cornerRadius"": ""30px"",
        ""spacing"": ""lg""
      },
      {
        ""type"": ""box"",
        ""layout"": ""horizontal"",
        ""contents"": [
          {
            ""type"": ""box"",
            ""layout"": ""baseline"",
            ""contents"": [
              {
                ""type"": ""text"",
                ""text"": ""19:34:00"",
                ""size"": ""xs"",
                ""color"": ""#8c8c8c"",
                ""align"": ""end""
              }
            ],
            ""flex"": 2
          },
          {
            ""type"": ""box"",
            ""layout"": ""vertical"",
            ""contents"": [
              {
                ""type"": ""box"",
                ""layout"": ""horizontal"",
                ""contents"": [
                  {
                    ""type"": ""filler""
                  },
                  {
                    ""type"": ""box"",
                    ""layout"": ""vertical"",
                    ""contents"": [
                      {
                        ""type"": ""filler""
                      }
                    ],
                    ""width"": ""2px"",
                    ""backgroundColor"": ""#B7B7B7""
                  },
                  {
                    ""type"": ""filler""
                  }
                ],
                ""flex"": 1
              }
            ],
            ""width"": ""30px""
          },
          {
            ""type"": ""text"",
            ""text"": ""轉運中"",
            ""gravity"": ""top"",
            ""flex"": 2,
            ""size"": ""xs"",
            ""color"": ""#8c8c8c""
          }
        ],
        ""spacing"": ""lg"",
        ""height"": ""40px""
      },
      {
        ""type"": ""box"",
        ""layout"": ""horizontal"",
        ""contents"": [
          {
            ""type"": ""text"",
            ""text"": ""Jul 22, 2019"",
            ""size"": ""sm"",
            ""gravity"": ""center"",
            ""align"": ""end""
          },
          {
            ""type"": ""box"",
            ""layout"": ""vertical"",
            ""contents"": [
              {
                ""type"": ""filler""
              },
              {
                ""type"": ""box"",
                ""layout"": ""vertical"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": ""🚚""
                  }
                ],
                ""cornerRadius"": ""30px"",
                ""height"": ""20px"",
                ""width"": ""20px"",
                ""offsetStart"": ""7px""
              },
              {
                ""type"": ""filler""
              }
            ],
            ""flex"": 0,
            ""backgroundColor"": ""#A9D0F5"",
            ""width"": ""30px"",
            ""height"": ""30px"",
            ""cornerRadius"": ""30px""
          },
          {
            ""type"": ""text"",
            ""text"": ""運輸狀態"",
            ""gravity"": ""center"",
            ""flex"": 1,
            ""size"": ""xs""
          }
        ],
        ""cornerRadius"": ""30px"",
        ""spacing"": ""lg""
      },
      {
        ""type"": ""box"",
        ""layout"": ""horizontal"",
        ""contents"": [
          {
            ""type"": ""box"",
            ""layout"": ""baseline"",
            ""contents"": [
              {
                ""type"": ""text"",
                ""text"": ""02:27:46"",
                ""size"": ""xs"",
                ""color"": ""#8c8c8c"",
                ""align"": ""end""
              }
            ],
            ""flex"": 2
          },
          {
            ""type"": ""box"",
            ""layout"": ""vertical"",
            ""contents"": [
              {
                ""type"": ""box"",
                ""layout"": ""horizontal"",
                ""contents"": [
                  {
                    ""type"": ""filler""
                  },
                  {
                    ""type"": ""box"",
                    ""layout"": ""vertical"",
                    ""contents"": [
                      {
                        ""type"": ""filler""
                      }
                    ],
                    ""width"": ""2px"",
                    ""backgroundColor"": ""#B7B7B7""
                  },
                  {
                    ""type"": ""filler""
                  }
                ],
                ""flex"": 1
              }
            ],
            ""width"": ""30px""
          },
          {
            ""type"": ""text"",
            ""text"": ""配送中"",
            ""gravity"": ""top"",
            ""flex"": 2,
            ""size"": ""xs"",
            ""color"": ""#8c8c8c""
          }
        ],
        ""spacing"": ""lg"",
        ""height"": ""40px""
      },
      {
        ""type"": ""box"",
        ""layout"": ""horizontal"",
        ""contents"": [
          {
            ""type"": ""text"",
            ""text"": ""Jul 22, 2019"",
            ""size"": ""sm"",
            ""gravity"": ""center"",
            ""align"": ""end""
          },
          {
            ""type"": ""box"",
            ""layout"": ""vertical"",
            ""contents"": [
              {
                ""type"": ""filler""
              },
              {
                ""type"": ""box"",
                ""layout"": ""vertical"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": ""📦""
                  }
                ],
                ""cornerRadius"": ""30px"",
                ""height"": ""20px"",
                ""width"": ""20px"",
                ""offsetStart"": ""7px""
              },
              {
                ""type"": ""filler""
              }
            ],
            ""flex"": 0,
            ""backgroundColor"": ""#F6E3CE"",
            ""width"": ""30px"",
            ""height"": ""30px"",
            ""cornerRadius"": ""30px""
          },
          {
            ""type"": ""text"",
            ""text"": ""包裹狀態"",
            ""gravity"": ""center"",
            ""flex"": 1,
            ""size"": ""xs""
          }
        ],
        ""cornerRadius"": ""30px"",
        ""spacing"": ""lg""
      },
      {
        ""type"": ""box"",
        ""layout"": ""horizontal"",
        ""contents"": [
          {
            ""type"": ""box"",
            ""layout"": ""baseline"",
            ""contents"": [
              {
                ""type"": ""text"",
                ""text"": ""11:09:07"",
                ""size"": ""xs"",
                ""color"": ""#8c8c8c"",
                ""align"": ""end""
              }
            ],
            ""flex"": 2
          },
          {
            ""type"": ""box"",
            ""layout"": ""vertical"",
            ""contents"": [
              {
                ""type"": ""box"",
                ""layout"": ""horizontal"",
                ""contents"": [
                  {
                    ""type"": ""filler""
                  },
                  {
                    ""type"": ""box"",
                    ""layout"": ""vertical"",
                    ""contents"": [
                      {
                        ""type"": ""filler""
                      }
                    ],
                    ""width"": ""2px"",
                    ""backgroundColor"": ""#B7B7B7""
                  },
                  {
                    ""type"": ""filler""
                  }
                ],
                ""flex"": 1
              }
            ],
            ""width"": ""30px""
          },
          {
            ""type"": ""text"",
            ""text"": ""完成配送"",
            ""gravity"": ""top"",
            ""flex"": 2,
            ""size"": ""xs"",
            ""color"": ""#8c8c8c""
          }
        ],
        ""spacing"": ""lg"",
        ""height"": ""40px""
      },
      {
        ""type"": ""box"",
        ""layout"": ""horizontal"",
        ""contents"": [
          {
            ""type"": ""text"",
            ""text"": ""Jul 22, 2019"",
            ""size"": ""sm"",
            ""gravity"": ""center"",
            ""align"": ""end""
          },
          {
            ""type"": ""box"",
            ""layout"": ""vertical"",
            ""contents"": [
              {
                ""type"": ""filler""
              },
              {
                ""type"": ""box"",
                ""layout"": ""vertical"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": ""✔️""
                  }
                ],
                ""cornerRadius"": ""30px"",
                ""height"": ""20px"",
                ""width"": ""20px"",
                ""offsetStart"": ""7px""
              },
              {
                ""type"": ""filler""
              }
            ],
            ""flex"": 0,
            ""backgroundColor"": ""#CEF6CE"",
            ""width"": ""30px"",
            ""height"": ""30px"",
            ""cornerRadius"": ""30px""
          },
          {
            ""type"": ""text"",
            ""text"": ""狀態確認"",
            ""gravity"": ""center"",
            ""flex"": 1,
            ""size"": ""xs""
          }
        ],
        ""cornerRadius"": ""30px"",
        ""spacing"": ""lg""
      },
      {
        ""type"": ""box"",
        ""layout"": ""horizontal"",
        ""contents"": [
          {
            ""type"": ""box"",
            ""layout"": ""baseline"",
            ""contents"": [
              {
                ""type"": ""text"",
                ""text"": ""11:59:50"",
                ""size"": ""xs"",
                ""color"": ""#8c8c8c"",
                ""align"": ""end""
              }
            ],
            ""flex"": 2
          },
          {
            ""type"": ""box"",
            ""layout"": ""vertical"",
            ""contents"": [
              {
                ""type"": ""box"",
                ""layout"": ""horizontal"",
                ""contents"": [
                  {
                    ""type"": ""filler""
                  },
                  {
                    ""type"": ""box"",
                    ""layout"": ""vertical"",
                    ""contents"": [
                      {
                        ""type"": ""filler""
                      }
                    ],
                    ""width"": ""2px""
                  },
                  {
                    ""type"": ""filler""
                  }
                ],
                ""flex"": 1
              }
            ],
            ""width"": ""30px""
          },
          {
            ""type"": ""text"",
            ""text"": ""訂單完成"",
            ""gravity"": ""top"",
            ""flex"": 2,
            ""size"": ""xs"",
            ""color"": ""#8c8c8c""
          }
        ],
        ""spacing"": ""lg"",
        ""height"": ""20px""
      }
    ]
  }
}
";
        public static string Source2 => @"https://gist.github.com/kamnan43/2676a37e9da9f2cb73de14d4434c450a";
        public static string Sample2 => @"{
  ""type"": ""carousel"",
  ""contents"": [
    {
      ""type"": ""bubble"",
      ""body"": {
        ""type"": ""box"",
        ""layout"": ""vertical"",
        ""spacing"": ""md"",
        ""contents"": [
          {
            ""type"": ""text"",
            ""text"": ""嘎逼"",
            ""wrap"": true,
            ""weight"": ""bold"",
            ""gravity"": ""center"",
            ""size"": ""lg""
          },
          {
            ""type"": ""box"",
            ""layout"": ""vertical"",
            ""margin"": ""lg"",
            ""spacing"": ""sm"",
            ""contents"": [
              {
                ""type"": ""box"",
                ""layout"": ""baseline"",
                ""spacing"": ""sm"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": ""歷史"",
                    ""color"": ""#aaaaaa"",
                    ""size"": ""sm"",
                    ""weight"": ""bold""
                  }
                ]
              },
              {
    ""type"": ""box"",
                ""layout"": ""baseline"",
                ""spacing"": ""sm"",
                ""contents"": [
                  {
        ""type"": ""text"",
                    ""text"": ""起源"",
                    ""color"": ""#aaaaaa"",
                    ""size"": ""sm"",
                    ""flex"": 1
                  },
                  {
        ""type"": ""icon"",
                    ""url"": ""https://sitthi.me:3807/static/football.png"",
                    ""size"": ""sm""
                  },
                  {
        ""type"": ""text"",
                    ""text"": ""以下"",
                    ""wrap"": true,
                    ""color"": ""#666666"",
                    ""size"": ""sm"",
                    ""flex"": 2
                  },
                  {
        ""type"": ""icon"",
                    ""url"": ""https://sitthi.me:3807/static/flag/Russia.png"",
                    ""size"": ""sm""
                  }
                ]
              },
              {
    ""type"": ""box"",
                ""layout"": ""baseline"",
                ""spacing"": ""sm"",
                ""contents"": [
                  {
        ""type"": ""text"",
                    ""text"": ""傳入歐洲"",
                    ""color"": ""#aaaaaa"",
                    ""size"": ""sm"",
                    ""flex"": 1
                  },
                  {
        ""type"": ""icon"",
                    ""url"": ""https://sitthi.me:3807/static/football.png"",
                    ""size"": ""sm""
                  },
                  {
        ""type"": ""text"",
                    ""text"": ""省略"",
                    ""wrap"": true,
                    ""color"": ""#666666"",
                    ""size"": ""sm"",
                    ""flex"": 2
                  },
                  {
        ""type"": ""icon"",
                    ""url"": ""https://sitthi.me:3807/static/flag/Russia.png"",
                    ""size"": ""sm""
                  }
                ]
              },
              {
    ""type"": ""box"",
                ""layout"": ""baseline"",
                ""spacing"": ""sm"",
                ""contents"": [
                  {
        ""type"": ""text"",
                    ""text"": ""東亞"",
                    ""color"": ""#aaaaaa"",
                    ""size"": ""sm"",
                    ""flex"": 1
                  },
                  {
        ""type"": ""icon"",
                    ""url"": ""https://sitthi.me:3807/static/football.png"",
                    ""size"": ""sm""
                  },
                  {
        ""type"": ""text"",
                    ""text"": ""很多"",
                    ""wrap"": true,
                    ""color"": ""#666666"",
                    ""size"": ""sm"",
                    ""flex"": 2
                  },
                  {
        ""type"": ""icon"",
                    ""url"": ""https://sitthi.me:3807/static/flag/Russia.png"",
                    ""size"": ""sm""
                  }
                ]
              },
              {
    ""type"": ""box"",
                ""layout"": ""baseline"",
                ""spacing"": ""sm"",
                ""contents"": [
                  {
        ""type"": ""text"",
                    ""text"": ""主要成分"",
                    ""color"": ""#aaaaaa"",
                    ""size"": ""sm"",
                    ""weight"": ""bold"",
                    ""wrap"": true
                  }
                ]
              },
              {
    ""type"": ""box"",
                ""layout"": ""baseline"",
                ""spacing"": ""sm"",
                ""contents"": [
                  {
        ""type"": ""text"",
                    ""text"": ""蔗糖："",
                    ""color"": ""#aaaaaa"",
                    ""size"": ""sm"",
                    ""wrap"": false,
                    ""flex"": 1
                  },
                  {
        ""type"": ""icon"",
                    ""url"": ""https://sitthi.me:3807/static/flag/Russia.png"",
                    ""size"": ""sm""
                  },
                  {
        ""type"": ""text"",
                    ""text"": ""烘焙過程中部分會熱裂解為甲酸、醋酸、乳酸、甘醇酸，故含糖量愈高的生豆，在淺焙時會愈酸，可增加咖啡香氣複雜度；部分會在過程中經過焦糖化反應而變為焦糖，可增加咖啡風味。"",
                    ""wrap"": true,
                    ""color"": ""#666666"",
                    ""size"": ""sm"",
                    ""flex"": 2
                  }
                ]
              },
              {
    ""type"": ""box"",
                ""layout"": ""baseline"",
                ""spacing"": ""sm"",
                ""contents"": [
                  {
        ""type"": ""text"",
                    ""text"": ""咖啡因："",
                    ""color"": ""#aaaaaa"",
                    ""size"": ""sm"",
                    ""wrap"": false,
                    ""flex"": 1
                  },
                  {
        ""type"": ""icon"",
                    ""url"": ""https://sitthi.me:3807/static/flag/Russia.png"",
                    ""size"": ""sm""
                  },
                  {
        ""type"": ""text"",
                    ""text"": ""略帶苦味，熔點高達237℃，因此烘焙好的咖啡熟豆，其咖啡因幾乎完整保留下來，並在萃取時會融入杯中。咖啡因的作用主要是刺激中樞神經系統、心臟和呼吸系統。適量的咖啡因亦可減輕肌肉疲勞，促進消化液分泌。由於它會促進腎臟機能，有利尿作用，幫助體內將多餘的鈉離子排出體外。但攝取過多會導致咖啡因中毒。"",
                    ""wrap"": true,
                    ""color"": ""#666666"",
                    ""size"": ""sm"",
                    ""flex"": 2
                  }
                ]
              }
            ]
          }
        ]
      },
      ""footer"": {
    ""type"": ""box"",
        ""layout"": ""vertical"",
        ""contents"": [
          {
        ""type"": ""separator"",
            ""margin"": ""xxl""
          },
          {
        ""type"": ""box"",
            ""layout"": ""baseline"",
            ""margin"": ""md"",
            ""contents"": [
              {
            ""type"": ""text"",
                ""text"": ""資料來源"",
                ""color"": ""#aaaaaa"",
                ""size"": ""sm"",
                ""flex"": 2
              },
              {
            ""type"": ""text"",
                ""text"": ""WIIIIIIIIIIIIIIIIIIIIIIIIKI"",
                ""wrap"": true,
                ""color"": ""#666666"",
                ""size"": ""sm"",
                ""flex"": 4
              }
            ]
          },
          {
        ""type"": ""box"",
            ""layout"": ""baseline"",
            ""spacing"": ""sm"",
            ""contents"": [
              {
            ""type"": ""text"",
                ""text"": ""資料時間"",
                ""color"": ""#aaaaaa"",
                ""size"": ""sm"",
                ""flex"": 2
              },
              {
            ""type"": ""text"",
                ""text"": ""2021-04-21"",
                ""wrap"": true,
                ""size"": ""sm"",
                ""color"": ""#666666"",
                ""flex"": 4
              }
            ]
          },
          {
        ""type"": ""separator"",
            ""margin"": ""md""
          },
          {
        ""type"": ""button"",
            ""style"": ""primary"",
            ""margin"": ""sm"",
            ""action"": {
            ""type"": ""datetimepicker"",
              ""label"": ""選擇時間"",
              ""data"": ""hello"",
              ""mode"": ""date"",
              ""max"": ""2100-01-01"",
              ""min"": ""1900-01-01""
            }
    },
          {
        ""type"": ""button"",
            ""style"": ""primary"",
            ""margin"": ""sm"",
            ""action"": {
            ""type"": ""postback"",
              ""label"": ""PostBack"",
              ""data"": ""這是一個測試的PostBack""
            }
    }
        ]
      }
    },
    {
    ""type"": ""bubble"",
      ""body"": {
        ""type"": ""box"",
        ""layout"": ""vertical"",
        ""spacing"": ""md"",
        ""contents"": [
          {
            ""type"": ""text"",
            ""text"": ""Teletubbies"",
            ""wrap"": true,
            ""weight"": ""bold"",
            ""gravity"": ""center"",
            ""size"": ""lg""
          },
          {
            ""type"": ""box"",
            ""layout"": ""baseline"",
            ""spacing"": ""sm"",
            ""contents"": [
              {
                ""type"": ""icon"",
                ""url"": ""https://sitthi.me:3807/static/flag/Portugal.png"",
                ""size"": ""sm""
              },
              {
                ""type"": ""text"",
                ""text"": ""丁丁"",
                ""align"": ""start""
              },
              {
                ""type"": ""text"",
                ""text"": ""迪西"",
                ""align"": ""center""
              },
              {
                ""type"": ""text"",
                ""text"": ""拉拉"",
                ""align"": ""center""
              },
              {
                ""type"": ""text"",
                ""text"": ""小波"",
                ""align"": ""end""
              },
              {
                ""type"": ""icon"",
                ""url"": ""https://sitthi.me:3807/static/flag/Morocco.png"",
                ""size"": ""sm""
              }
            ]
          },
          {
            ""type"": ""box"",
            ""layout"": ""vertical"",
            ""margin"": ""lg"",
            ""spacing"": ""sm"",
            ""contents"": [
              {
                ""type"": ""box"",
                ""layout"": ""baseline"",
                ""spacing"": ""sm"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": ""介紹"",
                    ""color"": ""#aaaaaa"",
                    ""size"": ""sm"",
                    ""weight"": ""bold""
                  }
                ]
              },
              {
                ""type"": ""box"",
                ""layout"": ""baseline"",
                ""spacing"": ""sm"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": ""格式"",
                    ""color"": ""#aaaaaa"",
                    ""size"": ""sm"",
                    ""flex"": 1
                  },
                  {
                    ""type"": ""icon"",
                    ""url"": ""https://sitthi.me:3807/static/football.png"",
                    ""size"": ""sm""
                  },
                  {
                    ""type"": ""text"",
                    ""text"": ""兒童劇"",
                    ""wrap"": true,
                    ""color"": ""#666666"",
                    ""size"": ""sm"",
                    ""flex"": 4
                  },
                  {
                    ""type"": ""icon"",
                    ""url"": ""https://sitthi.me:3807/static/flag/Portugal.png"",
                    ""size"": ""sm""
                  }
                ]
              },
              {
                ""type"": ""box"",
                ""layout"": ""baseline"",
                ""spacing"": ""sm"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": ""播映"",
                    ""color"": ""#aaaaaa"",
                    ""size"": ""sm"",
                    ""weight"": ""bold""
                  }
                ]
              },
              {
                ""type"": ""box"",
                ""layout"": ""baseline"",
                ""spacing"": ""sm"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": ""首播"",
                    ""color"": ""#aaaaaa"",
                    ""size"": ""sm"",
                    ""flex"": 1
                  },
                  {
                    ""type"": ""icon"",
                    ""url"": ""https://sitthi.me:3807/static/yellowcard.png"",
                    ""size"": ""sm""
                  },
                  {
                    ""type"": ""text"",
                    ""text"": ""英國廣播公司"",
                    ""wrap"": true,
                    ""color"": ""#666666"",
                    ""size"": ""sm"",
                    ""flex"": 4,
                    ""action"": {
                        ""type"": ""uri"",
                      ""label"": ""action"",
                      ""uri"": ""https://zh.wikipedia.org/wiki/%E8%8B%B1%E5%9C%8B%E5%BB%A3%E6%92%AD%E5%85%AC%E5%8F%B8""
                    }
                }
                ]
              },
              {
                ""type"": ""box"",
                ""layout"": ""baseline"",
                ""spacing"": ""sm"",
                ""contents"": [
                  {
                    ""type"": ""text"",
                    ""text"": "" "",
                    ""color"": ""#aaaaaa"",
                    ""size"": ""sm"",
                    ""flex"": 1
                  },
                  {
                    ""type"": ""icon"",
                    ""url"": ""https://sitthi.me:3807/static/yellowcard.png"",
                    ""size"": ""sm""
                  },
                  {
                    ""type"": ""text"",
                    ""text"": ""初版：1997年3月31日 - 2001年2月16日 新版：2016年－至今"",
                    ""wrap"": true,
                    ""color"": ""#666666"",
                    ""size"": ""sm"",
                    ""flex"": 4
                  }
                ]
              }
            ]
          }
        ]
      },
      ""footer"": {
        ""type"": ""box"",
        ""layout"": ""vertical"",
        ""contents"": [
          {
            ""type"": ""separator"",
            ""margin"": ""xxl""
          },
          {
            ""type"": ""box"",
            ""layout"": ""baseline"",
            ""margin"": ""md"",
            ""contents"": [
              {
                ""type"": ""text"",
                ""text"": ""資料來源"",
                ""color"": ""#aaaaaa"",
                ""size"": ""sm"",
                ""flex"": 2
              },
              {
                ""type"": ""text"",
                ""text"": ""WIKI"",
                ""wrap"": true,
                ""color"": ""#666666"",
                ""size"": ""sm"",
                ""flex"": 4
              }
            ]
          },
          {
            ""type"": ""box"",
            ""layout"": ""baseline"",
            ""spacing"": ""sm"",
            ""contents"": [
              {
                ""type"": ""text"",
                ""text"": ""資料時間"",
                ""color"": ""#aaaaaa"",
                ""size"": ""sm"",
                ""flex"": 2
              },
              {
                ""type"": ""text"",
                ""text"": ""2021-04-21"",
                ""wrap"": true,
                ""size"": ""sm"",
                ""color"": ""#666666"",
                ""flex"": 4
              }
            ]
          },
          {
            ""type"": ""separator"",
            ""margin"": ""md""
          },
          {
            ""type"": ""button"",
            ""style"": ""primary"",
            ""margin"": ""sm"",
            ""action"": {
                ""type"": ""message"",
              ""label"": ""天線寶寶"",
              ""text"": ""天線寶寶""
            }
        },
          {
            ""type"": ""button"",
            ""style"": ""primary"",
            ""margin"": ""sm"",
            ""action"": {
                ""type"": ""message"",
              ""label"": ""說"",
              ""text"": ""說""
            }
        },
          {
            ""type"": ""button"",
            ""margin"": ""sm"",
            ""action"": {
                ""type"": ""uri"",
              ""label"": ""你好"",
              ""uri"": ""https://www.google.com.tw/""
            },
            ""style"": ""secondary""
          }
        ]
      }
}
  ]
}";
    }
}
