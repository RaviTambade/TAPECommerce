//Third party packages
//downloading using dotnet add package command
// dotnet add package mysql.data

//steps for simple database connectivity in .net core application
//1.Create simple donet core console application using dotnet new command
//2.Download mysql.data package from internet using dotnet add package mysql.data
//3.Import Mysql.Data.MySqlClient namespace into Program.cs file
//4.
using MySql.Data.MySqlClient ;

//after going through documentation avaialble at 
//https://dev.mysql.com/doc/connector-net/en/connector-net-tutorials-sql-command.html


//This package provides lot of readymade classes with thier member functions, properties,etc.
//to communicate with remote mysql databases
//1.MySqlConnection  : is used to establish connection with mysql Database server
//2.MySqlCommand:       is used to define query (DDL, DML, SQL) to be fire against remote database server
//3. MySqlDataReader:   is used to iterate number of records fetched due to ExecuteReader method 
//4. Use reader indexer  rdr[0], etc. to read each content of records field value

//ADO.net Programming in .net
//5. Define connection string to communication with MySQL database server.
string conStr="server=localhost; uid=root;password=password;database=ecommerce";
//6. Create Instance of MySqlConnection class
MySqlConnection con=new MySqlConnection();

//6. define Try cach finally block for database programming
//7. attach connection string to connection instance using ConnectionSTring property
//8. set query statement to MySqlCommand object (instance) 
//9.  Fetch data from table using MySqlCommand object method ExecuteReader
//10. loop throgh  mySqlDataReader object to show each recrod till end of record reached.
//11. Close datareader as well as connection 

try{
    con.ConnectionString=conStr;
    con.Open();
    //string query = "SELECT * FROM Employees";
    //string query = "SELECT * FROM Employees WHERE jobTitle='President'";
    string query = "SELECT * FROM Employees WHERE jobTitle='Sales Rep' ORDER BY officeCode";
    MySqlCommand cmd = new MySqlCommand(query, con);
    MySqlDataReader rdr = cmd.ExecuteReader();

    while (rdr.Read())
    {
        //Console.WriteLine(rdr[0]+" -- "+rdr[1]+" -- "+rdr[2]+" -- "+rdr[4]);
        Console.WriteLine(rdr["officeCode"]+"***" + rdr["employeeNumber"]+" -- "+rdr["lastName"]+" -- "+rdr["firstName"]+" -- "+rdr["jobTitle"]);
    }
    rdr.Close();
}
catch(Exception ee){
    Console.WriteLine(ee.Message);
}
finally{
    con.Close();
}