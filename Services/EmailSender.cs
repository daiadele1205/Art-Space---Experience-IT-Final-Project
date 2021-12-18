using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtSpace_Project.Services
{
    public class EmailSender : IEmailSender
    {
        public EmailOptions Options { get; set; }

        public EmailSender(IOptions<EmailOptions> emailOptions)
        {
            Options = emailOptions.Value;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            throw new NotImplementedException();
        }
    }
}
