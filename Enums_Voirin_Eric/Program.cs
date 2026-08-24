using System;
using System.IO;


namespace Enums_Voirin_Eric
{

    enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }
    class Program
    {
        static void Main(string[] args)
        {
            int myBirthMonth = (int)Months.Sep;
            int myBirthDay = 10;
            int myBirthYear = 2008;

            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

            File.WriteAllText("myFilee.txt", "This is my text file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            File.AppendAllText("myFile.txt", "WooHoo more text added to the file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            if(!File.Exists("newFile.txt"))
            {
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
            }

            File.AppendAllText("newFile.txt", myBirthDate);
            Console.WriteLine(File.ReadAllText("newFile.txt"));
        }
    }
}
