using OrderProcessingApplication.PaymentHandlers;
using System;

namespace OrderProcessingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new BookPayment();
            var memberShipPayment = new MemberShipPayment();
            var physicalProductPayment = new PhysicalProductPayment();
            var upgradeToMemberShipPayment = new UpgradeToMemberShipPayment();
            var videoPayment = new VideoPayment();

            Console.WriteLine("Payment for Book\n");
            ServiceClient.ProductCode(book);
            Console.WriteLine();

            Console.WriteLine("Payment for memberShipPayment\n");
            ServiceClient.ProductCode(memberShipPayment);
            Console.WriteLine();

            Console.WriteLine("Payment for physicalProductPayment\n");
            ServiceClient.ProductCode(physicalProductPayment);
            Console.WriteLine();

            Console.WriteLine("Payment for upgradeToMemberShipPayment\n");
            ServiceClient.ProductCode(upgradeToMemberShipPayment);
            Console.WriteLine();

            Console.WriteLine("Payment for videoPayment\n");
            ServiceClient.ProductCode(videoPayment);
            Console.WriteLine();

        }
    }
}
