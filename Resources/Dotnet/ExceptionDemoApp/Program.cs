        using System;
        using System.IO;
        using TransflowerExceptions;
        
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

    //Throwing Custom Exception

    string name = null;
    if (string.IsNullOrEmpty(name))
    {
        throw new TutlaneCustomException("Name is Empty");
    }
    else
    {
        Console.WriteLine("Name: " + name);
    }
