using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cboInsurance.ItemsSource = new List<string>() { "SVA", "WGKK", "NÖGKK", "BVA", "BGGK", "SGGK", "PVA" };
            cboInsurance.SelectedIndex = 0;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // csv FileFormat: ln;fn;age;ssn;Insurance\r\n
            string result = String.Format("{0};{1};{2};{3};{4}\r\n",
                tboNachname.Text, tboVorname.Text, tboAlter.Text, tboSVNR.Text, cboInsurance.Text);
            File.AppendAllText("output.csv", result);
            ///File.ReadAllLines("output.csv");
            
        }

        
    }
}
