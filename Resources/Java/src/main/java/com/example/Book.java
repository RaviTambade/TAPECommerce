package com.example;

public class Book {

    private int isbn;
    private String bookName;

    public Book() {
    }

    public Book(int isbn, String bookName) {
        this.isbn = isbn;
        this.bookName = bookName;
    }

    public int getIsbn(){
        return this.isbn;
    }
    public void setIsbn(int i){
          this.isbn=i;
    }

    public String getBookName(){
        return this.bookName;
    }
    public void setBookName(String  bookName){
          this.bookName=bookName;
    }

    // getter setter methods
}