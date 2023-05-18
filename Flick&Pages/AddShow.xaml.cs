using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
    /// Interaction logic for AddShow.xaml
    /// </summary>
    public partial class AddShow : Window
    {
        ImageBrush backgroundShow = new ImageBrush();

        public AddShow()
        {
            InitializeComponent();

            backgroundShow.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/showBackground.png"));
            backgroundAddShow.Background = backgroundShow;

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
            using (MyDatabaseContent content = new MyDatabaseContent())     //ADD TRY CATCH
            {
                var title = titleBox.Text;
                var genre = genreBox.Text;
                var language = languageBox.Text;

                var season = 0;
                try { season = Convert.ToInt32(yearBox.Text); }
                catch (Exception) { season = 0; }
                 
                var year = 0;
                try { year = Convert.ToInt32(yearBox.Text); }
                catch (Exception) { year = 0; }

                var rating = 0;
                try { rating = Convert.ToInt32(ratingBox.Text); }
                catch (Exception){}

                if (title != null && year != 0 && rating != 0)
                {
                    content.Shows.Add(new Show() { Title = title, Year = year, Genre = genre, Language = language, Season = season, Rating = rating });
                    content.SaveChanges();

                    titleBox.Clear();
                    yearBox.Clear();
                    genreBox.SelectedItem = null;
                    languageBox.Clear();
                    seasonsBox.Clear();
                    ratingBox.SelectedItem = null;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("                ಠ__ಠ" +
                                "\nFill the requested items!");
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
