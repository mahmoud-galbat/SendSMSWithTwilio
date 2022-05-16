using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SendSMSWithTwilio.Dtos
{
    public class SendSMSDto
    {
        public string MobileNumber { get; set; }
        public string Message { get; set; }
    }
}
