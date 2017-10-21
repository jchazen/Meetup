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
        public ActionResult
        // GET: Meetup
        public ActionResult InitialSMS()
        {
            var accountSid = AC5b3938e45c472021784a748f81ca2d0b;
            var authToken = 2545231d0b7575a9d1f7a3d476286b51;
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("+18582078685");
            var from = new PhoneNumber("+6193041784");

        }
    }
}