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
using System.Windows.Shapes;

namespace Flick_Pages
{
    /// <summary>
    /// Interaction logic for DatabaseView.xaml
    /// </summary>
    public partial class DatabaseView : Window
    {
        ImageBrush backgroundImage = new ImageBrush();


        public DatabaseView(KeyWords keyWord)
        {
            InitializeComponent();

            DatabaseLoad(keyWord);
            DatabaseViewBackground.Background = backgroundImage;
            DatabaseViewBackground.Background.Opacity = 0.4;

            closeButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/closeButton.png"));
            exportButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/exportButton.png"));
            deleteButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/deleteButton.png"));
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void DatabaseLoad(KeyWords key)   //  LOAD DATABASE INTO DATAGRID + BACKGROUND
        {
            switch (key)
            {
                case KeyWords.shows:      
                    // (CODE FOR DATABASE LOAD)
                    backgroundImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/showsDataView.png"));
                    break;

                case KeyWords.movies:     
                    // (CODE FOR DATABASE LOAD)
                    backgroundImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/moviesDataView.png"));
                    break;

                case KeyWords.books:      
                    // (CODE FOR DATABASE LOAD)
                    backgroundImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/booksDataView.png"));
                    break;
            }
        }

    // CLOSE button
        private void CloseClick(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        private void CloseButtonOn(object sender, MouseEventArgs e)
        {
            closeButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/closeButtonOn.png"));
        }
        private void CloseButtonOff(object sender, MouseEventArgs e)
        {
            closeButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/closeButton.png"));
        }

    // EXPORT button 
        private void ExportClick(object sender, MouseButtonEventArgs e)  // EXPORT - Export to .doc
        {

        }
        private void ExportButtonOn(object sender, MouseEventArgs e)
        {
            exportButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/exportButtonOn.png"));
        }

        private void ExportButtonOff(object sender, MouseEventArgs e)
        {
            exportButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/exportButton.png"));
        }

    // DELETE button
        private void DeleteClick(object sender, MouseButtonEventArgs e)
        {

        }
        private void DeleteButtonOn(object sender, MouseEventArgs e)
        {
            deleteButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/deleteButtonOn.png"));
        }
        private void DeleteButtonOff(object sender, MouseEventArgs e)
        {
            deleteButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/deleteButton.png"));
        }

    }
}
