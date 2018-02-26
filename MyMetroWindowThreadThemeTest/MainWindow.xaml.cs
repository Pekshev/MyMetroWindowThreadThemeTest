using System.Linq;
using System.Threading;
using System.Windows;
using MahApps.Metro;

namespace MyMetroWindowThreadThemeTest
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ThemeManager.ChangeAppStyle(this,
                ThemeManager.Accents.First(x => x.Name.Equals("Red")),
                ThemeManager.GetAppTheme("BaseLight"));
        }

        private void BtOpenNewWindow_OnClick(object sender, RoutedEventArgs e)
        {
            Thread subWindowThread = new Thread(() =>
            {
                SubWindow subWindow = new SubWindow();
                subWindow.ShowDialog();
            });
            subWindowThread.SetApartmentState(ApartmentState.STA);
            subWindowThread.IsBackground = true;
            subWindowThread.Start();
        }
    }
}
