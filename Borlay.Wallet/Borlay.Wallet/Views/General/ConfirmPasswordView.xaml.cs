﻿using Borlay.Wallet.Models.General;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Borlay.Wallet.Views.General
{
    /// <summary>
    /// Interaction logic for ConfirmPasswordView.xaml
    /// </summary>
    public partial class ConfirmPasswordView : UserControl
    {
        public ConfirmPasswordView()
        {
            InitializeComponent();
        }

        private void password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is IHasPassword pass)
                pass.Password = password.SecurePassword;
        }
    }
}
