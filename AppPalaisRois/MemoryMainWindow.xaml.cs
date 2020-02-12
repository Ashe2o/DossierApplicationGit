﻿using AppPalaisRois.ViewModel;
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
            // Label Facile
            labelEasy.Content = ConfigurationManager.AppSettings["valeurNomJeuFacile"];
            // Bouton Moyen Icône
            ChoixMemory.Children.Add(new BoutonBarreMenu(new RoutedEventHandler(BoutonJeu2_click), ConfigurationManager.AppSettings["cheminIconeJeuMoyen"]).getButton());
            // Label Moyen
            labelMedium.Content = ConfigurationManager.AppSettings["valeurNomJeuMoyen"];
            // Bouton Difficile Icône
            ChoixMemory.Children.Add(new BoutonBarreMenu(new RoutedEventHandler(BoutonJeu3_click), ConfigurationManager.AppSettings["cheminIconeJeuDifficile"]).getButton());
            // Label Difficile
            labelHard.Content = ConfigurationManager.AppSettings["valeurNomJeuDifficile"];

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
        }

        #endregion Choix de la difficulté

        #region Private Methods

        /// <summary>
        /// Clic sur quitter
        /// </summary>
        private void BoutonQuit_click(object sender, RoutedEventArgs e)
        {
            if (canClose)
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