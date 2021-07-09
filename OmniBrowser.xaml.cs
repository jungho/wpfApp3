using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;


namespace EscherGroup.EssentialCP.Client.Internal.Controls
{
    /// <summary>
    /// Interaction logic for OmniBrowser.xaml
    /// </summary>
    public partial class OmniBrowser : UserControl
    {
        private System.Windows.Forms.WebBrowser _browser;

        internal OmniBrowser( string url)
        {
            InitializeComponent();

            _browser = new System.Windows.Forms.WebBrowser
            {
                MaximumSize = new System.Drawing.Size(7700, 7700),
                IsWebBrowserContextMenuEnabled = false,
                ScriptErrorsSuppressed = true,
                WebBrowserShortcutsEnabled = false,
                Url = new UriBuilder(url).Uri
            };

            FormsHost.Child = _browser;          
            Unloaded += OmniBrowser_Unloaded;
        }

        internal void SetToBlank()
        {
            _browser?.Navigate("about:blank");            
        }

        private void OmniBrowser_Unloaded(object sender, RoutedEventArgs e)
        {          
             FormsHost.Dispose();
            _browser?.Dispose();
            _browser = null;
        }     
    }
}
