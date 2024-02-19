using Hr_Management.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hr_Management.Application.Contracts.Infrastructure
{
    public interface IEmailSender
    {
        Task<bool> SenderEmail(Email email);
    }
}
