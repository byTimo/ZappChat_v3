﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ZappChat_v3.Annotations;
using ZappChat_v3.Controls;
using ZappChat_v3.Core.ChatElements;
using ZappChat_v3.Core.Managers;

namespace ZappChat_v3.Windows
{
    /// <summary>
    /// Interaction logic for ChatWindow.xaml
    /// </summary>
    public partial class ChatWindow : Window, INotifyPropertyChanged
    {
        private readonly ChatWindowModel _model;
        public ChatWindow()
        {
            InitializeComponent();
            _model = new ChatWindowModel();
            DataContext = _model;
        }

        private void AppShutdown(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void StatusButton_Checked(object sender, RoutedEventArgs e)
        {
            FullBlockator.Visibility = Visibility.Visible;
            StatusMenu.Visibility = Visibility.Visible;
        }

        private void StatusButton_Unchecked(object sender, RoutedEventArgs e)
        {
            FullBlockator.Visibility = Visibility.Collapsed;
            StatusMenu.Visibility = Visibility.Collapsed;
        }
    }
}
