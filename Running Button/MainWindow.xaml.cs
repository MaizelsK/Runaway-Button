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

namespace Running_Button
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            int topBottom_Border = 100;
            int leftRight_Border = 150;

            Random random = new Random();

            int left = (int)button.Margin.Left,
                bottom = (int)button.Margin.Bottom;

            int randomWay = random.Next(0, 4);

            switch (randomWay)
            {
                case 0:
                    if (left >= -this.Width + leftRight_Border)
                        left = (int)(button.Margin.Left - button.Width*2);

                    break;

                case 1:
                    if (left <= this.Width - leftRight_Border)
                        left = (int)(button.Margin.Left + button.Width * 2);

                    break;

                case 2:
                    if (bottom >= -this.Height + topBottom_Border)
                        bottom = (int)(button.Margin.Bottom - button.Height * 2);

                    break;


                case 3:
                    if (bottom <= this.Height - topBottom_Border)
                        bottom = (int)(button.Margin.Bottom + button.Height * 2);

                    break;
            }

            button.Margin = new Thickness(left, button.Margin.Top, button.Margin.Right, bottom);
        }

        private void Click_Button(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы победили! :)");
        }
    }
}
