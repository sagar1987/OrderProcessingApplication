using OrderProcessingApplication.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApplication
{
    class ServiceClient
    {
        public static void ProductCode(AbstractHandler handler)
        {
            foreach (var product in new List<string> { "Book", "membership", "Physical Product", "upgrade to membership", "video" })
            {
                Console.WriteLine($"Payment is for {product}?");
                var result = handler.Handle(product);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {product} was left untouched.");
                }
            }
        }
    }
}
