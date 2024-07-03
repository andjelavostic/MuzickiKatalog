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

namespace MuzickiKatalog.Menus.ContentViews.EditorMenus
{
    /// <summary>
    /// Interaction logic for AlbumInput.xaml
    /// </summary>
    public partial class AlbumInput : Window
    {
        private string editorId;
        public AlbumInput(string editorId)
        {
            InitializeComponent();
            this.editorId = editorId;
        }
    }
}
