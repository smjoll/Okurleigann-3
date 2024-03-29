﻿using System;
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
    /// Interaction logic for ChangeTenantWindow.xaml
    /// </summary>
    public partial class ChangeTenantWindow : Window
    {

        Tenant temp;

        public ChangeTenantWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            temp = new Tenant();
            temp.FirstName = SharedContext.selectedTenant.FirstName;
            temp.Lastname = SharedContext.selectedTenant.Lastname;
            temp.DateOfBirth = SharedContext.selectedTenant.DateOfBirth;

            this.DataContext = temp;
        }
    }
}

