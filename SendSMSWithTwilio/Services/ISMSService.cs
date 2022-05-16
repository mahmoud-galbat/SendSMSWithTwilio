﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio.Rest.Api.V2010.Account;

namespace SendSMSWithTwilio.Services
{
    public interface ISMSService
    {
        MessageResource Send(string mobileNumber, string msg);
    }
}
