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
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;

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

        private void browerExcelBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Excel File (*.xlsm)|*.xlsm" + "|Excel File (*.xlsx)|*.xlsx" + "|All Files (*.*)|*.*";


            var result = fileDialog.ShowDialog();

            if (result != null && (bool)result)
            {
                excelTb.Text = fileDialog.FileName;
                excelTb.CaretIndex = fileDialog.FileName.Length;
                excelTb.ScrollToHorizontalOffset(double.MaxValue);
            }
        }

        private void browerCodeBtn_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog folderBrowserDialog = new CommonOpenFileDialog();
            folderBrowserDialog.IsFolderPicker = true;
            CommonFileDialogResult result = folderBrowserDialog.ShowDialog();

            if (result == CommonFileDialogResult.Ok)
            {
                codeTb.Text = folderBrowserDialog.FileName;
                codeTb.CaretIndex = folderBrowserDialog.FileName.Length;
                codeTb.ScrollToHorizontalOffset(double.MaxValue);
            }
        }

    }
}
