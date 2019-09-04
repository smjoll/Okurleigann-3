using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Okurleigan_3.Models;

namespace Okurleigan_3.Windows
{
    /// <summary>
    /// Interaction logic for NewApartmentWindow.xaml
    /// </summary>
    public partial class NewApartmentWindow : Window
    {

        Apartment a;

        public NewApartmentWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            a = new Apartment();
            this.DataContext = a;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SharedContext.dbContext.Apartments.Add(a);
            SharedContext.dbContext.SaveChanges();
            this.Close();
        }
    }
}
