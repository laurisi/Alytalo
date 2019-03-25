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

namespace Älytalo3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Lights olohuone = new Lights();
        public Lights makuuhuone = new Lights();
        private int j = 15;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            olohuone.stop();
            Box1.Text = "0 %"; ;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            olohuone.hamara();
            Box1.Text = "33 %";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            olohuone.puoli();
            Box1.Text = "66 %";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            olohuone.bright();
            Box1.Text = "100 %";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            makuuhuone.stop();
            Box2.Text = "0 %";

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            makuuhuone.hamara();
            Box2.Text = "33 %";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            makuuhuone.puoli();
            Box2.Text = "66 %";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            makuuhuone.bright();
            Box2.Text = "100 %";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Box3.Text = "Päällä";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Box3.Text = "";
        }

        private void Aseta_Click(object sender, RoutedEventArgs e)
        {
            Box4.Text = Box5.Text;
            Box5.Text = string.Empty;
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {

            
            {
                j++;
                string s = j.ToString();
                Box5.Text = (s);
            } 

      
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            j--;
            string s = j.ToString();
            Box5.Text = (s);
        }
    }
}

    
    
    

