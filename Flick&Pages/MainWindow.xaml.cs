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

        string insertTo = "";
        string savedData = "";

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

        // WINDOWS AddShows - AddMovies - AddBooks
        private void AddWindows()
        {
            switch (insertTo)
            {
                case "shows":
                    AddShow addShow = new AddShow();
                    addShow.Show();
                    break;

                case "movies":
                    AddMovie addMovie = new AddMovie();
                    addMovie.Show();
                    break;

                case "books":
                    AddBook addBook = new AddBook();
                    addBook.Show();
                    break;
            }
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

        private void QuitButtonClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        // SHOWS
        private void ShowsButtonOn(object sender, MouseEventArgs e)
        {
            showsButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/shows_main_hover.png"));
        }
        private void ShowsButtonOff(object sender, MouseEventArgs e)
        {
            showsButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/shows_main.png"));
        }
        private void ShowsButtonClick(object sender, MouseButtonEventArgs e)    // insert show
        {
            insertTo = "shows";
            AddWindows();
        }

        // MOVIES
        private void MoviesButtonOn(object sender, MouseEventArgs e)
        {
            moviesButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/movies_main_hover.png"));
        }
        private void MoviesButtonOff(object sender, MouseEventArgs e)
        {
            moviesButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/movies_main.png"));
        }
        private void MoviesButtonClick(object sender, MouseButtonEventArgs e)   // insert movie
        {
            insertTo = "movies";
            AddWindows();
        }

        // BOOKS
        private void BooksButtonOn(object sender, MouseEventArgs e)
        {
            booksButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/books_main_hover.png"));
        }
        private void BooksButtonOff(object sender, MouseEventArgs e)
        {
            booksButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/books_main.png"));
        }
        private void BooksButtonClick(object sender, MouseButtonEventArgs e)    // insert book
        {
            insertTo = "books";
            AddWindows();
        }

        // shows
        private void ShowsDatOn(object sender, MouseEventArgs e)
        {
            showsDat.Source = new BitmapImage(new Uri("pack://application:,,,/Images/shows_iconOn.png"));
        }
        private void ShowsDatOff(object sender, MouseEventArgs e)
        {
            showsDat.Source = new BitmapImage(new Uri("pack://application:,,,/Images/shows_icon.png"));
        }
        private void ShowsDatClick(object sender, MouseButtonEventArgs e)  // saved shows data
        {
            savedData = "shows";
        }

        // movies
        private void MoviesDatOn(object sender, MouseEventArgs e)
        {
            moviesDat.Source = new BitmapImage(new Uri("pack://application:,,,/Images/movies_iconOn.png"));
        }
        private void MoviesDatOff(object sender, MouseEventArgs e)
        {
            moviesDat.Source = new BitmapImage(new Uri("pack://application:,,,/Images/movies_icon.png"));
        }
        private void MoviesDatClick(object sender, MouseButtonEventArgs e)  // saved movies data
        {
            savedData = "movies";
        }

        // books
        private void BooksDatOn(object sender, MouseEventArgs e)
        {
            booksDat.Source = new BitmapImage(new Uri("pack://application:,,,/Images/books_iconOn.png"));
        }
        private void BooksDatOff(object sender, MouseEventArgs e)
        {
            booksDat.Source = new BitmapImage(new Uri("pack://application:,,,/Images/books_icon.png"));
        }
        private void BooksDatClick(object sender, MouseButtonEventArgs e)   // saved books data
        {
            savedData = "books";
        }


    }
}
