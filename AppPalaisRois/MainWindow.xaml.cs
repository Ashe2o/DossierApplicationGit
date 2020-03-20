using CommonSurface.DAO;
using CommonSurface.Model;
using CommonSurface.Other;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace AppPalaisRois
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Private Fields

        private int isopen = 0;
        private ResourceDictionary myresourcedictionary;
        private Storyboard sbHideAnim, sbShowAnim, sbHideAnimSec, sbShowAnimSec;
        private List<Icon> icons;
        // Sélection de la langue Française par défaut.
        public static string selectedLanguage = "French";

        #endregion Private Fields

        #region Public Constructors

        public MainWindow()
        {
            InitializeComponent();

            #region Gestion des icones

            // Récupération de la liste d'icônes du menu principal, boutons langues et "Crédits".
            icons = new List<Icon>(DAOMenu.Instance.Icons)
            {
                DAOMenu.Instance.Credits.Icon,
                DAOMenu.Instance.English.Icon,
                DAOMenu.Instance.French.Icon,
                DAOMenu.Instance.Spanish.Icon,
                DAOMenu.Instance.Catalan.Icon,
                DAOMenu.Instance.German.Icon,
            };

            UpdateOpacityLanguages();

            foreach (Icon icon in icons)
            {
                // Récupération des éléments graphiques de l'icone
                StackPanel panelIcon = this.FindName("position" + icon.Name) as StackPanel;
                Image imageIcon = this.FindName("image" + icon.Name) as Image;
                Label labelIcon = this.FindName("label" + icon.Name) as Label;

                // On change la visibilité de l'icone
                panelIcon.Visibility = icon.Visibility ? Visibility.Visible : Visibility.Collapsed;

                // On ajuste les paramètres
                if (icon.Visibility)
                {
                    // Positionne le panel à la position de la configuration
                    Canvas.SetLeft(panelIcon, Convert.ToDouble(icon.X));
                    Canvas.SetTop(panelIcon, Convert.ToDouble(icon.Y));

                    // Charge l'icone de la configuration
                    imageIcon.Source = ResourceAccessor.loadImage(icon.Source);

                    //Affichage du titre de l'icone en fonction de la langue sélectionné
                    switch (icon.Name)
                    {
                        case "Visite":
                        case "Mediatheque": 
                        case "Region": 
                        case "Memory": 
                        case "Puzzle": 
                        case "Frise": 
                        case "BanqueImages":
                            switch (MainWindow.selectedLanguage)
                            {
                                case "French":
                                    if (icon.TextFR != null) { 
                                        labelIcon.Content = icon.TextFR; 
                                    }
                                    break;
                                case "Catalan":
                                    if (icon.TextCAT != null){
                                        labelIcon.Content = icon.TextCAT;
                                    }else{
                                        labelIcon.Content = icon.TextFR;
                                    }
                                    break;
                                case "English":
                                    if (icon.TextEN != null){
                                        labelIcon.Content = icon.TextEN;
                                    }else{
                                        labelIcon.Content = icon.TextFR;
                                    }
                                    break;
                                case "Spanish":
                                    if (icon.TextES != null){
                                        labelIcon.Content = icon.TextES;
                                    }else{
                                        labelIcon.Content = icon.TextFR;
                                    }
                                    break;
                                case "German":
                                    if (icon.TextDE != null){
                                        labelIcon.Content = icon.TextDE;
                                    }else{
                                        labelIcon.Content = icon.TextFR;
                                    }
                                    break;
                            }
                            break;
                    }
                    
                    if (icon.Color != null)
                    {
                        labelIcon.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(icon.Color));
                    }
                }
            }

            #endregion Gestion des icones

            // Chargement du média des Crédits
            mediaCredits.Source = new Uri(DAOMenu.Instance.Credits.Source);

            // Chargement du Fond d'écran en fonction de la Langue choisis.
            UpdateBackgroundHome();

            #region Dimension du crédit

            // Calcul de la taille du crédit
            var img = ResourceAccessor.loadImage(DAOMenu.Instance.Credits.Source);
            if (img.Width > img.Height)
            {
                sviCredits.MinWidth = ScatterView.MinWidth = 400 * (img.Width / img.Height);
                sviCredits.MinHeight = ScatterView.MinHeight = 400;
            }
            else
            {
                ScatterView.MinWidth = 400;
                ScatterView.MinHeight = 400 * (img.Height / img.Width);
            }

            #endregion Dimension du crédit

            // Récupération du dictionnaire des ressources
            myresourcedictionary = new ResourceDictionary
            {
                Source = new Uri("/CommonSurface;component/XAML/Effects.xaml", UriKind.RelativeOrAbsolute)
            };

            // Récupération des animations
            sbHideAnim = myresourcedictionary["hideAnim"] as Storyboard;
            sbHideAnimSec = myresourcedictionary["hideAnimSec"] as Storyboard;
            sbShowAnim = myresourcedictionary["showAnim"] as Storyboard;
            sbShowAnimSec = myresourcedictionary["showAnimSec"] as Storyboard;

            // Garbage collector
            GC.Collect();
            GC.WaitForFullGCComplete();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// Changement de la visibilité du crédit / copyright
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void CreditsButton_Click(object sender, RoutedEventArgs e)
        {
            int opacity = (ScatterView.Visibility == Visibility.Visible) ? 1 : 0;
            var animation = new DoubleAnimation()
            {
                From = opacity,
                To = 1 - opacity,
                Duration = new Duration(TimeSpan.FromMilliseconds(450)),
            };

            if (opacity > 0)
            {
                animation.Completed += (s, t) =>
                {
                    ScatterView.Visibility = (sviCredits.Opacity > 0) ? Visibility.Visible : Visibility.Collapsed;
                };
            }
            else
            {
                ScatterView.Visibility = Visibility.Visible;
            }

            sviCredits.BeginAnimation(OpacityProperty, animation);
        }

        /// <summary>
        /// Changement de la langue en ANGLAIS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void EnglishButton_Click(object sender, RoutedEventArgs e)
        {
            //Changement du nom de l'icone du menu Principal
            foreach (Icon icon in icons)
            {
                //On vérifie qu'il ne s'agit pas du boutons "Crédits" ou un des boutons de changement de Langues
                if (icon.Name != "Credits" && icon.Name != "English" && icon.Name != "French" && icon.Name != "Spanish" && icon.Name != "Catalan" && icon.Name != "German")
                {
                    // Récupération du label de l'icone
                    Label labelIcon = this.FindName("label" + icon.Name) as Label;
                    if (icon.TextEN != "")
                    {
                        labelIcon.Content = icon.TextEN;
                    }
                    else
                    {
                        labelIcon.Content = icon.TextFR;
                    }
                }
            }
            selectedLanguage = "English";
            UpdateOpacityLanguages();
            UpdateBackgroundHome();
        }

        /// <summary>
        /// Changement de la langue en FRANCAIS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void FrenchButton_Click(object sender, RoutedEventArgs e)
        {
            //Changement du nom de l'icone du menu Principal
            foreach (Icon icon in icons)
            {
                //On vérifie qu'il ne s'agit pas du boutons "Crédits" ou un des boutons de changement de Langues
                if (icon.Name != "Credits" && icon.Name != "English" && icon.Name != "French" && icon.Name != "Spanish" && icon.Name != "Catalan" && icon.Name != "German")
                {
                    // Récupération du label de l'icone
                    Label labelIcon = this.FindName("label" + icon.Name) as Label;
                    if (icon.TextFR != "" && icon.TextFR != null)
                    {
                        labelIcon.Content = icon.TextFR;
                    }
                }
            }
            selectedLanguage = "French";
            UpdateOpacityLanguages();
            UpdateBackgroundHome();
        }

        /// <summary>
        /// Changement de la langue en CATALAN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void CatalanButton_Click(object sender, RoutedEventArgs e)
        {
            //Changement du nom de l'icone du menu Principal
            foreach (Icon icon in icons)
            {
                //On vérifie qu'il ne s'agit pas du boutons "Crédits" ou un des boutons de changement de Langues
                if (icon.Name != "Credits" && icon.Name != "English" && icon.Name != "French" && icon.Name != "Spanish" && icon.Name != "Catalan" && icon.Name != "German")
                {
                    // Récupération du label de l'icone
                    Label labelIcon = this.FindName("label" + icon.Name) as Label;
                    if (icon.TextCAT != "" && icon.TextCAT != null)
                    {
                        labelIcon.Content = icon.TextCAT;
                    }
                    else
                    {
                        labelIcon.Content = icon.TextFR;
                    }
                }
            }
            selectedLanguage = "Catalan";
            UpdateOpacityLanguages();
            UpdateBackgroundHome();
        }

        /// <summary>
        /// Changement de la langue en ESPAGNOL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void SpanishButton_Click(object sender, RoutedEventArgs e)
        {
            //Changement du nom de l'icone du menu Principal
            foreach (Icon icon in icons)
            {
                //On vérifie qu'il ne s'agit pas du boutons "Crédits" ou un des boutons de changement de Langues
                if (icon.Name != "Credits" && icon.Name != "English" && icon.Name != "French" && icon.Name != "Spanish" && icon.Name != "Catalan" && icon.Name != "German")
                {
                    // Récupération du label de l'icone
                    Label labelIcon = this.FindName("label" + icon.Name) as Label;
                    if (icon.TextES != "" && icon.TextES != null)
                    {
                        labelIcon.Content = icon.TextES;
                    }
                    else
                    {
                        labelIcon.Content = icon.TextFR;
                    }
                }
            }
            selectedLanguage = "Spanish";
            UpdateOpacityLanguages();
            UpdateBackgroundHome();
        }
        /// <summary>
        /// Changement de la langue en ALLEMAND
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void GermanButton_Click(object sender, MouseButtonEventArgs e)
        {
            //Changement du nom de l'icone du menu Principal
            foreach (Icon icon in icons)
            {
                //On vérifie qu'il ne s'agit pas du boutons "Crédits" ou un des boutons de changement de Langues
                if (icon.Name != "Credits" && icon.Name != "English" && icon.Name != "French" && icon.Name != "Spanish" && icon.Name != "Catalan" && icon.Name != "German")
                {
                    // Récupération du label de l'icone
                    Label labelIcon = this.FindName("label" + icon.Name) as Label;
                    if (icon.TextDE != "" && icon.TextDE != null)
                    {
                        labelIcon.Content = icon.TextDE;
                    }
                    else
                    {
                        labelIcon.Content = icon.TextFR;
                    }
                }
            }
            selectedLanguage = "German";
            UpdateOpacityLanguages();
            UpdateBackgroundHome();
        }

        /// <summary>
        /// Lancement de l'application d'Expo Virtuelle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void LaunchExpo(object sender, EventArgs e)
        {
            // Garbage Collector
            GC.Collect();
            GC.WaitForFullGCComplete();

            if (isopen == 0)
            {
                isopen = 1;
                //lancement de l'animation avant de fermer
                Storyboard.SetTarget(sbHideAnimSec, canvas);
                sbHideAnimSec.Completed += (s, t) =>
                {
                    ExpoWindow fenetre = new ExpoWindow();
                    fenetre.Show();
                    this.Close();
                };
                sbHideAnimSec.Begin();
            }
        }

        /// <summary>
        /// Lancement de l'application de Memory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void LaunchMemory(object sender, EventArgs e)
        {
            // Garbage Collector
            GC.Collect();
            GC.WaitForFullGCComplete();

            if (isopen == 0)
            {
                isopen = 1;
                //lancement de l'animation avant de fermer
                Storyboard.SetTarget(sbHideAnimSec, canvas);
                sbHideAnimSec.Completed += (s, t) =>
                {
                    MemoryMainWindow fenetre = new MemoryMainWindow();
                    fenetre.Show();
                    this.Close();
                };
                sbHideAnimSec.Begin();
            }
        }

        /// <summary>
        /// Lancement de l'application de Puzzle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void LaunchPuzzle(object sender, EventArgs e)
        {
            // Garbage Collector
            GC.Collect();
            GC.WaitForFullGCComplete();

            if (isopen == 0)
            {
                isopen = 1;
                //lancement de l'animation avant de fermer
                Storyboard.SetTarget(sbHideAnimSec, canvas);
                sbHideAnimSec.Completed += (s, t) =>
                {
                    PuzzleMainWindow fenetre = new PuzzleMainWindow();
                    fenetre.Show();
                    this.Close();
                };
                sbHideAnimSec.Begin();
            }
        }

        /// <summary>
        /// Lancement de l'application de Cartothèque (Région)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void LaunchRegion(object sender, EventArgs e)
        {
            // Garbage Collector
            GC.Collect();
            GC.WaitForFullGCComplete();

            if (isopen == 0)
            {
                isopen = 1;
                //lancement de l'animation avant de fermer
                Storyboard.SetTarget(sbHideAnimSec, canvas);
                sbHideAnimSec.Completed += (s, t) =>
                {
                    AppRegionMainView fenetre = new AppRegionMainView();
                    fenetre.Show();
                    this.Close();
                };
                sbHideAnimSec.Begin();
            }
        }

        /// <summary>
        /// Lancement de l'application de Frise Historique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void LaunchFrise(object sender, EventArgs e)
        {
            // Garbage Collector
            GC.Collect();
            GC.WaitForFullGCComplete();

            if (isopen == 0)
            {
                isopen = 1;
                //lancement de l'animation avant de fermer
                Storyboard.SetTarget(sbHideAnimSec, canvas);
                sbHideAnimSec.Completed += (s, t) =>
                {
                    AppFriseMainView fenetre = new AppFriseMainView();
                    fenetre.Show();
                    this.Close();
                };
                sbHideAnimSec.Begin();
            }
        }

        /// <summary>
        /// Lancement de l'application de Sgraffito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void LaunchSgraffito(object sender, MouseButtonEventArgs e)
        {
            // Garbage Collector
            GC.Collect();
            GC.WaitForFullGCComplete();

            if (isopen == 0)
            {
                isopen = 1;
                //lancement de l'animation avant de fermer
                Storyboard.SetTarget(sbHideAnimSec, canvas);
                sbHideAnimSec.Completed += (s, t) =>
                {
                    AppSgraffitoMainView fenetre = new AppSgraffitoMainView();
                    fenetre.Show();
                    this.Close();
                };
                sbHideAnimSec.Begin();
            }
        }

        /// <summary>
        /// Lancement de l'application de Banque d'Images (Vidéothèque)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void LaunchBanqueImages(object sender, EventArgs e)
        {
            // Garbage Collector
            GC.Collect();
            GC.WaitForFullGCComplete();

            if (isopen == 0)
            {
                isopen = 1;
                //lancement de l'animation avant de fermer
                Storyboard.SetTarget(sbHideAnimSec, canvas);
                sbHideAnimSec.Completed += (s, t) =>
                {
                    AppBanqueImagesMainView fenetre = new AppBanqueImagesMainView();
                    fenetre.Show();
                    this.Close();
                };
                sbHideAnimSec.Begin();
            }
        }


        /// <summary>
        /// Lancement de l'application de Visite Virtuelle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void LaunchVisite(object sender, EventArgs e)
        {
            // Garbage Collector
            GC.Collect();
            GC.WaitForFullGCComplete();

            if (isopen == 0)
            {
                isopen = 1;
                //lancement de l'animation avant de fermer
                Storyboard.SetTarget(sbHideAnimSec, canvas);
                sbHideAnimSec.Completed += (s, t) =>
                {
                    VisiteWindow fenetre = new VisiteWindow(sender, e);
                    fenetre.Show();
                    this.Close();
                };
                sbHideAnimSec.Begin();
            }
        }

        /// <summary>
        /// Réduit l'opacité des langues qui ne sont pas sélectionné. Seul la Langue en cours d'utilisation est mis en avant.
        /// </summary>
        private void UpdateOpacityLanguages()
        {
            imageFrench.Opacity = 0.5;
            imageCatalan.Opacity = 0.5;
            imageEnglish.Opacity = 0.5;
            imageSpanish.Opacity = 0.5;
            imageGerman.Opacity = 0.5;

            switch (selectedLanguage)
            {
                case "French":
                    imageFrench.Opacity = 1;
                    break;
                case "Catalan":
                    imageCatalan.Opacity = 1;
                    break;
                case "English":
                    imageEnglish.Opacity = 1;
                    break;
                case "Spanish":
                    imageSpanish.Opacity = 1;
                    break;
                case "German":
                    imageGerman.Opacity = 1;
                    break;
            }
        }
        /// <summary>
        /// Change le Fond d'écran d'accueil en fonction de la Langue choisis. Par défaut, le fond d'écran principal est choisis si il n'y a pas de traduction disponible.
        /// </summary>
        private void UpdateBackgroundHome()
        {
            imageBackground.Source = ResourceAccessor.loadImage(DAOMenu.Instance.Background);
            switch (selectedLanguage)
            {
                case "Catalan":
                    if (File.Exists(DAOMenu.Instance.BackgroundCAT))
                        imageBackground.Source = ResourceAccessor.loadImage(DAOMenu.Instance.BackgroundCAT);
                    break;
                case "English":
                    if (File.Exists(DAOMenu.Instance.BackgroundEN))
                        imageBackground.Source = ResourceAccessor.loadImage(DAOMenu.Instance.BackgroundEN);
                    break;
                case "Spanish":
                    if (File.Exists(DAOMenu.Instance.BackgroundES))
                        imageBackground.Source = ResourceAccessor.loadImage(DAOMenu.Instance.BackgroundES);
                    break;
                case "German":
                    if (File.Exists(DAOMenu.Instance.BackgroundDE))
                        imageBackground.Source = ResourceAccessor.loadImage(DAOMenu.Instance.BackgroundDE);
                    break;
            }
        }

        /// <summary>
        /// Fermeture de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Application.Current.Shutdown();
            }
        }

        #endregion Private Methods
    }
}