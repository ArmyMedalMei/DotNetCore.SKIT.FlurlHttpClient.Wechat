﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/sign/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class OpenApiSignResponse : WechatOpenAIResponse<OpenApiSignResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置请求签名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("signature")]
                [System.Text.Json.Serialization.JsonPropertyName("signature")]
                public string Signature { get; set; } = default!;

                /// <summary>
                /// 获取或设置有效期（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expiresIn")]
                [System.Text.Json.Serialization.JsonPropertyName("expiresIn")]
                public int ExpiresIn { get; set; }
            }
        }
    }
}
