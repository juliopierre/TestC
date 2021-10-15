using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace cptRebours
{

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application

    {
        Configuration configuration;
        private Fen_Principale fen_Principale;
        Fen_Deporte fen_Deporte;
        private Decompteur decompteur;
        App()
        {
            fen_Principale = new Fen_Principale();
            fen_Principale.Show();
            decompteur = new Decompteur();
            fen_Principale.SetDecompteur(decompteur);
            decompteur.SetDecompteur(fen_Principale);
            fen_Deporte = new Fen_Deporte();
            fen_Deporte.Show();
        }

        
    }
}
