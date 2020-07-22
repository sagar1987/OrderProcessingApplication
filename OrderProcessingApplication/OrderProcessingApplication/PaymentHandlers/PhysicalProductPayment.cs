using OrderProcessingApplication.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApplication.PaymentHandlers
{
    class PhysicalProductPayment : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Physical Product")
            {
                return $" 1) Generate the packing slip for Product : {request.ToString()}.\n 2) Generate a commission payment to the agent. \n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
