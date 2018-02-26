using System.Linq;
using MahApps.Metro;

namespace MyMetroWindowThreadThemeTest
{
    public partial class SubWindow
    {
        public SubWindow()
        {
            InitializeComponent();
            ThemeManager.ChangeAppStyle(this,
                ThemeManager.Accents.First(x => x.Name.Equals("Red")),
                ThemeManager.GetAppTheme("BaseLight"));
        }
    }
}
