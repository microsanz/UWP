using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.System.Profile;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            if (AnalyticsInfo.VersionInfo.DeviceFamily == "Windows.Mobile")
            {
                MySplitView2.CompactPaneLength = 0;
                MenuButton1.Visibility=Visibility.Visible;
                tb1.Visibility=Visibility.Visible;
                // It's a phone
            }else
            {
                MySplitView2.CompactPaneLength = 250;
                MenuButton1.Visibility=Visibility.Collapsed;
                tb1.Visibility=  Visibility.Collapsed;
            }
        }
        void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            if (MySplitView.IsPaneOpen)
            {
                MySplitView2.Margin = new Thickness(150, 0, 0, 0);
            }
            else
            {
                MySplitView2.Margin = new Thickness(50, 0, 0, 0);
            }
            
        }

        private void HamburgerButton2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuButton1_Click(object sender, RoutedEventArgs e)
        {
            if (MySplitView2.CompactPaneLength == 0)
            {
                MySplitView2.CompactPaneLength = 250;
            }else
            {
                MySplitView2.CompactPaneLength = 0;
            }
        }
    }
}
