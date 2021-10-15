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
using System.Timers;

namespace cptRebours
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Fen_Principale : Window
    {
        private Decompteur decompteur;
        Configuration configuration;
        Fen_Principale fen_Principale;
        Fen_Deporte fen_Deporte;
        public Fen_Principale()
        {
            InitializeComponent();
         
        }

        public void SetDecompteur(Decompteur decompteur)
        {
            this.decompteur = decompteur;
        }

        private void MenuItemConfiguration_Click(object sender, RoutedEventArgs e)
        {
            configuration = new Configuration();
            configuration.Show();
        }
        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
        public void afficher( int donnee)
        {
            
            this.Dispatcher.Invoke(() =>
            {
                this.Label_cptRebours.Content = donnee;
                decompteur.Stopper();
            });

        }


        private void Bouton_Start_Click(object sender, RoutedEventArgs e)
        {
            decompteur.Demarrer();
           

        }

        private void MenuItemEcran_Click(object sender, RoutedEventArgs e)
        {
            fen_Deporte = new Fen_Deporte();
            fen_Deporte.Show();
        }
    }
};