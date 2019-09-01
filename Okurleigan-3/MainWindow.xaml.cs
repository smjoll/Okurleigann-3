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
            SharedContext.Apartments = SharedContext.dbContext.Apartments.Local;

            view.Source = SharedContext.Apartments;
            this.DataContext = view;

        }
    }
}
