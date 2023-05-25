using System;

namespace ConsoleKutya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string[]> nevek = new List<string[]>();
            StreamReader sr = new StreamReader("D:\\C sharp\\ConsoleApp8\\datas\\KutyaNevek.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                nevek.Add(sor.Split(";"));
            }
            sr.Close();


            List<string[]> fajtak = new List<string[]>();
            sr = new StreamReader("D:\\C sharp\\ConsoleApp8\\datas\\KutyaFajtak.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                fajtak.Add(sor.Split(";"));
            }
            sr.Close();


            Console.WriteLine($"3.feladat: Kutyanevek száma: {nevek.Count()}");
        }
    }
}