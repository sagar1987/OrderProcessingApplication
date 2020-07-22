using OrderProcessingApplication.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApplication.PaymentHandlers
{
    class BookPayment : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Book")
            {
                return $"Create a duplicate packing slip for the royalty department for Product : {request.ToString()}.\n 2) Generate a commission payment to the agent. \n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
