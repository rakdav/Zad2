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

namespace Zad2
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

        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {
            Employ employ = new Employ(FirstNameText.Text,VocationText.Text,double.Parse(OkladText.Text));
            employ.AddOklad();
            Result.Text = employ.Print();
        }

        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            Employ employ = new Employ(FirstNameText.Text,VocationText.Text,double.Parse(OkladText.Text));
            employ.ToIngener();
            Result.Text = employ.Print();
        }

        private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
        {
            Employ employ = new Employs(FirstNameText.Text, VocationText.Text, double.Parse(OkladText.Text),int.Parse(ScaleText.Text));
            employ.AddOklad();
            Result.Text = employ.Print();
        }
    }
}