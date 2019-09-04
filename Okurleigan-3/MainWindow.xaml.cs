using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Okurleigan_3.Models;
using Okurleigan_3.Windows;

namespace Okurleigan_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CollectionViewSource view = new CollectionViewSource();
            SharedContext.dbContext.Apartments.Load();
            SharedContext.dbContext.Tenants.Load();
            SharedContext.Apartments = SharedContext.dbContext.Apartments.Local;

            view.Source = SharedContext.Apartments;
            this.DataContext = view;

        }

        private void menu_QuitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void new_ApartmentClick(object sender, RoutedEventArgs e)
        {
            NewApartmentWindow win = new NewApartmentWindow();
            win.ShowDialog();
        }

        private void new_TenantClick(object sender, RoutedEventArgs e)
        {
            NewTenandWindow win = new NewTenandWindow();
            win.ShowDialog();
        }

        private void new_incidentClick(object sender, RoutedEventArgs e)
        {
            NewIncidentWindow win = new NewIncidentWindow();
            win.ShowDialog();
        }

        private void change_ApartmentClick(object sender, RoutedEventArgs e)
        {
            ChangeApartmentWindow win = new ChangeApartmentWindow();
            win.ShowDialog();
        }

        private void change_TenantClick(object sender, RoutedEventArgs e)
        {

        }

        private void change_IncidentClick(object sender, RoutedEventArgs e)
        {

        }

        private void erase_ApartmentClick(object sender, RoutedEventArgs e)
        {

        }

        private void erase_TenantClick(object sender, RoutedEventArgs e)
        {

        }

        private void erase_IncidentClick(object sender, RoutedEventArgs e)
        {

        }

        private void LbTenants_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SharedContext.selectedTenant = (Tenant)lbTenants.SelectedItem;
            
        }
    }
}
