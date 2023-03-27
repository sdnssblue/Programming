﻿using System.Windows;
using View.ViewModel;

namespace Contacts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainVM mainVM = new MainVM();
            DataContext = mainVM;
        }
    }
}
