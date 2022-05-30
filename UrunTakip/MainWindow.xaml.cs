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
using System.Data;
using System.Configuration;
using System.Text.RegularExpressions;

namespace UrunTakip
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

        private void RakamGirisi(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }


        private void urun_ekle_Click(object sender, RoutedEventArgs e)
        {
            string metin = urun_adi_txt.Text + " " + urun_no_txt.Text + " " + urun_giris_txt.Text + " " + urun_cikis_txt.Text;
            // urun_listesi.Items.Add(urun_adi_txt.Text + " " + urun_no_txt.Text + " " + urun_giris_txt.Text + " " + urun_cikis_txt.Text);
            urun_listesi.Items.Add(metin);
            urun_adi_txt.Clear();
            urun_no_txt.Clear();
            urun_giris_txt.Clear();
            urun_cikis_txt.Clear();

        }

        private void urun_temizle_Click_1(object sender, RoutedEventArgs e)
        {
            urun_adi_txt.Clear();
            urun_no_txt.Clear();
            urun_giris_txt.Clear();
            urun_cikis_txt.Clear();
        }

        private void urun_sil_Click_1(object sender, RoutedEventArgs e)
        {
            int index = urun_listesi.SelectedIndex;
            if (index != -1)
            {
                urun_listesi.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Seçim yapınız!");
            }
        }

    }
}
