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
