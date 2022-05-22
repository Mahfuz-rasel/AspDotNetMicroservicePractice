using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ordering.Application.Modals;

namespace Ordering.Application.Contracts.Infrastructure
{
   public interface IEmailServices
    {
        Task<bool> SendEmail(Email email);
    }
}
