﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleKutya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string[]> nevek = new List<string[]>();
            File.ReadAllLines("D:\\C sharp\\ConsoleApp8\\datas\\KutyaNevek.csv").Skip(1).ToList().ForEach(x => nevek.Add(x.Split(";")));

            List<string[]> fajtak = new List<string[]>();
            File.ReadAllLines("D:\\C sharp\\ConsoleApp8\\datas\\KutyaFajtak.csv").Skip(1).ToList().ForEach(x => fajtak.Add(x.Split(";")));

            Console.WriteLine($"3. feladat: Kutyanevek száma: {nevek.Count()}");

            List<Kutya> kutyak = new List<Kutya>();
            File.ReadAllLines("D:\\C sharp\\ConsoleApp8\\datas\\Kutyak.csv").Skip(1).ToList().ForEach(x => kutyak.Add(new Kutya(int.Parse(x.Split(";")[0]), fajtak[int.Parse(x.Split(";")[1]) - 1][1], nevek[int.Parse(x.Split(";")[2]) - 1][1], int.Parse(x.Split(";")[3]), x.Split(";")[4])));

            Console.WriteLine($"6. feladat: A kutyák átlag életkora: {kutyak.Average(x => x.Eletkor):f2}");

            Console.WriteLine($"7. feladat: Legidősebb kutya neve és fajtája: {kutyak[kutyak.IndexOf(kutyak.MaxBy(x => x.Eletkor))].Nev}, {kutyak[kutyak.IndexOf(kutyak.MaxBy(x => x.Eletkor))].Fajta}");

            Console.WriteLine("8. feladat: Január 10.-én vizsgált kutya fajták:");
            kutyak.Where(x => x.Datum == "2018.01.10").ToList().GroupBy(x => x.Fajta).ToList().ForEach(x => Console.WriteLine($"\t{x.Key}: {x.Count()} kutya"));

            var legterheltebb = kutyak.GroupBy(x => x.Datum).ToList().OrderByDescending(x => x.Count()).ToList().First();
            Console.WriteLine($"9. feladat: Legjobban leterhelt nap: {legterheltebb.Key}.: {legterheltebb.Count()} kutya");

            List<string> mentes = new List<string>();
            kutyak.GroupBy(x => x.Nev).ToList().OrderByDescending(x => x.Count()).ToList().ForEach(x => mentes.Add($"{x.Key};{x.Count()}"));
            File.WriteAllLines("névstatisztika.txt", mentes);
            Console.WriteLine("10. feladat: névstatisztika.txt");
        }
    }
}