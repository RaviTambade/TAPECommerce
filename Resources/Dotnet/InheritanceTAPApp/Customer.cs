
using ECommerce;
namespace CRM;
public class Customer:Person{

    private string deliveryAddress;
    private string billingAddress;

    //Property
    public string DeliveryAddress{
        get { return this.deliveryAddress;}
        set{ this.deliveryAddress=value;}
    }

    public string BillingAddress{
        get { return this.billingAddress;}
        set{ this.billingAddress=value;}
    }


    public override string ToString(){
     string data=string.Format("{0}, {1} ",deliveryAddress,billingAddress);
     return base.ToString() + "  "+ data;
    }
}