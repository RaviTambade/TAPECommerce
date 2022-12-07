package com.tfl.jdbc;
import java.sql.SQLException;
public class App 
{
    
    public static void main( String[] args )
    {
        System.out.println( "Hello Transflower 123!" );
        try {
                DBManager.log("-------- Simple TFL Tutorial on how to make JDBC connection to MySQL DB locally on Windows ------------");
                DBManager.makeJDBCConnection();
                DBManager.log("\n---------- Adding company 'Transflower LLC' to DB ----------");
                DBManager.insert(7,"Shiv", "Yadav", "BCA");
                DBManager.insert(8,"Simran", "Kapoor", "MCA");
                DBManager.insert(9,"Rajiv", "Sinha", "BE comp");
                DBManager.insert(10,"Shubhangi", "Jadhav", "BCA");
            
                DBManager.log("\n---------- fetch Data from DB ----------");
                DBManager.getDataFromDB();
                DBManager.tflPrepareStat.close();
                DBManager.con.close(); // connection close
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
}
