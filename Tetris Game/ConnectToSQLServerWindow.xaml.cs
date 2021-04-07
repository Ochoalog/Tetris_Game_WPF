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

namespace Tetris
{
    /// <summary>
    /// Interaction logic for ConnectToSQLServerWindow.xaml
    /// </summary>
    public partial class ConnectToSQLServerWindow : Window
    {

        SCORETETRIS s = new SCORETETRIS();

        public ConnectToSQLServerWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.ListarScores();
        }

        private void ListarScores()
        {
            using(dbSEQUORBS0023Entities3 dados = new dbSEQUORBS0023Entities3())
            {
                var consulta = dados.SCORETETRIS;
                myDataGrid.ItemsSource = consulta.OrderByDescending(s => s.Score).Take(10).ToList();
            }
        }

        

        private void btnReturnInicio_Click(object sender, RoutedEventArgs e)
        {
            Window inicio = new Inicio();
            this.Close();
            inicio.Show();
        }
    }
}
