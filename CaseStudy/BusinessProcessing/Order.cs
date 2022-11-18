using Catalog;
namespace BusinessProcessing;
public class Order{
        public int Id{get;set;}
        public DateTime  Date{get;set;}
        public double TotalAmount{ get;set;}
    
        public string Status {get;set;} 
        //Status  : processed, inprogress, approved, rejected
        public List<Item> Items{get;set;}
        }

        //Default Constructor
        //Parameterized Constructor
        //override ToString method
        //Auto Properties for each filed


