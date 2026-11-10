using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Filmek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public class Filmadatok
    {
        public string Cím { get; set; }
        public string Műfaj {  get; set; }
        public int Hossz { get; set; }
        public double Értékelés { get; set; }

        public Filmadatok(string Cím, string Műfaj, int Hossz, double Értékelés)
        {
            this.Cím=Cím;
            this.Műfaj=Műfaj;
            this.Hossz=Hossz;
            this.Értékelés=Értékelés;
        }

    }
    
    public partial class MainWindow : Window
    {
        List<Filmadatok> filmek = new List<Filmadatok>();
        public MainWindow()
        {
            InitializeComponent();
            filmek = new List<Filmadatok>()
            {
            new Filmadatok("Csillagok háborúja", "sci-fi", 121, 8.6),
            new Filmadatok("Titanic", "dráma", 195, 7.8),
            new Filmadatok("A Gyűrűk Ura", "fantasy", 201, 8.8),
            new Filmadatok("Mátrix", "sci-fi", 136, 8.7),
            new Filmadatok("Shrek", "animáció", 90, 7.9)
            };
        }

        private void betoltes(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = filmek;
            datagrid.Items.Refresh();
        }
    }
}