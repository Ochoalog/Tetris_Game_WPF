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
using System.Threading;

namespace Tetris
{
    /// <summary>
    /// Interaction logic for Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {

        
        public Inicio()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Tetris.MainWindow();
            this.Close();
            w.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window s = new ConnectToSQLServerWindow();
            this.Close();
            s.Show();
            
        }



    }
}
