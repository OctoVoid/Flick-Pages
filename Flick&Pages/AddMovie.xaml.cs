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
    /// Interaction logic for AddMovie.xaml
    /// </summary>
    public partial class AddMovie : Window
    {
        ImageBrush backgroundMovie = new ImageBrush();

        public AddMovie()
        {
            InitializeComponent();

            backgroundMovie.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/movieBackground.png"));
            backgroundAddMovie.Background = backgroundMovie;
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


    }
}
