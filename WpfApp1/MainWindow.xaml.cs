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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Componens;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BookListView.ItemsSource = BdConect.bd.Book.ToList();

        }

        private void BookListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BdConect.book = BookListView.SelectedItem as Book;
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = " All Filse |*.*",
            };
            if (openFile.ShowDialog().GetValueOrDefault())
            {
                BitmapFrame.Create(new MemoryStream(File.ReadAllBytes(openFile.FileName)), BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                BdConect.book.Photo = File.ReadAllBytes(openFile.FileName);
            }
            BdConect.bd.SaveChanges();
            BookListView.ItemsSource = BdConect.bd.Book.ToList();

        }
    }
}
