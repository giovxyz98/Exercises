using System.IO;

namespace esercizio_scrivi_su_file
{
    public static class Check
    {
        public static string CheckDir(string path)
        {
            if (!Directory.Exists(Path.Combine(path, "File")))
            {
                Directory.CreateDirectory(Path.Combine(path, "File"));

            }
            string a = Path.Combine(path, "File");
            return a;

        }
        public static string CheckFile(string pathD) 
        {
            if (!File.Exists(Path.Combine(pathD, "File.txt")))
            {
                File.AppendAllText(Path.Combine(pathD, "File.txt"), "");
            }




            string x = Path.Combine(pathD, "File.txt");
            return x;
        }
    }
}
