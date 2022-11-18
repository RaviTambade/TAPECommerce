package com.example;

public class Customer extends Person {

    private String deliveryAddress;
    private String billingAddress;

    public String  getDeliveryAddress() { return this.deliveryAddress;}
    public void setDeliveryAddress(String address){ this.deliveryAddress=address;}

    public String  getBillingAddress() { return this.billingAddress;}
    public void  setBillingAddress(String address){ this.billingAddress=address;}

    @Override
    public  String toString()
    {
        String data= " " + this.deliveryAddress + " " + this.billingAddress;
        return data;
    }
}
