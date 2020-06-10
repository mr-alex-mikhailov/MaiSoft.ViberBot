using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MaiSoft.ViberBot
{
    public interface IViberBotClient
    {
        /// <summary>
        /// Sets a webhook. This webhook will be used for receiving callbacks and user messages from Viber
        /// </summary>
        /// <param name="webHookParams">Webhook parameters</param>
        /// <returns></returns>
        Task<IEnumerable<EventTypeEnum>> SetWebhookAsync(WebhookParams webHookParams);

        /// <summary>
        /// Removes the webhook
        /// </summary>
        /// <returns></returns>
        Task RemoveWebhookAsync();

        /// <summary>
        /// Returns the account’s details as registered in Viber
        /// </summary>
        /// <returns></returns>
        //Task<AccountInfo> GetAccountInfoAsync();

        /// <summary>
        /// Returns the details of a specific Viber user based on his unique user ID
        /// </summary>
        /// <param name="userId">Viber user's ID</param>
        /// <returns></returns>
        Task<UserDetails> GetUserDetailsAsync(String userId);

        /// <summary>
        /// Sends a message to Viber user
        /// </summary>
        /// <param name="message">Message to send</param>
        /// <param name="receiverId">Unique Viber user id</param>
        /// <returns></returns>
        Task<Int64?> SendMessageAsync(BaseMessage message);
    }
}
