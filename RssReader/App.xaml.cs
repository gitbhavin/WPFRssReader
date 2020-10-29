using RssReader.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RssReader
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            DependencyInjector.Register<IHelper, Helper>();

            MainWindow = DependencyInjector.Retrive<MainWindow>();

            MainWindow.Show();
        }
    }
}
