using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using ScreenCaptureProtector;

namespace DisablingScreenCapture
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        [DllImport("user32.dll")]
        public static extern uint SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);

        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            IntPtr mainWindowHandle = new WindowInteropHelper(this).Handle;

            PreventScreenCapture.ProtectScreen(mainWindowHandle);
        }
    }
}
