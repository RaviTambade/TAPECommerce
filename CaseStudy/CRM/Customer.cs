using Common;
using BusinessProcessing;
using Banking;

namespace CRM;
public class Customer:Person
{

   //Customer may or many not have orders
        public List<Order>? OrdersHistory {get;set;}
        public   Account CurrentAccount{get;set;}

        public string CustomerId{get;set;}
}