using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Sends a code to verify an email address to be added to a user's Telegram Passport
        /// </summary>
        public class SendEmailAddressVerificationCode : Function<EmailAddressAuthenticationCodeInfo>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "sendEmailAddressVerificationCode";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Email address
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("email_address")]
            public string EmailAddress { get; set; }
        }

        /// <summary>
        /// Sends a code to verify an email address to be added to a user's Telegram Passport
        /// </summary>
        public static Task<EmailAddressAuthenticationCodeInfo> SendEmailAddressVerificationCodeAsync(
            this Client client, string emailAddress = default)
        {
            return client.ExecuteAsync(new SendEmailAddressVerificationCode
            {
                EmailAddress = emailAddress
            });
        }
    }
}