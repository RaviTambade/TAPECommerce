## JDBC application :

There are following six steps involved in building a JDBC application −

-Import the packages − Requires that you include the packages containing the JDBC classes needed for database programming. Most often, using import java.sql.* will suffice.

-Open a connection − Requires using the DriverManager.getConnection() method to create a Connection object, which represents a physical connection with the database.

-Execute a query − Requires using an object of type Statement for building and submitting an SQL statement to the database.

-Extract data from result set − Requires that you use the appropriate ResultSet.getXXX() method to retrieve the data from the result set.