using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

using Twilio.TwiML;
using Twilio.AspNet.Mvc;

namespace Meetup.Controllers
{
    public class MeetupController : TwilioController
    {
        // GET: Meetup
        public ActionResult SendSms()
        {
            
        }
    }
}