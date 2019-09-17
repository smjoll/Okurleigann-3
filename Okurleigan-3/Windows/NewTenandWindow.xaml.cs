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
    /// Interaction logic for NewTenandWindow.xaml
    /// </summary>
    public partial class NewTenandWindow : Window
    {


        Tenant t;


        public NewTenandWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            t = new Tenant();
            this.DataContext = t;
            lbTenands.DataContext = SharedContext.Apartments;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tenant selectedTenant = (Tenant)lbTenands.SelectedItem;

            t.ApartmentID = selectedTenant.Id;

            SharedContext.dbContext.Tenants.Add(t);
            SharedContext.dbContext.SaveChanges();
            this.Close();
        }

    }
}

