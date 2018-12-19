using System;
using System.Collections.Generic;
using System.Text;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using TwilioWhats.Utils;
using static Twilio.Rest.Api.V2010.Account.Call.FeedbackSummaryResource;

namespace TwilioWhats.Service
{
    public class TwilioService
    {
        public static ServiceResponse Send(Message message)
        {
            ServiceResponse response = new ServiceResponse();
            if (message.IsValid())
            {


                TwilioClient.Init(TwilioCredentials.AccountSid, TwilioCredentials.AuthToken);
                
                var result = MessageResource.Create(
                                            to: new PhoneNumber($"whatsapp:+{message.PhoneNumber}"),
                                            from: new PhoneNumber($"whatsapp:+{message.SenderId}"),
                                            body: message.TextMessage);

                if (result.Status != StatusEnum.Failed)
                    response.IsValid = true;
                else
                {
                    response.Errors.Add("Whats message failed!");
                    response.IsValid = false;
                }
            }
            else
            {
                response.Errors = message.Errors;
                response.IsValid = false;
            }
            return response;
        }
    }
}
