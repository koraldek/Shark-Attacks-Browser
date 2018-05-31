using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DOTNet5 {

    public partial class MainWindow : NavigationWindow {
    
        public MainWindow()
        {

            InitializeComponent();
        }


    }


    public class Person {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(int nPersonId, string sFirstName, string sLastName,
            int nAge)
        {
            PersonId = nPersonId;
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
