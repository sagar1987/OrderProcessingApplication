using OrderProcessingApplication.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApplication.PaymentHandlers
{
    class VideoPayment : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "video")
            {
                return $"Add a free 'First Aid' video to packing slip for : {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
