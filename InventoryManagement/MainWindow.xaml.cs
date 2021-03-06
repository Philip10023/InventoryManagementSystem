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

namespace InventoryManagement
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

        private void Lot_Details_Btn_Click(object sender, RoutedEventArgs e)
        {
            LotDetails win2 = new LotDetails();
            win2.Show();
            this.Close();
        }

        private void Part_Num_Details_Btn_Click(object sender, RoutedEventArgs e)
        {
            PartNumberDetails win3 = new PartNumberDetails();
            win3.Show();
            this.Close();
        }
    }
}
