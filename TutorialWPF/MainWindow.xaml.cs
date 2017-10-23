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

namespace TutorialWPF
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

        private void BtnShowTxt_Click(object sender, RoutedEventArgs e)
        {
            LabelNew.Visibility = Visibility.Visible;
        }

        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            LabelRight.Content = TxtBox.Text;
        }

        private void RBtnRed_Checked(object sender, RoutedEventArgs e)
        {
            BtnShow.Background = Brushes.Red;
        }

        private void RBtnBlue_Checked(object sender, RoutedEventArgs e)
        {
            BtnShow.Background = Brushes.Blue;
        }
    }
}
