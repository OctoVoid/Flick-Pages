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

namespace Flick_Pages
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ImageBrush backgroundImage = new ImageBrush();
       


        public MainWindow()
        {
            InitializeComponent();

            backgroundImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/background.png"));
            MainBackground.Background = backgroundImage;
            MainBackground.Background.Opacity = 0.4;

         // BUTTONS
            appName.Source = new BitmapImage(new Uri("pack://application:,,,/Images/name_main.png"));
            showsButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/shows_main.png"));
            moviesButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/movies_main.png"));
            booksButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/books_main.png"));

         // buttons
            showsDat.Source = new BitmapImage( new Uri("pack://application:,,,/Images/shows_icon.png"));
            moviesDat.Source = new BitmapImage(new Uri("pack://application:,,,/Images/movies_icon.png"));
            booksDat.Source = new BitmapImage(new Uri("pack://application:,,,/Images/books_icon.png"));
        }

        private void dragWindow(object sender, MouseButtonEventArgs e)
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

        private void quitButtonClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        // SHOWS
        private void showsButtonOn(object sender, MouseEventArgs e)
        {
            showsButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/shows_main_hover.png"));
        }
        private void showsButtonOff(object sender, MouseEventArgs e)
        {
            showsButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/shows_main.png"));
        }

        // MOVIES
        private void moviesButtonOn(object sender, MouseEventArgs e)
        {
            moviesButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/movies_main_hover.png"));
        }
        private void moviesButtonOff(object sender, MouseEventArgs e)
        {
            moviesButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/movies_main.png"));
        }

        // BOOKS
        private void booksButtonOn(object sender, MouseEventArgs e)
        {
            booksButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/books_main_hover.png"));
        }
        private void booksButtonOff(object sender, MouseEventArgs e)
        {
            booksButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/books_main.png"));
        }

        // shows
        private void showsDatOn(object sender, MouseEventArgs e)
        {
            showsDat.Source = new BitmapImage(new Uri("pack://application:,,,/Images/shows_iconOn.png"));
        }
        private void showsDatOff(object sender, MouseEventArgs e)
        {
            showsDat.Source = new BitmapImage(new Uri("pack://application:,,,/Images/shows_icon.png"));
        }

        // movies
        private void moviesDatOn(object sender, MouseEventArgs e)
        {
            moviesDat.Source = new BitmapImage(new Uri("pack://application:,,,/Images/movies_iconOn.png"));
        }
        private void moviesDatOff(object sender, MouseEventArgs e)
        {
            moviesDat.Source = new BitmapImage(new Uri("pack://application:,,,/Images/movies_icon.png"));
        }

        // books
        private void booksDatOn(object sender, MouseEventArgs e)
        {
            booksDat.Source = new BitmapImage(new Uri("pack://application:,,,/Images/books_iconOn.png"));
        }
        private void booksDatOff(object sender, MouseEventArgs e)
        {
            booksDat.Source = new BitmapImage(new Uri("pack://application:,,,/Images/books_icon.png"));
        }

        
    }
}
