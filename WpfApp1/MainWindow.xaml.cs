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
using MaterialDesignColors;
using MaterialDesignThemes.Wpf;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PaletteHelper paletteHelper = new PaletteHelper();
            IBaseTheme baseTheme = Theme.Light;
            ITheme theme = Theme.Create(baseTheme, (Color)ColorConverter.ConvertFromString("#FF2196F3"), (Color)ColorConverter.ConvertFromString("#FF03A9F4"));
            theme.PrimaryMid = new ColorPair((Color)ColorConverter.ConvertFromString("#FF2196F3"), Colors.White);
            paletteHelper.SetTheme(theme);
        }
    }
}
