using System.Collections.Generic;
using System.Text.Json;

namespace  Banking;
 
public class AccountManger
{
    public static bool Store(string fileName, List<Account> accounts){
        string jsonString = JsonSerializer.Serialize(accounts);
        Console.WriteLine(jsonString);
        File.WriteAllText(fileName, jsonString);
        return true;
    }
    public static List<Account> Restore(string fileName)
    {
        string restoredJsonString=File.ReadAllText(fileName);
        //DeSerialization:Converting stream into objects
        List<Account> restoredAccounts=JsonSerializer.Deserialize <List<Account>>(restoredJsonString);
        return restoredAccounts;
    }
    public static bool Insert(Account account){
    //Inset into Account inside collection
        List<Account> allAccounts=Restore("accounts.json");
        allAccounts.Add( account);
        bool status=Store("accounts.json", allAccounts);
        return status;
    }
    public static bool Update(Account acct){
    bool status=false;
     List<Account> allAccounts=Restore("accounts.json");

    foreach( Account theAccount in allAccounts){
        if(theAccount.Id == acct.Id){
            theAccount.Balance=acct.Balance;
            theAccount.Holder=acct.Holder;
            Store("accounts.json",allAccounts);
            status=true;
        }
     }
    return status;
    }

    public static List<Account> GetAll(){
        //Get All Acccount list from collection
        List<Account> allAccounts=Restore("accounts.json");
        return allAccounts;
    }

    public static Account GetById(string id){
        //Get Account object from collection whose id is match with input parameter
        List<Account> allAccounts=Restore("accounts.json");
        Account foundAccount=null;
        foreach( Account theAccount in allAccounts )
        {
            if(theAccount.Id == id){
                foundAccount=theAccount;
            }
            else{
                foundAccount=null;
            }
        }
         return foundAccount;
    }

    public static bool Delete(string acctId){
        bool status=false;
        List<Account> allAccounts=Restore("accounts.json");
        foreach( Account theAccount in allAccounts ){
        if(theAccount.Id == acctId){
            allAccounts.Remove(theAccount);
            Store("accounts.json", allAccounts);
            status=true;
        }    
    }
    return  status;
    }
  //Adding display method
    public static void Display( List<Account> allAccounts){
           allAccounts=Restore("accounts.json");
        foreach( Account acct in allAccounts){
    Console.WriteLine("{0}  {1}  {2}", acct.Id, acct.Holder, acct.Balance);
}
}
}