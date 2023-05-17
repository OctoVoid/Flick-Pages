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
    /// Interaction logic for AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        ImageBrush backgroundBook = new ImageBrush();


        public AddBook()
        {
            InitializeComponent();

            backgroundBook.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/bookBackground.png"));
            backgroundAddBook.Background = backgroundBook;

            closeButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/closeButton.png"));
            saveButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/saveButton.png"));
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

        // SAVE button
        private void saveButtonClick(object sender, MouseButtonEventArgs e)
        {
            using (MyDatabaseContent content = new MyDatabaseContent())    
            {
                var title = titleBox.Text;
                var author = authorBox.Text;
                var genre = genreBox.Text;
                var language = languageBox.Text;

                var pages = 0;
                try { pages = Convert.ToInt32(pagesBox.Text); }
                catch (Exception) { pages = 0; }

                var year = 0;
                try { year = Convert.ToInt32(yearBox.Text); }
                catch (Exception) { year = 0; }

                var rating = 0;
                try { rating = Convert.ToInt32(ratingBox.Text); }
                catch (Exception){}

                if (title != null && author != null && rating != 0)
                {
                    content.Books.Add(new Book() { Title = title, Author = author, Genre = genre, Year = year, Pages = pages, Language = language, Rating = rating });
                    content.SaveChanges();

                    titleBox.Clear();
                    authorBox.Clear();
                    genreBox.SelectedItem = null;
                    yearBox.Clear();
                    pagesBox.Clear();
                    languageBox.Clear();
                    ratingBox.SelectedItem = null;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("           ಠ__ಠ" +
                                "\n        Press OK!");

                    MessageBox.Show("You did not fill the requested items *");
                }

            }



        }
        private void saveButtonOn(object sender, MouseEventArgs e)
        {
            saveButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/saveButtonOn.png"));
        }
        private void saveButtonOff(object sender, MouseEventArgs e)
        {
            saveButton.Source = new BitmapImage(new Uri("pack://application:,,,/Images/saveButton.png"));
        }


    }


}
