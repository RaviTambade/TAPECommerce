namespace TFLCommerce;

// decorator------typescript
    // annotation-----java
    // attribute------C#
    // metadata-------data about data extra information about an entity Product
    [Serializable]
    public class Product {  
        public  int Likes{get;set;}
        public int Id{get;set;}
        public string Title {get;set;}
        public string Description{get;set;}
        public string ImageUrl { get; set;}
        public double UnitPrice{ get; set;}
        public int Quantity{get;set;}
    }  