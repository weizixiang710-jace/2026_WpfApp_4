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

namespace _2026_WpfApp_4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // 請確保有下面這一段！
        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            MyDocumentViewer myDocumentViewer = new MyDocumentViewer();
            myDocumentViewer.Show();
        }
    }
}