using OrderProcessingApplication.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApplication.PaymentHandlers
{
    class MemberShipPayment : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "membership")
            {
                return $" 1) Activate the membership for the : {request.ToString()}.\n 2) Email the owner and inform them for the activation/upgrade. \n ";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
