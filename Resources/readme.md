JDBC application :
Create class DBManager.java
Create standard DB Connection, PreparedStatement and ResultSet Objects
Perform executeUpdate() operation to insert data into Table
Perform executeQuery() operation to retrieve data from MySQL Table
In our case:
Database Name: ecommerce
Username: root
Password: password
Table Name: student
Step - 1: Create connection to DB. In case of JDBC failure, we will throw an error message
Step - 2: We will add 3 records to Database
Step - 3: We will read all records one by one and print it on debug  Console of vs code