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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
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

        private void ShowBrowser(object sender, RoutedEventArgs e)
        {
            Holder.Content = new EscherGroup.EssentialCP.Client.Internal.Controls.OmniBrowser(URL?.Text ?? "https://www.outlook.com");
        }
        private void HideBrowser(object sender, RoutedEventArgs e)
        {
            var browser = Holder.Content as EscherGroup.EssentialCP.Client.Internal.Controls.OmniBrowser;
            if (browser != null)
            {
                browser.SetToBlank();                
            }
        }

        private void ReplaceControl(object sender, RoutedEventArgs e)
        {
            Holder.Content = new TextBlock { Text = "Wait for browser" };
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
