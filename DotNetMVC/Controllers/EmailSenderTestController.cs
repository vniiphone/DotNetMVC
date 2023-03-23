﻿using EmailService;
using Microsoft.AspNetCore.Mvc;

namespace DotNetMVC.Controllers
{
    public class EmailSenderTestController : Controller
    {
        private readonly IEmailSender _emailSender;

        public EmailSenderTestController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }
        [HttpGet]
        public void Get()
        {
            var message = new Message(new string[] { "anhkhoa3301@gmail.com" }, "Test email", "This is test email, hi !");
        }
    }
}
