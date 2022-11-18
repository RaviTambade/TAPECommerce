package com.example;

public class CustomerDashBoard  implements CustomerDetails,OrderDetails,PaymentDetails{
    public String name ;
    public String description ;

    public void Display()
    {
        System.out.println("Showing Customer  Order Details Details");
    }

    public void show()
    {
        System.out.println("Customer Personal Information");
    }

    public void ShowCustomerProfile()
    {
        System.out.println("Customer Profile Details Information");
    }

    public void ShowOrderHistory()
    {
        System.out.println("Customer existing orders  Information");
    }
}