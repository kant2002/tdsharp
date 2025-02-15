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
        /// Re-sends the code to verify an email address to be added to a user's Telegram Passport
        /// </summary>
        public class ResendEmailAddressVerificationCode : Function<EmailAddressAuthenticationCodeInfo>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "resendEmailAddressVerificationCode";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }


        }

        /// <summary>
        /// Re-sends the code to verify an email address to be added to a user's Telegram Passport
        /// </summary>
        public static Task<EmailAddressAuthenticationCodeInfo> ResendEmailAddressVerificationCodeAsync(
            this Client client)
        {
            return client.ExecuteAsync(new ResendEmailAddressVerificationCode
            {
                
            });
        }
    }
}