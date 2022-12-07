using MySql.Data.MySqlClient ;
string conString=@"server=localhost;user=root;database=ecommerce;port=3306;password=password";

MySqlConnection con=new MySqlConnection();
con.ConnectionString=conString;
try{
    /* DDL Command */
    //string query="CREATE TABLE tflroles (roleid INT NOT NULL PRIMARY KEY AUTO_INCREMENT,  title VARCHAR(25))";
    //string query="DROP TABLE tflroles";
    //string query="CREATE TABLE tflroles (roleid INT NOT NULL PRIMARY KEY AUTO_INCREMENT,  title VARCHAR(25))";
    /* DML Command */

    //string query="INSERT INTO tflroles (title) values('Trainer')";
    //string query="DELETE from tflroles  WHERE title='Trainer'";
    //string query="UPDATE tflroles SET title='CEO' WHERE roleid=1";
    Console.WriteLine("Please enter  new Role:");
    string role=Console.ReadLine();
    string query="INSERT INTO tflroles (title) values('"+ role+ "')";

    MySqlCommand cmd=new MySqlCommand(query,con);
    con.Open();
    cmd.ExecuteNonQuery();  // 
}
catch(Exception ee){
    Console.WriteLine(ee.Message);

}
finally{
    con.Close();
}

