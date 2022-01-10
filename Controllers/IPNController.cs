using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Web.Models;
using Web.Settings;

namespace PP_IPN_Tester.Controllers
{
    public class IPNController : Controller
    {
        private AppDataContext _dataContext;
        private readonly IOptions<AppSettings> _appSettings;
        public IPNController(AppDataContext context, IOptions<AppSettings> app)
        {
            _dataContext = context;
            _appSettings = app;
        }
        private class IPNContext
        {
            public HttpRequest IPNRequest { get; set; }

            public string RequestBody { get; set; }

            public string Verification { get; set; } = String.Empty;
        }

        [HttpPost]
        public IActionResult Receive()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            IPNContext ipnContext = new IPNContext()
            {
                IPNRequest = Request
            };

            using (StreamReader reader = new StreamReader(ipnContext.IPNRequest.Body, Encoding.ASCII))
            {
                ipnContext.RequestBody = reader.ReadToEnd();
            }

            //Store the IPN received from PayPal
            LogRequest(ipnContext);

            //Fire and forget verification task
            Task.Run(() => VerifyTask(ipnContext));

            //Reply back a 200 code
            return Ok();
        }

        private void VerifyTask(IPNContext ipnContext)
        {
            try
            {
                var verificationRequest = WebRequest.Create(_appSettings.Value.PaypalIPNVerificationUrl);

                //Set values for the verification request
                verificationRequest.Method = "POST";
                verificationRequest.ContentType = "application/x-www-form-urlencoded";
                verificationRequest.Headers.Add("user-agent", "ASP-IPN-VerificationScript");
                //Add cmd=_notify-validate to the payload
                string strRequest = "cmd=_notify-validate&" + ipnContext.RequestBody;
                verificationRequest.ContentLength = strRequest.Length;

                //Attach payload to the verification request
                using (StreamWriter writer = new StreamWriter(verificationRequest.GetRequestStream(), Encoding.ASCII))
                {
                    writer.Write(strRequest);
                }

                //Send the request to PayPal and get the response
                using (StreamReader reader = new StreamReader(verificationRequest.GetResponse().GetResponseStream()))
                {
                    ipnContext.Verification = reader.ReadToEnd();
                }
            }
            catch (Exception exception)
            {
                //Capture exception for manual investigation
            }

            ProcessVerificationResponse(ipnContext);
        }


        private void LogRequest(IPNContext ipnContext)
        {
            // Persist the request values into a database or temporary data store
        }

        private void ProcessVerificationResponse(IPNContext ipnContext)
        {
            if (ipnContext.Verification.Equals("VERIFIED"))
            {
                // check that Payment_status=Completed
                // check that Txn_id has not been previously processed
                // check that Receiver_email is your Primary PayPal email
                // check that Payment_amount/Payment_currency are correct
                // process payment
            }
            else if (ipnContext.Verification.Equals("INVALID"))
            {
                //Log for manual investigation
            }
            else
            {
                //Log error
            }
        }
    }
}