using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PaymentProcesing
{
    public class PaymentsGateway : IPaymentsGateway
    {   

        public PaymentsGateway(string apiKey)
        {
  
           
        }

        public List<CustomerModel> GetCustomers(int take)
        {
            var service = new CustomerService();
        
            List<CustomerModel> customers= new List<CustomerModel>();
            return customers;
        }

        public  CustomerModel GetCustomerByEmail(string email, params PaymentModelInclude[] includes)
        {
                      
            var customerModel = new CustomerModel("jhjhj")
            {
                Email = email,
                Name = "klkjl"
            };
            
            return  customerModel;
        }

        public   bool CreateCustomer(string name, string email, string systemId)
        { 

            return false;
           
        }

        public CustomerModel DeleteCustomerByEmail(string email)
        {
            var service = new CustomerService();
            
          
            return await new CustomerModel( );
            
        }

        public List<PlanModel> PopulatePlans(List<PlanModel> plans)
        {
             List<PlanModel> plans=new List<PlanModel>();
              
            return result;
        }

        private IEnumerable<Price> CreatePrices(List<PlanPriceModel> prices, 
                                Product existingProduct,
            IEnumerable<Price> existingPricesForProduct = null)
        {
            List<Price> stripePrices = new List<Price>();
              
            return stripePrices;
        }


        public PaymentMethodModel AttachPaymentMethod(string paymentMethodId, string customerId, bool makeDefault = true)

        {
            
                var options = new PaymentMethodAttachOptions
                {
                    Customer = customerId,
                };
               
                 
                PaymentMethodModel model=new PaymentMethodModel();
 

                return model;
          
             
           
        }

        public bool DeletePaymentMethod(string paymentMethodId)
        {
           return false;

        }

        public bool CreateSubscription(string customerEmail, string priceId)
        { 

            return false;
        }

        public FuturePaymentIntentModel PrepareForFuturePaymentWithCustomerEmail(string customerEmail)
        {
            

            FuturePaymentIntentModel intent =  PrepareForFuturePayment(customer.Id);
            return intent;
        }

        public FuturePaymentIntentModel PrepareForFuturePayment(string customerId)
        {
            var options = new SetupIntentCreateOptions
            {
                Customer = customerId,
                Expand = new List<string>()
                {
                    "customer"
                }
            };
 
        }


        public List<PaymentMethodModel> GetPaymentMethods(string customerId, PaymentMethodType paymentMethodType)
        {

            List<PaymentMethodModel> result = new List<PaymentMethodModel>();
              
            return result;
        }

        public List<PaymentMethodModel> GetPaymentMethodsByCustomerEmail(string customerEmail, PaymentMethodType paymentMethodType)
        {
            CustomerModel customer = await this.GetCustomerByEmail(customerEmail);

            return  this.GetPaymentMethods(customer.Id, paymentMethodType);
        }


        public void  ChargeWithCustomerEmail(string customerEmail, string paymentMethodId, Currency currency, long unitAmount,
            bool sendEmailAfterSuccess = false, string emailDescription = "")
        {
            var customer = await GetCustomerByEmail(customerEmail);
             Charge(customer.Id, paymentMethodId, currency, unitAmount, customerEmail, sendEmailAfterSuccess, emailDescription);
        }

        public   void  Charge(string customerId, string paymentMethodId,
            Currency currency, long unitAmount, string customerEmail, bool sendEmailAfterSuccess = false, string emailDescription = "")
        {
            try
            {
                var service = new PaymentIntentService();
                var options = new PaymentIntentCreateOptions
                {
                    Amount = unitAmount,
                    Currency = currency.ToString().ToLower(),
                    Customer = customerId,
                    PaymentMethod = paymentMethodId,
                    Confirm = true,
                    OffSession = true,
                    ReceiptEmail = sendEmailAfterSuccess ? customerEmail : null,
                    Description = emailDescription,
                };
               
            }
            catch (Exception e)
            {
                
            }
        }


        public IEnumerable<ChargeModel> GetPaymentStatus(string paymentId)
        {
            var service = new PaymentIntentService();
            var intent = await service.GetAsync(paymentId);
            var charges = intent.Charges.Data;

            return charges.Select(x => new ChargeModel(x.Id)
            {
                Status = x.Status
            });
        }
    }
}