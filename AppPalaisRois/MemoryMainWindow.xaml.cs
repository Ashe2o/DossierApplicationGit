using AppPalaisRois.ViewModel;
using CommonSurface.Other;
using System;
using System.Configuration;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace AppPalaisRois
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MemoryMainWindow : Window
    {
        /* EFFECTS RESOURCE DICTIONARY */

        #region Private Fields

        private bool canClose = true;
        private ResourceDictionary myresourcedictionary;
        private Storyboard sbHide;
        private string CheminFondEcran = ConfigurationManager.AppSettings["CheminFondEcranApplication"];
        private string CheminBoutonReturn = ConfigurationManager.AppSettings["CheminBoutonReturn"];

        #endregion Private Fields

        #region Public Constructors

        public MemoryMainWindow()
        {
            InitializeComponent();

            this.DataContext = new MemoryViewModel();
            myresourcedictionary = new ResourceDictionary();

            #region Récupération image de fond

            // Récupération du fond d'ecran
            imageBackground.Source = ResourceAccessor.loadImage(CheminFondEcran);

            // Récupération du retour
            returnMemory.Source = ResourceAccessor.loadImage(CheminBoutonReturn);

            // Récupération du sablier
            sablier.Source = ResourceAccessor.loadImage("/CommonSurface;component/Resources/Sablier.png");

            #endregion Récupération image de fond

            #region Récupération des icones de difficultés

            // Ajout des jeux dans la liste des choix 
            // Bouton Facile Icône
            ChoixMemory.Children.Add(new BoutonBarreMenu(new RoutedEventHandler(BoutonJeu1_click), ConfigurationManager.AppSettings["cheminIconeJeuFacile"]).getButton());
            // Bouton Moyen Icône
            ChoixMemory.Children.Add(new BoutonBarreMenu(new RoutedEventHandler(BoutonJeu2_click), ConfigurationManager.AppSettings["cheminIconeJeuMoyen"]).getButton());
            // Bouton Difficile Icône
            ChoixMemory.Children.Add(new BoutonBarreMenu(new RoutedEventHandler(BoutonJeu3_click), ConfigurationManager.AppSettings["cheminIconeJeuDifficile"]).getButton());

            switch (MainWindow.selectedLanguage){
                case "French":
                    // Label Facile FR
                    labelEasy.Content = ConfigurationManager.AppSettings["valeurNomJeuFacileFR"];
                    // Label Moyen FR
                    labelMedium.Content = ConfigurationManager.AppSettings["valeurNomJeuMoyenFR"];
                    // Label Difficile FR
                    labelHard.Content = ConfigurationManager.AppSettings["valeurNomJeuDifficileFR"];
                    break;
                case "Catalan":
                    // Label Facile CAT
                    labelEasy.Content = ConfigurationManager.AppSettings["valeurNomJeuFacileCAT"];
                    // Label Moyen CAT
                    labelMedium.Content = ConfigurationManager.AppSettings["valeurNomJeuMoyenCAT"];
                    // Label Difficile CAT
                    labelHard.Content = ConfigurationManager.AppSettings["valeurNomJeuDifficileCAT"];
                    break;
                case "English":
                    // Label Facile EN
                    labelEasy.Content = ConfigurationManager.AppSettings["valeurNomJeuFacileEN"];
                    // Label Moyen EN
                    labelMedium.Content = ConfigurationManager.AppSettings["valeurNomJeuMoyenEN"];
                    // Label Difficile EN
                    labelHard.Content = ConfigurationManager.AppSettings["valeurNomJeuDifficileEN"];
                    break;
                case "Spanish":
                    // Label Facile ES
                    labelEasy.Content = ConfigurationManager.AppSettings["valeurNomJeuFacileES"];
                    // Label Moyen ES
                    labelMedium.Content = ConfigurationManager.AppSettings["valeurNomJeuMoyenES"];
                    // Label Difficile ES
                    labelHard.Content = ConfigurationManager.AppSettings["valeurNomJeuDifficileES"];
                    break;
                case "German":
                    // Label Facile DE
                    labelEasy.Content = ConfigurationManager.AppSettings["valeurNomJeuFacileDE"];
                    // Label Moyen DE
                    labelMedium.Content = ConfigurationManager.AppSettings["valeurNomJeuMoyenDE"];
                    // Label Difficile DE
                    labelHard.Content = ConfigurationManager.AppSettings["valeurNomJeuDifficileDE"];
                    break;
            }
            
            
            #endregion Récupération des icones de difficultés

            /* EFFECTS RESOURCE DICTIONARY */
            myresourcedictionary = new ResourceDictionary();
            myresourcedictionary.Source = new Uri("/CommonSurface;component/XAML/Effects.xaml", UriKind.RelativeOrAbsolute);
            sbHide = myresourcedictionary["hideAnimSec"] as Storyboard;
        }

        #endregion Public Constructors

        #region Private Destructors

        ~MemoryMainWindow()
        {
            sbHide = null;
        }

        #endregion Private Destructors

        #region Choix de la difficulté

        /// <summary>
        /// Clic sur le jeu 1
        /// </summary>
        private void BoutonJeu1_click(object sender, RoutedEventArgs e)
        {
            labelEasy.Visibility = Visibility.Collapsed;
            labelMedium.Visibility = Visibility.Collapsed;
            labelHard.Visibility = Visibility.Collapsed;
            ((MemoryViewModel)DataContext).LoadGame("Easy");
            ((MemoryViewModel)DataContext).SelectedGame = 1;
        }

        /// <summary>
        /// Clic sur le jeu 2
        /// </summary>
        private void BoutonJeu2_click(object sender, RoutedEventArgs e)
        {
            labelEasy.Visibility = Visibility.Collapsed;
            labelMedium.Visibility = Visibility.Collapsed;
            labelHard.Visibility = Visibility.Collapsed;
            ((MemoryViewModel)DataContext).LoadGame("Medium");
            ((MemoryViewModel)DataContext).SelectedGame = 2;
        }

        /// <summary>
        /// Clic sur le jeu 3
        /// </summary>
        private void BoutonJeu3_click(object sender, RoutedEventArgs e)
        {
            labelEasy.Visibility = Visibility.Collapsed;
            labelMedium.Visibility = Visibility.Collapsed;
            labelHard.Visibility = Visibility.Collapsed;
            ((MemoryViewModel)DataContext).LoadGame("Hard");
            ((MemoryViewModel)DataContext).SelectedGame = 3;
        }

        #endregion Choix de la difficulté

        #region Private Methods

        /// <summary>
        /// Clic sur quitter
        /// </summary>
        private void BoutonQuit_click(object sender, RoutedEventArgs e)
        {
            if (((MemoryViewModel)DataContext).SelectedGame != 0)
            {
                // Garbage Collector
                GC.Collect();
                GC.WaitForFullGCComplete();

                //Effet de partir
                Storyboard.SetTarget(sbHide, canvas);
                sbHide.Completed += (s, t) =>
                {
                    //Fermeture et ouverture des fenetres
                    MemoryMainWindow fenetre = new MemoryMainWindow();
                    fenetre.Show();
                    this.Close();
                };
                sbHide.Begin();

            }
            else if (canClose)
            {
                canClose = false;

                //Effet de fermeture
                Storyboard.SetTarget(sbHide, canvas);
                sbHide.Completed += (s, t) =>
                {
                    // Clear
                    myresourcedictionary.Clear();
                    myresourcedictionary = null;

                    // Garbage Collector
                    GC.Collect();
                    GC.WaitForFullGCComplete();

                    //Fermeture et ouverture des fenetres
                    MainWindow fenetre = new MainWindow();
                    fenetre.Show();
                    ((MemoryViewModel)DataContext).quit();
                    DataContext = null;
                    this.Close();
                };
                sbHide.Begin();
            }
        }

        /// <summary>
        /// Clic sur choix du jeu
        /// </summary>
        private void ChoixMemory_click(object sender, RoutedEventArgs e)
        {
            ((MemoryViewModel)DataContext).Choice();
        }

        /// <summary>
        /// Clic sur une carte image
        /// </summary>
        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ((MemoryViewModel)DataContext).FlipCard((PlayableCard)((Image)sender).DataContext);
        }

        /// <summary>
        /// Touche une carte image
        /// </summary>
        private void Image_TouchUp(object sender, TouchEventArgs e)
        {
            ((MemoryViewModel)DataContext).FlipCard((PlayableCard)((Image)sender).DataContext);
        }

        #endregion Private Methods
    }
}