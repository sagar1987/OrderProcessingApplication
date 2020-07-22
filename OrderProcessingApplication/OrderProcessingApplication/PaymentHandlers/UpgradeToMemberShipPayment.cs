using OrderProcessingApplication.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApplication.PaymentHandlers
{
    class UpgradeToMemberShipPayment : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "upgrade to membership")
            {
                return $"1) apply the upgrade to : {request.ToString()}.\n 2) Email the owner and inform them for the activation/upgrade. \n ";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
