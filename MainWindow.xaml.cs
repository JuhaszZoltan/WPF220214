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

namespace WPF220214
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random rnd = new Random();
        static List<Ember> emberek = new List<Ember>();

        public MainWindow()
        {
            InitializeComponent();

            emberek.Add(new Ember() { Id = 1, Nev = "Béla", Szul = new DateTime(2000, 10, 10) });
            emberek.Add(new Ember() { Id = 2, Nev = "Jenő", Szul = new DateTime(2001, 11, 11) });
            emberek.Add(new Ember() { Id = 3, Nev = "Kálmán", Szul = new DateTime(2002, 12, 12) });

            dgAdatok.ItemsSource = emberek;
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hello World!");

            if (!string.IsNullOrWhiteSpace(MyTextBox.Text))
            {
                emberek.Add(new Ember()
                {
                    Id = emberek.Count + 1,
                    Nev = MyTextBox.Text,
                    Szul = new DateTime(1000, 10, 10)
                });

                dgAdatok.Items.Refresh();
            }



            this.Background = new SolidColorBrush()
            {
                Color = Color.FromRgb(
                    (byte)rnd.Next(255),
                    (byte)rnd.Next(255),
                    (byte)rnd.Next(255))
            };
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
