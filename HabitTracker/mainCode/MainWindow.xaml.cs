using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ApplicationSettings;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace mainCode
{
    /// <summary>  
    /// An empty window that can be used on its own or navigated to within a Frame.  
    /// </summary>  
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void nvSample_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                App.MainWindowInstance.Content = new SettingsPage();
            }
            else
            {
                // Handle other menu items  
                var invokedItem = args.InvokedItem as string;
                switch (invokedItem)
                {
                    case "Menu Item1":
                        contentFrame.Navigate(typeof(MainWindow));
                        break;
                }
            }
        } 

        //private void myButton_Click(object sender, RoutedEventArgs e)  
        //{  
        //    myButton.Content = "Bong";  
        //}  
    }
}