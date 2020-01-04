using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> newStudList = new List<string>();
            List<string> addStudList = new List<string>();

            newStudList.Add("Pirmas Antras");
            newStudList.Add("Trecias Ketvirtas");
            newStudList.Add("Penktas Sestas");
            newStudList.Add("Septintas Astuntas");
            newStudList.Add("Devintas Desimtas");
            newStudList.Add("Vienuoliktas Dvyliktas");

            addStudList.Add("Tryliktas Keturioliktas");
            addStudList.Add("Penkioliktas Sesioliktas");
            addStudList.Add("Septynioliktas Astuonioliktas");

            Console.WriteLine("Studentu sarasas:");
            newStudList.ForEach(Console.WriteLine);
            Console.ReadLine();
            Console.WriteLine("Nauju studentu sarasas:");
            addStudList.ForEach(Console.WriteLine);
            Console.ReadLine();
            newStudList.AddRange(addStudList);
            Console.WriteLine("Pilnas satudentu sarasas:");
            newStudList.ForEach(Console.WriteLine);
            Console.ReadLine();
            newStudList.Sort();
            Console.WriteLine("Surusiuotas satudentu sarasas:");
            newStudList.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
