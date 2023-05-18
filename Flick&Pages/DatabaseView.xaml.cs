using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data;
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

        List<Show> showData = new List<Show>();
        List<Movie> movieData = new List<Movie>();
        List<Book> bookData = new List<Book>();

        KeyWords key;

        public DatabaseView(KeyWords keyWord)
        {
            InitializeComponent();

            DatabaseLoad(keyWord);
            key = keyWord;
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

        private void DatabaseLoad(KeyWords key)   //  LOADING FROM DATABASE + BACKGROUND
        {
            switch (key)
            {
                case KeyWords.shows:
                    using (MyDatabaseContent content = new MyDatabaseContent())     // loading  showsdata
                    {
                        showData = content.Shows.ToList();
                        dataShowsTable.ItemsSource = showData;
                        dataShowsTable.VerticalContentAlignment = VerticalAlignment.Center;
                        dataShowsTable.Visibility = Visibility.Visible;
                    }
                    backgroundImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/showsDataView.png"));
                    break;

                case KeyWords.movies:
                    using (MyDatabaseContent content = new MyDatabaseContent())     // loading movies data
                    {
                        movieData = content.Movies.ToList();
                        dataMoviesTable.ItemsSource = movieData;
                        dataMoviesTable.VerticalContentAlignment = VerticalAlignment.Center;
                        dataMoviesTable.Visibility = Visibility.Visible;
                    }
                    backgroundImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/moviesDataView.png"));
                    break;

                case KeyWords.books:
                    using (MyDatabaseContent content = new MyDatabaseContent())     // loading books data
                    {
                        bookData = content.Books.ToList();
                        dataBooksTable.ItemsSource = bookData;
                        dataBooksTable.VerticalContentAlignment = VerticalAlignment.Center;
                        dataBooksTable.Visibility = Visibility.Visible;
                    }
                    backgroundImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/booksDataView.png"));
                    break;
            }
        }

        // CLOSE button
        private void CloseClick(object sender, MouseButtonEventArgs e)
        {
            dataShowsTable.Visibility = Visibility.Hidden;
            dataMoviesTable.Visibility = Visibility.Hidden;
            dataBooksTable.Visibility = Visibility.Hidden;
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
            DeleteItem();
        }
        private void DeleteButtonOn(object sender, MouseEventArgs e)
        {
            deleteButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/deleteButtonOn.png"));
        }
        private void DeleteButtonOff(object sender, MouseEventArgs e)
        {
            deleteButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/deleteButton.png"));
        }

        //Delete item from database
        private void DeleteItem() 
        {
            using (MyDatabaseContent content = new MyDatabaseContent())
            {
                Show selectedShow = dataShowsTable.SelectedItem as Show;
                Movie selectedMovie = dataMoviesTable.SelectedItem as Movie;
                Book selectedBook = dataBooksTable.SelectedItem as Book;

                if (selectedShow != null)
                {
                    Show item = content.Shows.Single(x => x.Id == selectedShow.Id);

                    content.Remove(item);
                    content.SaveChanges();
                    DatabaseLoad(key);
                }

                if (selectedMovie != null)
                {
                    Movie item = content.Movies.Single(x => x.Id == selectedMovie.Id);

                    content.Remove(item);
                    content.SaveChanges();
                    DatabaseLoad(key);
                }

                if (selectedBook != null)
                {
                    Book item = content.Books.Single(x => x.Id == selectedBook.Id);

                    content.Remove(item);
                    content.SaveChanges();
                    DatabaseLoad(key);
                }
            }
        }
    }
}
