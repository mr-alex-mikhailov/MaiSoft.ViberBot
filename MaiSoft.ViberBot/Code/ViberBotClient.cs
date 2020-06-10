using MaiSoft.ViberBot.ApiResponses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MaiSoft.ViberBot
{
    public class ViberBotClient : IViberBotClient, IDisposable
    {
        public const Int32 MaxBroadcastMessageReceivers = 300;

        private const String XViberAuthTokenHeader = "X-Viber-Auth-Token";
        private const string BaseApiUrl = "https://chatapi.viber.com/pa/";

        private readonly HttpClient mHttpClient = null;

        public ViberBotClient(String authToken, IWebProxy proxy = null)
        {
            mHttpClient = proxy == null
                ? new HttpClient()
                : new HttpClient(new HttpClientHandler { UseProxy = true, Proxy = proxy });
            mHttpClient.BaseAddress = new Uri(BaseApiUrl);
            mHttpClient.DefaultRequestHeaders.Add(XViberAuthTokenHeader, new[] { authToken });
        }

        public async Task<IEnumerable<EventTypeEnum>> SetWebhookAsync(WebhookParams webhookParams)
        {
            if (webhookParams == null)
                throw new ArgumentNullException(nameof(webhookParams));

            var result = await MakeApiRequestAsync<SetWebhookApiResponse>("set_webhook", webhookParams);

            return result?.EventTypes;
        }

        public async Task RemoveWebhookAsync()
        {
            var webhookParams = new WebhookParams("");
            var result = await MakeApiRequestAsync<SetWebhookApiResponse>("set_webhook", webhookParams);
        }

        //public async Task<AccountInfo> GetAccountInfoAsync()
        //{
        //    var response = await MakeApiRequestAsync<GetAccountInfoApiResponse>(
        //        "get_account_info");

        //    return response.Account;
        //}

        public async Task<UserDetails> GetUserDetailsAsync(string userId)
        {
            var requestData = new { id = userId };
            var response = await MakeApiRequestAsync<GetUserDetailsApiResponse>(
                "get_user_details", requestData);
            return response.UserDetails;
        }

        public async Task<Int64?> SendMessageAsync(BaseMessage message)
        {
            var apiMethod = message.IsBroadcasting ? "broadcast_message" : "send_message";
            var result = await MakeApiRequestAsync<SendMessageApiResponse>(apiMethod, message);

            return result?.MessageToken;
        }

        public void Dispose()
        {
            mHttpClient.Dispose();
        }


        private async Task<T> MakeApiRequestAsync<T>(String apiMethod, Object apiData = null)
            where T : BaseApiResponse, new()
        {
            var jsonSerializeSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,

            };

            var requestJson = apiData == null
                ? "{}"
                : JsonConvert.SerializeObject(apiData, jsonSerializeSettings);

            var response = await mHttpClient.PostAsync(apiMethod, new StringContent(requestJson));
            var responseJson = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(responseJson);

            return result;
        }
    }
}
