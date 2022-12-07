package com.tfl.jdbc;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class DBManager {
    
    public static Connection con = null;
    public static PreparedStatement tflPrepareStat = null;

    public static void makeJDBCConnection() {
        //register jdbc driver registration
        try {
            Class.forName("com.mysql.jdbc.Driver");
            log("MySQL JDBC Driver Registered!");
        } 
        catch (ClassNotFoundException e) {
            log("Sorry, couldn't found JDBC driver. Make sure you have added JDBC Maven Dependency Correctly");
            e.printStackTrace();
            return;
        }
        
        // DriverManager: The basic service for managing a set of JDBC drivers.
        try {
            
            con = DriverManager.getConnection("jdbc:mysql://localhost:3306/ecommerce",
                                              "root", "password");
            if (con != null) {
                log("Connection Successful!");
            } else {
                log("Failed to make connection!");
            }
        } catch (SQLException e) {
            log("MySQL Connection Failed!");
            e.printStackTrace();
            return;
        }
    }

    public  static void insert(int id,String firstName, String lastName, String qualification) {
        try {
            String insertQueryStatement = "INSERT  INTO  students  VALUES  (?,?,?,?)";
            tflPrepareStat = con.prepareStatement(insertQueryStatement);
            tflPrepareStat.setInt(1, id);
            tflPrepareStat.setString(2, firstName);
            tflPrepareStat.setString(3, lastName);
            tflPrepareStat.setString(4, qualification);
            // execute insert SQL statement
            tflPrepareStat.executeUpdate();
            log(firstName + " added successfully");
        } catch (
        SQLException e) {
            e.printStackTrace();
        }
    }
    
    public  static void getDataFromDB() {
        try {
            // MySQL Select Query
            String getQueryStatement = "SELECT * FROM students";
            tflPrepareStat = con.prepareStatement(getQueryStatement);
           
            // Execute the Query, and get a java ResultSet
            ResultSet rs = tflPrepareStat.executeQuery();

            // Let's iterate through the java ResultSet
            while (rs.next()) {
                //int studentId = rs.getInt("studentId");
                String firstName = rs.getString("firstName");
                String lastName = rs.getString("lastName");
                String qualification = rs.getString("qualification");
                // Simply Print the results
                System.out.println(firstName + " "+ lastName + " "+ qualification);
            }
        } catch (
        SQLException e) {
            e.printStackTrace();
        }
    }

    // Simple log utility
    public  static void log(String string) {
        System.out.println(string);
    }
       
}
