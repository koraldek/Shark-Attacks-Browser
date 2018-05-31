using System;
using System.Collections.Generic;
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
    /// Interaction logic for Details.xaml
    /// </summary>
    public partial class Details : Page {
        public Details()
        {
            InitializeComponent();
        }

        // Custom constructor to pass expense report data
        public Details(object data):this()
    {
            // Bind to expense report data.
            this.DataContext = data;
        }
    }
}
