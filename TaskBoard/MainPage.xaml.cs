using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Windows;
using TaskBoard.Data;
using TaskBoard.Models;
using TaskBoard.ViewModels;

namespace TaskBoard
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            DataContext = new MainViewModel(DesignTimeStories.Stories());
        }
    }
}
