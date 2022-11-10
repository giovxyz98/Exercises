using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Log
{
    internal partial class Program
    {
        public static partial class Log
            
        {
            
            public static string FCheck() //esegue tutti i controlli necessari
            {
                string _path = @"C:\Users\Giovanni\Desktop";
                string _dir = Check.CheckDir(_path);
                string _file = Check.CheckFile(_dir);
                return _file;
            }
     
            public static void AddLog(string username,string password)  //aggiunge il log
            {
               
                var _file= FCheck();
                var x = File.ReadAllLines(_file);
                
                int id = x.Length-1;
                Console.WriteLine("Siamo arrivati all'utente:{0}",x.Length);
                List<string> log=new List<string>();
                StringBuilder a=new StringBuilder();
                var data = DateTime.Now;
                var dataMs =data.Millisecond;
                a.AppendLine(string.Format($"{id}---{username}                      {password}                {data}:{dataMs}"));
                File.AppendAllText(_file,a.ToString()); 
                
                 

                
            }
    
        }
    }
}
