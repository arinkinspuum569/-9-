﻿using System;
using System.Collections;
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

namespace билет_9_экзамен
{
    /// <summary>
    /// Логика взаимодействия для ExitWindow.xaml
    /// </summary>
    public partial class ExitWindow : Window
    {
        public ExitWindow()
        {
            InitializeComponent();
        }
        private void Status_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random(1000);
            var value1 = random.Next(10, 40);
            var value2 = random.Next(50, 100);
            Stats stats = new Stats(value1, value2);
            DbConnector.AddStats(stats);
            SignInWindow signInWindow = new SignInWindow();
            signInWindow.Show();
            this.Hide();
        }
    }
}
