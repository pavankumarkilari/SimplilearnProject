using System;
using System.IO;

namespace ConAppStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string FilePath = "C:\\Users\\kpava\\Desktop\\Mphasis\\Simplilearn_Projects\\Phase2StudentData\\ConAppStudent\\StudentData.txt";
                string[] Lines = File.ReadAllLines(FilePath);
                foreach (string Line in Lines)
                {
                    Console.WriteLine(Line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!" + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
