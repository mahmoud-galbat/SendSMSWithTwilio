using Microsoft.Extensions.Options;
using SendSMSWithTwilio.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace SendSMSWithTwilio.Services
{
    public class SMSService : ISMSService
    {
        private readonly TwilioSettings _twilioSettings;

        public SMSService(IOptions<TwilioSettings> twilioSettings)
        {
            _twilioSettings = twilioSettings.Value;
        }
        public MessageResource Send(string mobileNumber, string msg)
        {
            TwilioClient.Init(_twilioSettings.AccountSID, _twilioSettings.AuthToken);
            var result = MessageResource.Create(body: msg, from: new Twilio.Types.PhoneNumber(_twilioSettings.TwilioPhoneNumber), to: mobileNumber);
            return result;
        }
    }
}
