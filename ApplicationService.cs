using System;
using System.Data;

namespace PoEAA_ServiceLayer
{
    public class ApplicationService
    {
        protected virtual IEmailGateway GetEmailGateway()
        {
            return new EmailGateway();
        }

        protected virtual IIntegrationGateway GetIntegrationGateway()
        {
            return new IntegrationGateway();
        }
    }

    internal class IntegrationGateway : IIntegrationGateway
    {
        public void PublishRevenueRecognitionCalculation(DataRow contract)
        {
            Console.WriteLine($"Id : {contract["Id"]} , Signed Date: {((DateTime)contract["DateSigned"]):MM/dd/yyyy}");
        }
    }

    public interface IIntegrationGateway
    {
        void PublishRevenueRecognitionCalculation(DataRow contract);
    }

    internal class EmailGateway : IEmailGateway
    {
        public void SendEmailMessage(string toAddress, string subject, string body)
        {
            Console.WriteLine($"To Address : {toAddress} , subject: {subject}, body: {body}");
        }
    }

    public interface IEmailGateway
    {
        void SendEmailMessage(string toAddress, string subject, string body);
    }
}
