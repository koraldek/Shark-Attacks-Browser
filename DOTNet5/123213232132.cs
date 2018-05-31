using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;

namespace DotNet_Lab_33 {
    class Program {
        static void Main(string[] args)
        {
            List<int> results = new List<int>();
            List<Attack> lAttacks = new List<Attack>();
            var csv = File.ReadAllLines("attacks.csv").Select(a => a.Split(';')).ToArray();

            foreach (String[] row in csv)
                lAttacks.Add(new Attack(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12]));
            lAttacks.Remove(lAttacks.First());

            // ============1===========
            var q11 = lAttacks.Select(n => n)
                .Where(n => n.Area == "Florida")
                .Count();
            var q111 = lAttacks.Select(n => n)
                .Where(n => n.Area == "Texas")
                .Count();
            q11 = q11 + q111;

            var q12 = lAttacks.Select(n => n)
       .Where(n => n.Country == "CHINA")
       .Count();

            var q13 = lAttacks.Select(n => n)
        .Where(n => n.Country == "GREECE")
        .Count();

            var q14 = lAttacks.Select(n => n)
.Where(n => n.Country == "CHILE")
.Count();
            Console.WriteLine("Zadanie 1:");
            Console.WriteLine(q11);
            Console.WriteLine(q12);
            Console.WriteLine(q13);
            Console.WriteLine(q14);
            // ============2===========
            var q21 = lAttacks.Select(n => n)
.Where(n => n.Country == "USA" && n.Fatal == "Y")
.Count();
            var q22 = lAttacks.Select(n => n)
.Where(n => n.Country == "AUSTRALIA" && n.Fatal == "Y")
.Count();
            var q23 = lAttacks.Select(n => n)
.Where(n => n.Country == "BRAZIL" && n.Fatal == "Y")
.Count();
            var q24 = lAttacks.Select(n => n)
.Where(n => n.Country == "IRAN" && n.Fatal == "Y")
.Count();
            var q25 = lAttacks.Select(n => n)
.Where(n => n.Fatal == "Y")
.Count();
            Console.WriteLine("Zadanie 2:");
            Console.WriteLine(q21);
            Console.WriteLine(q22);
            Console.WriteLine(q23);
            Console.WriteLine(q24);
            Console.WriteLine(q25);
            // ============3===========
            var q31 = lAttacks.Select(n => n)
                .Where(n => n.Country == "USA" && n.Age > 0)
                .Average(n => n.Age);
            var q32 = lAttacks.Select(n => n)
    .Where(n => n.Country == "ISRAEL" && n.Age > 0)
    .Average(n => n.Age);
            var q33 = lAttacks.Select(n => n)
    .Where(n => n.Country == "AUSTRALIA" && n.Age > 0)
    .Average(n => n.Age);
            var q34 = lAttacks.Select(n => n)
    .Where(n => n.Country == "CHILE" && n.Age > 0)
    .Average(n => n.Age);
            var q35 = lAttacks.Select(n => n)
    .Where(n => n.Country == "SOUTH AFRICA" && n.Age > 0)
    .Average(n => n.Age);

            Console.WriteLine("Zadanie 3:");
            Console.WriteLine(q31);
            Console.WriteLine(q32);
            Console.WriteLine(q33);
            Console.WriteLine(q34);
            Console.WriteLine(q35);
            // ============4===========
            var q41 = lAttacks.Select(n => n)
.Where(n => n.Country == "CHINA" && n.Fatal == "Y")
.Max(n => n.Age);
            var q42 = lAttacks.Select(n => n)
.Where(n => n.Country == "USA" && n.Activity == "Surfing")
.Where(n => n.Age > 0)
.Min(n => n.Age);

            Console.WriteLine("Zadanie 4:");
            Console.WriteLine(q41);
            Console.WriteLine(q42);

            // ============5===========
            var q51 = lAttacks.Select(n => n)
.Where(n => n.Type == "Provoked");
            List<String[]> q5 = new List<String[]>();
            foreach (Attack el in q51)
            {
                String[] s1 = { el.Country, el.Area, el.Age.ToString(), el.Fatal };
                q5.Add(s1);
            }
            Console.WriteLine("Zadanie 5:");
            foreach (String[] el in q5)
            {
                foreach (String el2 in el)
                    //             Console.Write(el2 + " /");
                    //            Console.WriteLine();
                    ; ;
            }
            // ============6===========
            var q61 = lAttacks.Select(n => n)
.Where(n => n.Type == "Unprovoked" && n.Fatal == "Y");
            var q62 = q61.Select(n => n)
.Where(n => n.Country == "USA");
            var q63 = q61.Select(n => n)
.Where(n => n.Type == "Unprovoked" && n.Fatal == "Y");

            List<Attack> q6 = new List<Attack>();
            foreach (Attack el in q62)
                q6.Add(el);
            foreach (Attack el in q63)
                q6.Add(el);
            // ============7===========
            List<Attack> q7 = lAttacks.Select(n => n)
.Where(n => n.Activity == "Surfing" && n.Age >= 30).ToList<Attack>();

            // ============8=========== 
            List<Attack> q8 = lAttacks.Select(n => n)
.Where(n => n.Country == "BRAZIL")
.OrderBy(n => n.Activity)
.ToList<Attack>();
            // ============9===========
            List<Attack> q9 = lAttacks.Select(n => n)
.Where(n => n.Country == "AUSTRALIA" && n.Activity == "Surfing" && n.Age > 0)
.OrderBy(n => n.Age)
.ToList<Attack>();
            // ============10===========
            var q101 = lAttacks.Select(n => n)
.Where(n => n.Sex == "M")
.OrderBy(n => n.Age)
.Count();
            var q102 = lAttacks.Select(n => n)
.Where(n => n.Sex == "F")
.OrderBy(n => n.Age)
.Count();
            Console.WriteLine("M:" + q101 + "\nF:" + q102);

            //foreach (Attack el in q10)
            //{
            //    Console.WriteLine( el.caseNumber +  "   b:" + el.Age);

            //}

            Console.WriteLine(q7);
            //int q31 = 0;
            //List<int> qList = new List<int>();
            //var qq31 = lAttacks.Select(n => n)
            //.Where(n => n.Country == "USA")
            //.Where(n => Int32.Parse(n.Age) > 0 && Int32.Parse(n.Age) < 150);
            //foreach (Attack a in qq31)
            //{
            //    qList.Add(Int32.Parse(a.Age));
            //}
            //foreach (int b in qList)
            //{
            //    q31 = q31 + b;
            //}
            //q31 = q31 / qList.Count;

            //Console.WriteLine(q31);



            //List<Attack> a1 = addressMatches.AddressMatches
            //            .Where(a => a.AddressIdentifier == "cpr")
            //            .ToList<Attack>();

            //from TYP_OBIEKTU in KOLEKCJA_OBIEKTOW
            //where WARUNEK
            //orderby PORZADEK
            //select TYP_OBIEKTU
            Console.ReadKey();
        }
    }


    public class Person {
        public string PersonId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public Person(string sPersonId, string sFirstName, string sLastName, int nAge)
        {
            PersonId = sPersonId;
            FirstName = sFirstName;
            LastName = sLastName;
            Age = nAge;
        }
    }
    public class Attack {
        public String caseNumber { get; set; }
        public String Date { get; set; }
        public String Year { get; set; }
        public String Type { get; set; }
        public String Country { get; set; }
        public String Area { get; set; }
        public String Location { get; set; }
        public String Activity { get; set; }
        public String Name { get; set; }
        public String Sex { get; set; }
        public int Age { get; set; }
        public String Injury { get; set; }
        public String Fatal { get; set; }

        public Attack(string caseNumber, String Date, String Year, String Type, String Country, String Area, String Location, String Activity, String Name, String Sex, String Age, String Injury, String Fatal)
        {
            this.caseNumber = caseNumber;
            this.Date = Date;
            this.Year = Year;
            this.Type = Type;
            this.Country = Country;
            this.Area = Area;
            this.Location = Location;
            this.Activity = Activity;
            this.Name = Name;
            this.Sex = Sex;
            this.Injury = Injury;
            this.Fatal = Fatal;

            this.Age = -2; // jesli beda same litery
            String Snumber = "";
            if (Age == "")
                this.Age = -1;
            else
            {
                char[] Carr = Age.ToArray(); // { '4', '2'}
                foreach (char c in Carr)
                {
                    int digit;
                    if (!Int32.TryParse(c.ToString(), out digit))
                        break;
                    Snumber = Snumber + digit.ToString();
                }
                if (!Snumber.Equals(""))
                    this.Age = Int32.Parse(Snumber);
            }
        }
    }
}










