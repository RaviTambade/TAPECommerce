
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentProcesing
{
    public interface IPaymentsGateway
    {
        List<PlanModel>PopulatePlans(List<PlanModel> plans);

        bool CreateCustomer(string name, string email, string systemId);
        List<CustomerModel> GetCustomers(int take);
        CustomerModel GetCustomerByEmail(string email, params PaymentModelInclude[] include);
        CustomerModel DeleteCustomerByEmail(string email);

        
        FuturePaymentIntentModel PrepareForFuturePayment(string customerId);
        FuturePaymentIntentModel PrepareForFuturePaymentWithCustomerEmail(string customerEmail);

        List<PaymentMethodModel> GetPaymentMethods(string customerId, PaymentMethodType paymentMethodType);
        List<PaymentMethodModel> GetPaymentMethodsByCustomerEmail(string customerEmail, PaymentMethodType paymentMethodType);

        PaymentMethodModel AttachPaymentMethod(string paymentMethodId, string customerId, bool makeDefault);
        bool DeletePaymentMethod(string paymentMethodId);

        bool CreateSubscription(string customerEmail, string priceId);

        void  Charge(string customerId, string paymentMethodId, Currency currency, long unitAmount,
            string customerEmail, bool sendEmailAfterSuccess = false, string emailDescription = "");

        void  ChargeWithCustomerEmail(string customerEmail, string paymentMethodId, Currency currency, long unitAmount,
            bool sendEmailAfterSuccess = false, string emailDescription = "");

         IEnumerable<ChargeModel> GetPaymentStatus(string paymentId);
    }
}
//https://softwareparticles.com/stripe-payment-gateway-dotnet/
//https://softwareparticles.com/stripe-payment-gateway-dotnet/
//https://github.com/dkokkinos/stripe-sample/tree/main/Stripe.Web/Models/Customers
