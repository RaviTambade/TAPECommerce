using System.Text;
using System.Collections.Generic;


// Declare without initializing.
string str1;
// Declaring and Initializing
string str2 = "Welcome to Transflower";
String str3 = "Hello World!";
// Initialize an empty string.
string str4 = String.Empty;
// Initialize to null.
String str5 = null;
// Creating a string from char
char[] letters = { 'A', 'B', 'C' };
string str6 = new string(letters);



//C# string Literal (Regular, Vervatim)
string names = "Kamlesh\nRutuja\nTanaya";
Console.WriteLine(names);
/*
Output:
Kamlesh
Rutuja
Tanaya
*/
string msg = "Welcome to \"Transflower\" world";
Console.WriteLine(msg);
// Output: Welcome to "Transflower" world


//Following is an example of using verbatim literal @ in c# programming language to represent a multiline string and a file path.

string path = @"C:\Users\Transflower\Documents\";
Console.WriteLine(path);
//Output: C:\Users\Transflower\Documents\

string msg = @"Hi Guest,
Welcome to Transflower World
Learning Made Easy";
Console.WriteLine(msg);
/* Output:
Hi Guest,
Welcome to Transflower World
Learning Made Easy
*/

string msg1 = @"My daughter name was ""Tanaya.""";
Console.WriteLine(msg1);
//Output: My daughter name was "Tanaya."


//C# Format Strings

string name = "Sameer Pande";
string location = "Pune";
string user = string.Format("Name: {0}, Location: {1}", name, location);
Console.WriteLine(user);
// Output: Name: Sameer Pande, Location: Pune


//C# Access Individual Characters from Strings
string name = "Sameer Pande";
for (int i = 0; i < name.Length; i++)
{
Console.Write(name[i]);
}
// Output: Sameer Pande


//Following is the example declaring and initializing strings, formatting string value, and use string literals to represent data in the c# programming language.

    string firstname = "Kamlesh";
    string lastname = "Pande";
    string location = "Pune";
    string name = firstname + " " + lastname;
    Console.WriteLine(name);
    string userInfo = string.Format("Name: {0}, Location: {1}", name, location);
    Console.WriteLine(userInfo);
    string names = "Kamlesh\nRutuja\nTanaya";
    Console.WriteLine(names);
    string path = @"C:\Users\Transflower\Documents\";           
    Console.WriteLine(path);
    string msg = @"Hi Guest,
    Welcome to Transflower World
    Learning Made Easy";
    Console.WriteLine(msg);
    string msg1 = @"Her name was ""Tanaya.""";
    Console.WriteLine(msg1);
    Console.WriteLine("\nPress Enter Key to Exit..");
    Console.ReadLine();



//C# String Split Method example

    string msg = "Kamlesh,Rutuja,Tanaya";
    string[] strarr = msg.Split(',');
    for (int i = 0; i < strarr.Length; i++)
    {
           Console.WriteLine(strarr[i]);
    }
    Console.WriteLine("\nPress Enter Key to Exit..");
    Console.ReadLine();



//C# Split String with Multiple Delimiters
//Following is the example of splitting the given string with multiple delimiters in the c# programming language.

    string msg = "Kamlesh,Rutuja,Tanaya,-Praveen%Sateesh";
    string[] strarr = msg.Split(new char[] { ',', '-', '%' }, StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < strarr.Length; i++)
    {
        Console.WriteLine(strarr[i]);
    }
    Console.WriteLine("\nPress Enter Key to Exit..");
    Console.ReadLine();


//Following is the example to return the split method result as a list in the c# programming language.

    string msg = "Kamlesh,Rutuja,Tanaya,-Praveen%Sateesh";
    IList list = new List(msg.Split(new char[] { ',', '-', '%' }, StringSplitOptions.RemoveEmptyEntries));
    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine(list[i]);
    }
    Console.WriteLine("\nPress Enter Key to Exit..");
    Console.ReadLine();

//Following is the example of using the Replace() method to replace a particular part of a string or a character c# programming language.
    string msg = "Hi Guest Hi";
    string nmsg = msg.Replace("Hi", "Welcome");
    Console.WriteLine("Old: {0}", msg);
    Console.WriteLine("New: {0}", nmsg);

    string x = "aaaaa";
    string nx = x.Replace("a", "b").Replace("b", "c");
    Console.WriteLine("Old: {0}", x);
    Console.WriteLine("New: {0}", nx);

    string y = "1 2 3 4 5 6 7";
    string ny = y.Replace(" ", ",");
    Console.WriteLine("Old: {0}", y);
    Console.WriteLine("New: {0}", by);

    Console.WriteLine("\nPress Enter Key to Exit..");
    Console.ReadLine();


//Following is the example of using the Concat() method to append or concatenate one or more strings and return it as a new string in the c# programming language.

    string msg1 = "Welcome to";
    string msg2 = " " + "Transflower";
    Console.WriteLine("Message: {0}", string.Concat(msg1, msg2));

    string name1 = "Kamlesh";
    string name2 = ", " + "Rutuja";
    string name3 = ", " + "Tanaya";
    Console.WriteLine("Users: {0}", string.Concat(string.Concat(name1, name2), name3));

    Console.WriteLine("\nPress Enter Key to Exit..");
    Console.ReadLine();



//Following is the example of using Contains() method to check whether the given value occurs within the string or not in the c# programming language.

    string msg = "Welcome to Transflower";
    string subtxt = "Transflower";
    Console.WriteLine("Does {0} String Contains {1}?: {2}", msg, subtxt, msg.Contains(subtxt));
    string subtxt1 = "Transflower";
    Console.WriteLine("Does {0} String Contains {1}?: {2}", msg, subtxt1, msg.Contains(subtxt1));
    Console.WriteLine("\nPress Enter Key to Exit..");
    Console.ReadLine();

//To perform a case-insensitive string comparison, you need to use the string IndexOf method. Following is the example of performing a case insensitive search in the c# programming language.
    string msg = "Welcome to Transflower";
    string subtxt = "Transflower";
    Console.WriteLine("Does {0} String Contains {1}?: {2}", msg, subtxt, msg.Contains(subtxt));
    string subtxt1 = "Transflower";
    StringComparison comp = StringComparison.OrdinalIgnoreCase;
    bool result = msg.IndexOf(subtxt1, comp) > 0 ? true : false;
    Console.WriteLine("Does {0} String Contains {1}?: {2}", msg, subtxt1, result);
    Console.WriteLine("\nPress Enter Key to Exit..");
    Console.ReadLine();

//Following is the example of using the Compare() method to compare a given two strings and return an integer value in the c# programming language.
    string str1 = "Kamlesh";
    string str2 = "Pande";
    Console.WriteLine("Comparison of {0} and {1} Result: {2}", str1, str2, string.Compare(str1, str2));

    string str3 = "Rutuja";
    string str4 = "Tanaya";
    Console.WriteLine("Comparison of {0} and {1} Result: {2}", str3, str4, string.Compare(str3, str4));

    Console.WriteLine("\nPress Enter Key to Exit..");
    Console.ReadLine();

//Following is the example of using a string Remove() method to delete characters in string based on the defined position in c# programming language.

     string msg = "Welcome to Transflower";
    Console.WriteLine("Remove Result: {0}", msg.Remove(5));
    Console.WriteLine("Remove with Length: {0}", msg.Remove(3, 7));
    Console.WriteLine("\nPress Enter Key to Exit..");
    Console.ReadLine();

//Following is the example of using a string Format() method to insert an object or variable or expression value into another string in the c# programming language.
    string s = "Name:{0} {1}, Location:{2}, Age:{3}";
    string msg = string.Format(s, "Kamlesh", "Pande", "Pune", 32);
    Console.WriteLine("Format Result: {0}", msg);
    Console.WriteLine("\nPress Enter Key to Exit..");
    Console.ReadLine();

//Following is the example of controlling the appearance of format items using the string Format() method in the c# programming language.
    decimal num = 75.73789621m;
    DateTime datetime = DateTime.Now;
    Console.WriteLine("Format Decimal: {0:n2}", num);
    Console.WriteLine("DateTime: {0}", datetime);
    Console.WriteLine("Only Date: {0:D}", datetime);
    Console.WriteLine("Only Time: {0:T}", datetime);
    Console.WriteLine("\nPress Enter Key to Exit..");
    Console.ReadLine();

//Following is the example of using the string Equals() method to check whether the given strings are equal or not in the c# programming language.
    string fname = "Kamlesh";
    string lname = "Pande";
    Console.WriteLine("{0} Equals to {1}? : {2}", fname, lname, fname.Equals(lname));
    string l_name = "Kamlesh";
    Console.WriteLine("{0} Equals to {1}? : {2}", fname, l_name, fname.Equals(l_name));
    string u_name = "Kamlesh";
    Console.WriteLine("{0} Equals to {1}? : {2}", fname, u_name, fname.Equals(u_name));
    Console.WriteLine("\nPress Enter Key to Exit..");
    Console.ReadLine();

//Following is the example of using a string Clone() method to clone a specified string object and return a copy of the same data in the c# programming language.
    string msg = "Welcome to Transflower";
    string msg1 = (string)msg.Clone();
    Console.WriteLine("String: {0}", msg);
    Console.WriteLine("Clone String: {0}", msg1);
    Console.WriteLine("Reference Equals: {0}", Object.ReferenceEquals(msg, msg1));
    Console.WriteLine("\nPress Enter Key to Exit..");
    Console.ReadLine();

//Following is the example of using a string Copy() method to create a new string object with the same content of specified string in the c# programming language.
    string msg = "Welcome to Transflower";
    string msg1 = string.Copy(msg);
    Console.WriteLine("String: {0}", msg);
    Console.WriteLine("Copy String: {0}", msg1);
    Console.WriteLine("Reference Equals: {0}", Object.ReferenceEquals(msg, msg1));
    Console.WriteLine("\nPress Enter Key to Exit..");
    Console.ReadLine();

//Following is the example of using the string Trim() method to remove the starting and ending of whitespaces or specified characters from the string object in the c# programming language.
    // Trim Whitespaces
    string str1 = " Welcome";
    string str2 = " to ";
    string str3 = " Transflower";
    Console.WriteLine("Before Trim: {0} {1} {2}", str1, str2, str3);
    Console.WriteLine("After Trim: {0} {1} {2}", str1.Trim(), str2.Trim(), str3.Trim());
    char[] trimChars = { '*', '@', ' ' };
    // Trim with Characters
    string str4 = "@@** Sameer Pande **@";
    Console.WriteLine("Before Trim: {0}", str4);
    Console.WriteLine("After Trim: {0}", str4.Trim(trimChars));
    Console.WriteLine("\nPress Enter Key to Exit..");
    Console.ReadLine();

    //Following is the example of using the Join() method to append or concatenate all string array elements using a specified separator in the c# programming language.
     string[] sArr = { "Welcome", "to", "Transflower" };
    Console.WriteLine("Join with Hypen: {0}", string.Join("-", sArr));
    string[] sArr1 = { "Kamlesh", "Rutuja", "Tanaya" };
    Console.WriteLine("Join with Comma: {0}", string.Join(", ", sArr1));
    Console.WriteLine("\nPress Enter Key to Exit..");
    Console.ReadLine();

    //Following is the example of using StringBuilder to insert or append or replace or remove a particular string text in c# programming language.
    StringBuilder sb = new StringBuilder("Suresh");
    sb.Append(", Rohini");
    sb.Append(", Trishika");
    sb.AppendLine();
    sb.Append("Welcome to Tutlane");
    Console.WriteLine(sb);

    StringBuilder sb1 = new StringBuilder("Welcome World");
    sb1.Insert(8, "to Tutlane ");
    Console.WriteLine("Insert String: " + sb1);

    StringBuilder sb2 = new StringBuilder("Welcome to Tutlane");
    sb2.Remove(8, 3);
    Console.WriteLine(sb2);

    StringBuilder sb3 = new StringBuilder("Welcome to Tutlane World");
    sb3.Replace("Tutlane", "C#");
    Console.WriteLine(sb3);
    Console.ReadLine();