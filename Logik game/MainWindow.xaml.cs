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

namespace Logik_game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ellipse0_0_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse ellipse = (Ellipse)sender;

            if (ellipse.Fill == Brushes.LightGray)
            {
                ellipse.Fill = Brushes.Red;
            }
            else if (ellipse.Fill == Brushes.Red)
            {
                ellipse.Fill = Brushes.Green;
            }
            else if (ellipse.Fill == Brushes.Green)
            {
                ellipse.Fill = Brushes.Yellow;
            }
            else if (ellipse.Fill == Brushes.Yellow)
            {
                ellipse.Fill = Brushes.Blue;
            }
            else if (ellipse.Fill == Brushes.Blue)
            {
                ellipse.Fill = Brushes.Purple;
            }
            else if (ellipse.Fill == Brushes.Purple)
            {
                ellipse.Fill = Brushes.Orange;
            }
            else if (ellipse.Fill == Brushes.Orange)
            {
                ellipse.Fill = Brushes.Red;
            }
        }
        private void NastavElipsuEnabled(Ellipse ellipse)
        {
            ellipse.IsEnabled = true;
            ellipse.Fill = Brushes.LightGray;
            ellipse.Stroke = Brushes.Black;
        }


        private void NastavElipsuDisabled(Ellipse ellipse)
        {
            ellipse.IsEnabled = false;
            ellipse.Fill = Brushes.White;
            ellipse.Stroke = Brushes.Black;

        }

        private void NastavVariantu0()
        {
            NastavElipsuDisabled(Ellipse0_0);
            NastavElipsuDisabled(Ellipse0_1);
            NastavElipsuDisabled(Ellipse0_2);
            NastavElipsuDisabled(Ellipse0_3);

            NastavElipsuDisabled(Ellipse1_0);
            NastavElipsuDisabled(Ellipse1_1);
            NastavElipsuDisabled(Ellipse1_2);
            NastavElipsuDisabled(Ellipse1_3);

            NastavElipsuDisabled(Ellipse2_0);
            NastavElipsuDisabled(Ellipse2_1);
            NastavElipsuDisabled(Ellipse2_2);
            NastavElipsuDisabled(Ellipse2_3);

            NastavElipsuDisabled(Ellipse3_0);
            NastavElipsuDisabled(Ellipse3_1);
            NastavElipsuDisabled(Ellipse3_2);
            NastavElipsuDisabled(Ellipse3_3);

            NastavElipsuDisabled(Ellipse4_0);
            NastavElipsuDisabled(Ellipse4_1);
            NastavElipsuDisabled(Ellipse4_2);
            NastavElipsuDisabled(Ellipse4_3);

            NastavElipsuDisabled(Ellipse5_0);
            NastavElipsuDisabled(Ellipse5_1);
            NastavElipsuDisabled(Ellipse5_2);
            NastavElipsuDisabled(Ellipse5_3);

            NastavElipsuDisabled(Ellipse6_0);
            NastavElipsuDisabled(Ellipse6_1);
            NastavElipsuDisabled(Ellipse6_2);
            NastavElipsuDisabled(Ellipse6_3);

            NastavElipsuDisabled(Ellipse7_0);
            NastavElipsuDisabled(Ellipse7_1);
            NastavElipsuDisabled(Ellipse7_2);
            NastavElipsuDisabled(Ellipse7_3);

            NastavElipsuDisabled(Ellipse8_0);
            NastavElipsuDisabled(Ellipse8_1);
            NastavElipsuDisabled(Ellipse8_2);
            NastavElipsuDisabled(Ellipse8_3);
        }

        private void NastavBarvyPC()
        {

        }

        private Brush ZiskejBarvu()
        {
            Random random = new Random();
            int cislo = random.Next(1, 7);
            if (cislo == 1)
            {
                return Brushes.Red;
            }
            else if (cislo== 2)
            {
                return Brushes.Green;
            }
            else if (cislo == 3)
            {
                return Brushes.Yellow;
            }
            else if (cislo == 4)
            {
                return Brushes.Blue;
            }    
            else if (cislo == 5)
            {
                return Brushes.Purple;
            }
            else if (cislo == 6)
            {
                return Brushes.Orange;
                { }
                return Brushes.Red;

            }
        }
    }
}






