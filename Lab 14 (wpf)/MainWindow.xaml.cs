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

namespace Lab_14__wpf_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                Name = "Asus PC",
                Price = 13000,
                Picture = "Data/1.jpg",
                category = Category.Appliances
            });
            products.Add(new Product()
            {
                Name = "Dinner",
                Price = 3000,
                Picture = "Data/2.jpg",
                category = Category.Food
            });
            lstBox.ItemsSource = products;
        }
    }
}
