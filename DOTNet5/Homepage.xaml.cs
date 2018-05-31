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
    /// <summary>
    /// Interaction logic for Homepage.xaml
    /// </summary>
    public partial class Homepage : Page {
        List<Attack> lAttacks = null;
        public Homepage()
        {
            InitializeComponent();
            InitBinding();
        }

        private void InitBinding()
        {
            lAttacks = new List<Attack>();
            var csv = File.ReadAllLines("attacks.csv").Select(a => a.Split(';')).ToArray();

            foreach (String[] row in csv)
                lAttacks.Add(new Attack(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12]));
            lAttacks.Remove(lAttacks.First());
                lstVictims.ItemsSource = lAttacks;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Details detailsPage = new Details(this.lstVictims.SelectedItem);
            this.NavigationService.Navigate(detailsPage);
        }
    }
}
