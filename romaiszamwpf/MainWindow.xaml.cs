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

namespace romaiszamwpf
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

        string iranyos = "jobb"; 
        private void irany_Click(object sender, RoutedEventArgs e)
        {
           if (iranyos == "jobb")
            {
                iranyos = "bal";
                irany.Content = "<---";
            }
            else
            {
                iranyos = "jobb";
                irany.Content = "--->";
            }
            
        }
        
        List<string> romanSzamok = new List<string>()
        {
            "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X",
        };
        private void atvaltbutton_Click(object sender, RoutedEventArgs e)
        {
            if (iranyos == "jobb")
            {
                string romanSzam = romaitext.Text.ToUpper();
                int index = romanSzamok.IndexOf(romanSzam);
                if (index != -1)
                {
                    arabtext.Text = (index + 1).ToString();
                }
                
            }
            else
            {
                if (int.TryParse(arabtext.Text, out int szam) && szam >= 1 && szam <= 10)
                {
                    romaitext.Text = romanSzamok[szam - 1];
                }
 
            }
        }

        string fasz = "nincs";
        private void kaomoji_Click(object sender, RoutedEventArgs e)
        {
            if (fasz == "nincs")
            {
                fasz = "van";
                kaomoji.Content = "(⌐■_■)";
            }
            else
            {
                fasz = "nincs";
                kaomoji.Content = "( •_•)>⌐■-■";
            }
        }
    }
}
