using System.IO;
using System.Text;

string filePath=@"d:\Data.txt";

/*if(File.Exists(filePath))
{
    File.Delete(filePath);
}
*/

//Exception Handling
try{
    //Text Writing
   using(TextWriter writer=File.CreateText(filePath))
    {
        string data="My name is Ravi Tambade";
        writer.WriteLine(data);
    }

    //Text Readiong
    using (TextReader reader=File.OpenText(filePath))
    {
        string data=reader.ReadToEnd();
        Console.WriteLine(data);
    }
}
catch( Exception e){
    Console.WriteLine(e.Message);
}