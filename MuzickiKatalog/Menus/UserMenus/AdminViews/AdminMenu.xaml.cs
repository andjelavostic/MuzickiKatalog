﻿using MuzickiKatalog.Menus.ContentViews;
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
using System.Windows.Shapes;

namespace MuzickiKatalog
{
    /// <summary>
    /// Interaction logic for AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {
        private string adminId;
        public AdminMenu(string adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
        }

        private void addTrackButton_Click(object sender, RoutedEventArgs e)
        {
            TrackEntry track = new TrackEntry(adminId);
            track.Show();
        }
    }
}
