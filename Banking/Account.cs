namespace Banking;
//Mother of all classes in programming C# is Object class
    //Object class have some default method with their Implementation
    // 1. ToString();
    public class Account {

        public double Balance{get;set;}   //Auto property
        public string Holder{get;set;}
        public string Id{get;set;}

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
            if(amount <=0){
               throw new Exception("Balance can not zero"); 
            }
            this.Balance=amount;
            this.Holder=fullName;
            this.Id=id;
        }

        //function overriding

       public override string ToString()
        {
            //return base.ToString();
            string str=string.Format(" ID={0} , Holder={1} , Current Balance={2}", this.Id, this.Holder, this.Balance);
            return str;
        }
    }