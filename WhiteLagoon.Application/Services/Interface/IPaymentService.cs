﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteLagoon.Domain.Entities;
using Stripe.Checkout;


namespace WhiteLagoon.Application.Services.Interface
{
    public interface IPaymentService
    {
        SessionCreateOptions CreateStripeSessionOptions(Booking booking, Villa villa, string domain);
        Session CreateStripeSession(SessionCreateOptions options);

    }
}
