/*using System.Collections.Generic;
using System.IO;
using Catalog;
using System.Text.Json;

namespace TestApp;

public class ProductManager
{
 public static bool Store(string fileName, List<Product> product)
 {
      string jsonString = JsonSerializer.Serialize(product);
      Console.WriteLine(jsonString);
      File.WriteAllText(fileName, jsonString);
      return true;
 }
 public static List<Product> ReStore(string fileName)
    {
        string restoredJsonString=File.ReadAllText(fileName);
     
         List<Product> restoredProducts=JsonSerializer.Deserialize <List<Product>>(restoredJsonString);
        return restoredProducts;
    }
    
public static bool Insert(Product product)
  {
   
        List<Product> allProducts=ReStore("products.json");
        allProducts.Add(product);
        bool status=Store("products.json", allProducts);
        return status;
  
  }
  public static bool Update(Product product)
    {
        bool status=false;
        List<Product> allProducts=ReStore("products.json");
    foreach( Product theProduct in allProducts)
       {
        if(theProduct.Id == product.Id)
                 { theProduct.Title=product.Title;
                   theProduct.PricePerProduct=product.PricePerProduct;
                   theProduct.AvailableStock=product.AvailableStock;
                   Store("products.json",allProducts);
                   status=true;
                 }
               
        }
        return status;
}
public static List<Product> GetAll()
        {
        List<Product> allProducts=ReStore("products.json");
        return allProducts;
        }
        
        
public static Product GetById(string Id)
    {   Product foundProduct=null;
        List<Product> allProducts=ReStore("products.json");
        
        foreach( Product theProduct in allProducts)
        {
            if(theProduct.Id == Id)
              {
                foundProduct=theProduct;
              }
            else
              {
                 foundProduct=null;
              }
              
        }
         return foundProduct;
    
    } 
    
  public static bool Delete(string productsId)
    {
        bool status=false;
        List<Product> allProducts=ReStore("products.json");
        foreach( Product theProduct in allProducts )
        {
        if(theProduct.Id == productsId)
           {
              allProducts.Remove(theProduct);
              Store("products.json", allProducts);
              status=true;
           }    
        }
    return  status;
    }
}   */



 



