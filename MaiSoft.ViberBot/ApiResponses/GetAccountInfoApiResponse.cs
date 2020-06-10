using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaiSoft.ViberBot.ApiResponses
{
    internal sealed class GetAccountInfoApiResponse : BaseApiResponse
    {
        [JsonProperty()]
        public AccountInfo Account { get; set; }
    }
}
