namespace BankingLogic
{
	//This is the foundation for complete event driven application
	//this
	public delegate void AccountHandler();
	
	
    public class Account
	{

		//Define Custom Event type for Account Business Logic
		public event AccountHandler underBalance, overBalance;
		
        public Account(double amount)
		{
			this.Balance = amount;
		}

		public double Balance { get; set; }
		
        public void Withdraw(double amount)
		{
			//strategy
			this.Balance -= amount;
			if (Balance <= 5000)
			{
				underBalance();  // fire event
			}

		}

		public void Deposit(double amount)
		{
			this.Balance += amount;
			if (Balance >= 250000)
			{
				overBalance(); // fire event
			}
		}
	}
}