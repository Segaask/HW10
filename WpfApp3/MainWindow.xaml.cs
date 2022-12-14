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
using System.Runtime;

namespace WpfApp3
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


        private void Separately_Click(object sender, RoutedEventArgs e)
        {
            string[] Ntext = txtName.Text.Split(' ');
            
            foreach (string n in Ntext)
            {
                Listtxt.Items.Add(n);
            }
        }

        private void Mix_Click(object sender, RoutedEventArgs e)
        {
            string[] Ntext = txtName.Text.Split(' ');
            Array.Reverse(Ntext);
            var Nmix = "";

            foreach (var n in Ntext)
            {
                Nmix += " " + n;
            }

            Labeltxt.Content = Nmix;
        }
    }
}
