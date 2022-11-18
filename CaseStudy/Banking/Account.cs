namespace Banking;
    //Mother of all classes in programming C# is Object class
    //Object class have some default method with their Implementation
    // 1. ToString();
    public class Account {

        public double Balance{get;set;}   //Auto property
        public string Holder{get;set;}
        public string Id{get;set;}
        private List<Transaction> allTransactions = new List<Transaction>();


        //constructor overloading
        //default constructor
        public Account(){
            //implementation is different
            this.Balance=0;
            this.Holder="Ravi Tambade";
            this.Id="878";
        }
        //parameterized constructor
        public Account(string id, string fullName, double amount){
            //Data Validation
            this.Holder=fullName;
            this.Id=id;
            Deposit(initialBalance, DateTime.Now, "Initial balance");
        }

        //function overriding

       public override string ToString()
        {
            //return base.ToString();
            string str=string.Format(" ID={0} , Holder={1} , Current Balance={2}", this.Id, this.Holder, this.Balance);
            return str;
        }
    
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }
            return report.ToString();
        }
    
    
        public void Deposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void Withdraw(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }
        #endregion

        #region History
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }
        #endregion    
    }