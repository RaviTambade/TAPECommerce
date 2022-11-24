namespace Accouting;


public class Transaction : Debitable, Creditable{

    public void Deposit(){
        Console.WriteLine( "Amount is added into shoppers account");
    }

    public void Withdraw(){
        Console.WriteLine( "Amount is Withdrawn from consumers shoppers account");
    }

}