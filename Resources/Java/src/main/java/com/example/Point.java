package com.example;

public class Point {
    //data members
    private int x ;
    private int y ;

    //getters and setters
    public int  getX() { return this.x;}
    public void setX(int num){ this.x=num;}

    public int  getY() { return this.y;}
    public void setY(int num){ this.y=num;}

    //Polymorphic behaviour
    @Override
    public String toString() {
        String strData="X ="+ this.getX() + ", Y="+this.getY();
        return strData ;
    } 
}
