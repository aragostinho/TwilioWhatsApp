# TwilioWhatsApp
.Net Core project to send WhatsApp message using Twilio  

# Twilio Account 
Before of all you need to create an account (free trial) on https://www.twilio.com.  After that, it's necessary to create a Programmable SMS Project.  See first steps on https://www.twilio.com/docs/usage/tutorials/how-to-use-your-free-trial-account.

# Twilio REST API
This program uses Twilio REST API 5.24.0 available on https://www.nuget.org/packages/Twilio/

# Service Layer
In TwilioSMS.Service project there are the following objects:

- Message: The message containing the properties MessageText, PhoneNumber* and SenderId. 
- MessageContract: DesignContract to verify well filled properties  
- TwilioService: The class responsible for send SMS
- ServiceResponse: The class responsible for obtain result after sending.

*Pay attention with phone number formats, check the documentation:
https://support.twilio.com/hc/en-us/articles/223183008-formatting-international-phone-numbers

# Configuring Twilio API Credentials
In TwilioSMS.Utils project, open TwilioCredentials.cs and define the variables:

        public static string AccountSid = "";
        public static string AuthToken = "";
        public static string TwilioWhatsSenderPhoneNumber = ""; //A Twilio WhatsApp number 


