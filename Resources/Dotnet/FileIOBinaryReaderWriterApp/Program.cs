
using System.IO;

string filePath=@"D:\test.txt";

//Write data into file using BinaryWriter class

FileStream fs=new FileStream(filePath, FileMode.Create);
using(BinaryWriter bw=new BinaryWriter(fs)){
    bw.Write(23.56);
    bw.Write("Welcome to Transflower for learning technolgy with its natrual form");
    bw.Write(45);
    bw.Write(true);
}

//Read data from file using BinaryReader

FileStream fs2=File.Open(filePath, FileMode.Open);

using(BinaryReader br=new BinaryReader(fs2)){
    Console.WriteLine(br.ReadDouble());
    Console.WriteLine(br.ReadString());
    Console.WriteLine(br.ReadInt32());
    Console.WriteLine(br.ReadBoolean());
}
