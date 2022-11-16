using System.Text;
using System.IO;

namespace TFLIO;
public class IOManager{

    //Following is the example of writing a text to file using the FileStream object in c#.

    public static void WriteToFile()
       {
          string fpath = @"D:\Test.txt";
          // Delete file if exists
          if (File.Exists(fpath))
          {
              File.Delete(fpath);
          }
          // Create the file
          using (FileStream fs = File.Create(fpath))
          {
              AddTexttoFile(fs, "Hi");
              AddTexttoFile(fs, "\r\nWelcome to Transflower");
              AddTexttoFile(fs, "\r\nFileStream Example");
          }
       }
    private static void AddTexttoFile(FileStream fs, string value)
       {
          byte[] info = new UTF8Encoding(true).GetBytes(value);
          fs.Write(info, 0, info.Length);
       }

     public static void ReadFromFile(){
        string fpath = @"D:\Test.txt";
          // Check if file exists
          if (File.Exists(fpath))
          {
             // Open the file and read
             using (FileStream fs = File.OpenRead(fpath))
             {
                byte[] b = new byte[1024];
                UTF8Encoding encode = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                   Console.WriteLine(encode.GetString(b));
                }
             }
          }
     }

    public static void WriteUsingTextWriter(){
        string fpath = @"D:\Test.txt";
          // Check file if exists
          if (File.Exists(fpath))
          {
             File.Delete(fpath);
          }
          // Create the file
          using (TextWriter wr = File.CreateText(fpath))
          {
             wr.WriteLine("Hi");
             wr.WriteLine("\r\nWelcome to Transflower");
             wr.WriteLine("\r\nTextWriter Example");
          }

    }

    public static void ReadUsingTextReader(){
    string fpath = @"D:\Test.txt";
          // Check if file exists
          if (File.Exists(fpath))
          {
             // Open the file and read
             using (TextReader tr = File.OpenText(fpath))
             {
                 Console.WriteLine(tr.ReadToEnd());
             }
          }

    }

    public static void WriteUsingStreamWriter(){
        string fpath = @"D:\Test.txt";
          // Check file if exists
          if (File.Exists(fpath))
          {
             File.Delete(fpath);
          }
          // Create the file
          FileStream fs = new FileStream(fpath, FileMode.Create);
          using (StreamWriter sw = new StreamWriter(fs))
          {
             sw.WriteLine("Hi");
             sw.WriteLine("\r\nWelcome to Transflower");
             sw.WriteLine("\r\nStreamWriter Example");
          }
    }

    public static void ReadUsingStreamReader(){

         string fpath = @"D:\Test.txt";
            // Check if file exists
            if (File.Exists(fpath))
            {
               // creating StreamReader instance to read from a file
               using (StreamReader sr = new StreamReader(fpath))
               {
                  string txt;
                  // Read the data from file, until the end of file is reached
                  while ((txt = sr.ReadLine()) != null)
                  {
                     Console.WriteLine(txt);
                  }
               }
            }
    }

    public static void WriteUsingBinaryWriter(){
        string fpath = @"D:\Test.txt";
            // Check file if exists
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }
            using (BinaryWriter bw = new BinaryWriter(File.Open(fpath,FileMode.Create)))
            {
                bw.Write(1.25);
                bw.Write("Welcome to Transflower");
                bw.Write(10);
                bw.Write(true);
                bw.Write("test");
            }
    }

     public static void ReadUsingBinaryReader(){

         string fpath = @"D:\Test.txt";
            // Writing values to file
            if (File.Exists(fpath))
            {
               File.Delete(fpath);
            }
            using (BinaryWriter bw = new BinaryWriter(File.Open(fpath, FileMode.Create)))
            {
               bw.Write(1.25);
               bw.Write("Welcome to Transflower");
               bw.Write(10);
               bw.Write(true);
               bw.Write("test");
            }
            // Reading Values by creating BinaryReader instance
            using (BinaryReader br = new BinaryReader(File.Open(fpath, FileMode.Open)))
            {
               Console.WriteLine(br.ReadDouble());
               Console.WriteLine(br.ReadString());
               Console.WriteLine(br.ReadInt32());
               Console.WriteLine(br.ReadBoolean());
               Console.WriteLine(br.ReadString());
            }

     }


    public static void CreateWriteFileUsingFileInfo(){
        string fpath = @"D:\Test.txt";
          // Check file if exists
          if (File.Exists(fpath))
          {
             File.Delete(fpath);
          }
          // Create the file
          FileInfo fi = new FileInfo(fpath);
          //fi.Create();
          // Create and write data to file
          using (StreamWriter sw = fi.CreateText())
          {
             sw.WriteLine("Hi");
             sw.WriteLine("\r\nWelcome to Transflower");
             sw.WriteLine("\r\nFileInfo Example");
          }

    }

    public static void ReadFileUsingFileInfo(){
            string fpath = @"D:\Test.txt";
           // Check if file exists
           if (File.Exists(fpath))
           {
              FileInfo fi = new FileInfo(fpath);
              // open the file to read text
              using (StreamReader sr = fi.OpenText())
              {
                 string txt;
                 // Read the data from file, until the end of file is reached
                 while ((txt = sr.ReadLine()) != null)
                 {
                    Console.WriteLine(txt);
                 }
              }
           }
    }


    public static void FileHandlingTryCatchFinally(){
        string fpath = @"D:\Test.txt";
        StreamReader sr = new StreamReader(fpath);
        try
        {
            string txt;
            while ((txt = sr.ReadLine()) != null)
            {
            Console.WriteLine(txt);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: {0}", ex.Message);
        }
        finally
        {
            if (sr != null)
            {
            sr.Close();
            }
        }
        Console.ReadLine();
    }

}