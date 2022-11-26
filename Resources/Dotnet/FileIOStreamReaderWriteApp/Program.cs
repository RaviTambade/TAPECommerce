using System.IO;

string filePath=@"D:/seed.txt";

//File content writing
FileStream fs=new FileStream(filePath, FileMode.Create);
using(StreamWriter sw=new StreamWriter(fs)){
    sw.WriteLine("Welcome To Transflower");
    sw.WriteLine("\n a learning expereince");
    sw.WriteLine("\n doing ordinary things extra ordinarily");
}


//reading file content

using(StreamReader sr=new StreamReader(filePath)){
    string txt;
    //Read data from file, until the end of file is reached
    while((txt=sr.ReadLine())!=null){
        Console.WriteLine(txt);
    }
}
