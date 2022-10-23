namespace PaymentProcesing;


 public class PlanService
    {
        private readonly IPaymentsGateway _paymentsGateway;

        public PlanService(IPaymentsGateway paymentsGateway)
        {
            _paymentsGateway = paymentsGateway;
        }

        public   bool Create()
        {
            var res =   this._paymentsGateway.PopulatePlans(new List<PlanModel>() {
                new PlanModel()
                {
                    Name = "basic",
                    Prices = new List<PlanPriceModel>()
                    {
                        new PlanPriceModel()
                        {
                            Interval = PriceInterval.Monthly,
                            Currency = Currency.USD,
                            UnitAmount = 10000
                        },
                        new PlanPriceModel()
                        {
                            Interval = PriceInterval.Yearly,
                            Currency = Currency.USD,
                            UnitAmount = 8000
                        }
                    }
                }
            });

            return false;
        }

    }
