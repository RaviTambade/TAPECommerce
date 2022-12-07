## JDBC application :
Create class DBManager.java
Create standard DB Connection, PreparedStatement and ResultSet Objects
Perform executeUpdate() operation to insert data into Table
Perform executeQuery() operation to retrieve data from MySQL Table
<br/>
In our case:
Database Name: ecommerce
Username: root
Password: password
Table Name: student
<br/>
There are following six steps involved in building a JDBC application −

-Import the packages − Requires that you include the packages containing the JDBC classes needed for database programming. Most often, using import java.sql.* will suffice.

-Open a connection − Requires using the DriverManager.getConnection() method to create a Connection object, which represents a physical connection with the database.

-Execute a query − Requires using an object of type Statement for building and submitting an SQL statement to the database.

-Extract data from result set − Requires that you use the appropriate ResultSet.getXXX() method to retrieve the data from the result set.