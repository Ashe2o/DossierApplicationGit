using CommonSurface.DAO;
using CommonSurface.Model;
using CommonSurface.Other;
using System;
using System.Collections.Generic;
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
        public static string selectedLanguage = "French";

        #endregion Private Fields

        #region Public Constructors

        public MainWindow()
        {
            InitializeComponent();

            #region Gestion des icones

            icons = new List<Icon>(DAOMenu.Instance.Icons)
            {
                DAOMenu.Instance.Credits.Icon,
                DAOMenu.Instance.English.Icon,
                DAOMenu.Instance.French.Icon,
                DAOMenu.Instance.Spanish.Icon,
                DAOMenu.Instance.Catalan.Icon
            };
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

                    //Affichage du titre de l'icone en fonction de la Langue
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
                                    if (icon.TextFR != null) { labelIcon.Content = icon.TextFR; }
                                    break;
                                case "Catalan":
                                    if (icon.TextCAT != null)
                                    {
                                        labelIcon.Content = icon.TextCAT;
                                    }
                                    else
                                    {
                                        labelIcon.Content = icon.TextFR;
                                    }
                                    break;
                                case "English":
                                    if (icon.TextEN != null)
                                    {
                                        labelIcon.Content = icon.TextEN;
                                    }
                                    else
                                    {
                                        labelIcon.Content = icon.TextFR;
                                    }
                                    break;
                                case "Spanish":
                                    if (icon.TextES != null)
                                    {
                                        labelIcon.Content = icon.TextES;
                                    }
                                    else
                                    {
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

            // Chargement des ressources
            imageBackground.Source = ResourceAccessor.loadImage(DAOMenu.Instance.Background);
            mediaCredits.Source = new Uri(DAOMenu.Instance.Credits.Source);

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
                if (icon.Name != "Credits" && icon.Name != "English" && icon.Name != "French" && icon.Name != "Spanish" && icon.Name != "Catalan")
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
                if (icon.Name != "Credits" && icon.Name != "English" && icon.Name != "French" && icon.Name != "Spanish" && icon.Name != "Catalan")
                {
                    // Récupération du label de l'icone
                    Label labelIcon = this.FindName("label" + icon.Name) as Label;
                    if (icon.TextFR != "")
                    {
                        labelIcon.Content = icon.TextFR;
                    }
                }
            }
            selectedLanguage = "French";
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
                if (icon.Name != "Credits" && icon.Name != "English" && icon.Name != "French" && icon.Name != "Spanish" && icon.Name != "Catalan")
                {
                    // Récupération du label de l'icone
                    Label labelIcon = this.FindName("label" + icon.Name) as Label;
                    if (icon.TextCAT != "")
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
                if (icon.Name != "Credits" && icon.Name != "English" && icon.Name != "French" && icon.Name != "Spanish" && icon.Name != "Catalan")
                {
                    // Récupération du label de l'icone
                    Label labelIcon = this.FindName("label" + icon.Name) as Label;
                    if (icon.TextES != "")
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