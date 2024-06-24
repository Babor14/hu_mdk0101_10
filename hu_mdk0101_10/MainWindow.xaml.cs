using System.Security.RightsManagement;
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
using System.Linq;

namespace hu_mdk0101_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string InputText { get; set; }
        int[] mas;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            InputText = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17";                             
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mas = Array.ConvertAll(InputText.Split(','), int.Parse);
            var redmas = mas.Select(x => x % 3 == 0 ? mas.Where(y => y % 2 != 0).Sum() : x).ToArray();
            secondmastext.Text=" " + string.Join(", ", redmas);
        }
    }
}