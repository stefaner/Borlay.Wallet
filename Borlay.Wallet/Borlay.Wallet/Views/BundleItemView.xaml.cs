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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Borlay.Wallet.Views
{
    /// <summary>
    /// Interaction logic for BundleItemView.xaml
    /// </summary>
    public partial class BundleItemView : UserControl
    {
        public BundleItemView()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty IsConfirmedViewProperty =
    DependencyProperty.Register(
    "IsConfirmedView", typeof(bool), typeof(BundleItemView));

        public bool IsConfirmedView
        {
            get { return (bool)GetValue(IsConfirmedViewProperty); }
            set { SetValue(IsConfirmedViewProperty, value); }
        }
    }
}
