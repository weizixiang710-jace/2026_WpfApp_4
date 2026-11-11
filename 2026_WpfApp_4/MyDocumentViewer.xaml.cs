using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace _2026_WpfApp_4
{
    /// <summary>
    /// MyDocumentViewer.xaml 的互動邏輯
    /// </summary>
    public partial class MyDocumentViewer : Window
    {
        public MyDocumentViewer()
        {
            InitializeComponent();
        }

        // 開啟新視窗
        public void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MyDocumentViewer newWindow = new MyDocumentViewer();
            newWindow.Show();
        }

        // 開啟檔案
        public void OpenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                // 假設 XAML 中的 RichTextBox 名稱為 MainRichTextBox
                TextRange range = new TextRange(MainRichTextBox.Document.ContentStart, MainRichTextBox.Document.ContentEnd);
                using (FileStream fStream = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    range.Load(fStream, DataFormats.Rtf);
                }
            }
        }

        // 儲存檔案
        public void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == true)
            {
                // 假設 XAML 中的 RichTextBox 名稱為 MainRichTextBox
                TextRange range = new TextRange(MainRichTextBox.Document.ContentStart, MainRichTextBox.Document.ContentEnd);
                using (FileStream fStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    range.Save(fStream, DataFormats.Rtf);
                }
            }
        }
    }
}