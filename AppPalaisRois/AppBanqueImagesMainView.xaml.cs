using AppPalaisRois.ViewModel;
using CommonSurface.Model;
using CommonSurface.Other;
using FluidKit.Controls;
using Microsoft.Surface.Presentation.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.Configuration;

namespace AppPalaisRois
{
    public partial class AppBanqueImagesMainView : Window
    {
        #region Private Fields

        private int actualIndex = 0;
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();
        private Dictionary<PlaceHolder, List<ScatterViewItem>> displayedItems;
        private List<ScatterViewItem> itemsGarbage = new List<ScatterViewItem>();
        private ResourceDictionary myresourcedictionary;
        private Storyboard sbFloat, sbDefloat, sbHide;
        private List<object> selectedFramework = new List<object>();
        private List<PlaceHolder> selectedOnes;
        private AppBanqueImagesMainViewModel ViewModel;
        private string CheminBoutonReturn = ConfigurationManager.AppSettings["CheminBoutonReturn"];
        private string CheminFondEcran = ConfigurationManager.AppSettings["CheminFondEcranApplication"];
        #endregion Private Fields

        #region Public Constructors

        public AppBanqueImagesMainView()
        {
            InitializeComponent();

            ViewModel = new AppBanqueImagesMainViewModel();
            this.DataContext = ViewModel;

            displayedItems = new Dictionary<PlaceHolder, List<ScatterViewItem>>();

            //// Récupération de la frise
            imageFond.Source = ResourceAccessor.loadImage(CheminFondEcran);
            returnBanqueImages.Source = ResourceAccessor.loadImage(CheminBoutonReturn);

            ///* ANIM PART*/
            ///* EFFECTS RESOURCE DICTIONARY */
            myresourcedictionary = new ResourceDictionary
            {
                Source = new Uri("/CommonSurface;component/XAML/Effects.xaml", UriKind.RelativeOrAbsolute)
            };
            sbHide = myresourcedictionary["hideAnimSec"] as Storyboard;

            ///* GRAB STORYBOARDS FROM RD */
            sbFloat = myresourcedictionary["animFloat"] as Storyboard;
            sbDefloat = myresourcedictionary["animDefloat"] as Storyboard;

            selectedOnes = new List<PlaceHolder>();
            flowCarte.Layout = new Rolodex();

            List<Map> temp = new List<Map>(ViewModel.Maps);
            temp.Sort((a, b) => (a.ID.CompareTo(b.ID)));
            ViewModel.Maps = new ObservableCollection<Map>(temp);
            string itemssource = "";
            MediaElement mediaFOND = new MediaElement();
            //element a ajouté a la liste qui contient tous les elements
            StackPanel stack = new StackPanel();
            int id = 1;
            foreach (Map map in ViewModel.Maps)
            {
                if (map.Background.Contains(".mov") || map.Background.Contains(".wmv") || map.Background.Contains(".mp4")){
                    mediaFOND.BeginInit();
                    switch (MainWindow.selectedLanguage)
                    {
                        case "French":
                            mediaFOND.Source = new Uri(map.Background, UriKind.RelativeOrAbsolute);
                            break;
                        case "Catalan":
                            if (map.BackgroundCAT != null && map.BackgroundCAT != "")
                            {
                                mediaFOND.Source = new Uri(map.BackgroundCAT, UriKind.RelativeOrAbsolute);
                            }
                            else
                            {
                                mediaFOND.Source = new Uri(map.Background, UriKind.RelativeOrAbsolute);
                            }
                            break;
                        case "English":
                            if (map.BackgroundEN != null && map.BackgroundEN != "")
                            {
                                mediaFOND.Source = new Uri(map.BackgroundEN, UriKind.RelativeOrAbsolute);
                            }
                            else
                            {
                                mediaFOND.Source = new Uri(map.Background, UriKind.RelativeOrAbsolute);
                            }
                            break;
                        case "Spanish":
                            if (map.BackgroundES != null && map.BackgroundES != "")
                            {
                                mediaFOND.Source = new Uri(map.BackgroundES, UriKind.RelativeOrAbsolute);
                            }
                            else
                            {
                                mediaFOND.Source = new Uri(map.Background, UriKind.RelativeOrAbsolute);
                            }
                            break;
                        case "German":
                            if (map.BackgroundDE != null && map.BackgroundDE != "")
                            {
                                mediaFOND.Source = new Uri(map.BackgroundDE, UriKind.RelativeOrAbsolute);
                            }
                            else
                            {
                                mediaFOND.Source = new Uri(map.Background, UriKind.RelativeOrAbsolute);
                            }
                            break;
                    }
                    mediaFOND.Volume = 0;
                    mediaFOND.MediaEnded += new RoutedEventHandler(Media_Ended);
                    mediaFOND.EndInit();
                    stack.Name = "stack" + id;
                    id++;
                    stack.Children.Add(mediaFOND);
                    flowCarte.Items.Add(stack);
                }
                else
                {
                    switch (MainWindow.selectedLanguage)
                    {
                        case "French":
                            itemssource = map.Background;
                            break;
                        case "Catalan":
                            if (map.BackgroundCAT != null && map.BackgroundCAT != "")
                            {
                                itemssource = map.BackgroundCAT;
                            }
                            else
                            {
                                itemssource = map.Background;
                            }
                            break;
                        case "English":
                            if (map.BackgroundEN != null && map.BackgroundEN != "")
                            {
                                itemssource = map.BackgroundEN;
                            }
                            else
                            {
                                itemssource = map.Background;
                            }
                            break;
                        case "Spanish":
                            if (map.BackgroundES != null && map.BackgroundES != "")
                            {
                                itemssource = map.BackgroundES;
                            }
                            else
                            {
                                itemssource = map.Background;
                            }
                            break;
                        case "German":
                            if (map.BackgroundDE != null && map.BackgroundDE != "")
                            {
                                itemssource = map.BackgroundDE;
                            }
                            else
                            {
                                itemssource = map.Background;
                            }
                            break;
                    }
                    flowCarte.Items.Add(itemssource);
                } 
                
            }  
            flowCarte.SelectedIndex = 0;
            listboxMaps.SelectedIndex = 0;

            if (flowCarte.Items.Count < 2)
            {
                listboxMaps.Visibility = Visibility.Hidden;
            }
        }

        #endregion Public Constructors

        #region Private Destructors

        ~AppBanqueImagesMainView()
        {
            actualIndex = 0;
            ViewModel = null;
            displayedItems = null;
            itemsGarbage = null;
            selectedOnes = null;
            selectedFramework = null;
            myresourcedictionary = null;
            sbFloat = sbDefloat = sbHide = null;
            flowCarte = null;
        }

        #endregion Private Destructors

        #region Public Methods

        /// <summary>
        /// Fermeture du media
        /// </summary>
        /// <param name="svi"></param>
        public void CloseMedia(ScatterViewItem svi)
        {
            svi.BeginAnimation(ScatterViewItem.WidthProperty, new DoubleAnimation()
            {
                From = svi.ActualWidth,
                To = 0,
                Duration = TimeSpan.FromMilliseconds(100),
                FillBehavior = FillBehavior.HoldEnd
            });

            svi.BeginAnimation(ScatterViewItem.HeightProperty, new DoubleAnimation()
            {
                From = svi.ActualHeight,
                To = 0,
                Duration = TimeSpan.FromMilliseconds(100),
                FillBehavior = FillBehavior.HoldEnd
            });
            svi.BeginAnimation(ScatterViewItem.OpacityProperty, new DoubleAnimation()
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromMilliseconds(500)),
                FillBehavior = FillBehavior.HoldEnd
            });

            itemsGarbage.Add(svi);
        }

        #endregion Public Methods

        #region Protected Methods

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            DataContext = null;
            ViewModel = null;
            itemsGarbage.Clear();
            selectedOnes.Clear();
            selectedFramework.Clear();
            ScatterView.Items.Clear();
        }

        #endregion Protected Methods

        #region Events

        /// <summary>
        /// Animation terminée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void anim_Completed(object sender, EventArgs e)
        {
            List<ScatterViewItem> items = new List<ScatterViewItem>();
            foreach (ScatterViewItem item in itemsGarbage)
            {
                if (item.Opacity <= 0)
                {
                    ScatterView.Items.Remove(item);
                    items.Add(item);
                }
            }
            foreach (ScatterViewItem item in items)
            {
                itemsGarbage.Remove(item);
            }
        }

        //bouton de fermeture et ouverture du menu principale
        private void BoutonQuit_click(object sender, RoutedEventArgs e)
        {
            //Effet de fermeture
            Storyboard.SetTarget(sbHide, BanqueImagesPanel);
            sbHide.Completed += (s, t) =>
            {
                //Fermeture et ouverture des fenetres
                MainWindow fenetre = new MainWindow();
                fenetre.Show();
                this.Close();
            };
            sbHide.Begin();
        }

        /// <summary>
        /// Activation d'un conteneur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void item_ContainerActivated(object sender, RoutedEventArgs e)
        {
            ScatterViewItem item = (ScatterViewItem)sender;
            Grid grid = (Grid)item.Content;
            foreach (UIElement uiel in grid.Children)
            {
                if (uiel is Label)
                {
                    uiel.BeginAnimation(Label.OpacityProperty, new DoubleAnimation()
                    {
                        From = 0,
                        To = 1,
                        Duration = new Duration(TimeSpan.FromMilliseconds(500))
                    });
                    break;
                }
            }
        }

        /// <summary>
        /// Désactivation du conteneur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void item_ContainerDeactivated(object sender, RoutedEventArgs e)
        {
            ScatterViewItem item = (ScatterViewItem)sender;
            Grid grid = (Grid)item.Content;
            foreach (UIElement uiel in grid.Children)
            {
                if (uiel is Label)
                {
                    uiel.BeginAnimation(Label.OpacityProperty, new DoubleAnimation()
                    {
                        From = 1,
                        To = 0,
                        Duration = new Duration(TimeSpan.FromMilliseconds(500))
                    });
                    break;
                }
            }
        }

        /// <summary>
        /// Relance le media lorsqu'il se termine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void Media_Ended(object sender, RoutedEventArgs e)
        {
            if (sender is MediaElement)
            {
                MediaElement media = (MediaElement)sender;
                media.LoadedBehavior = MediaState.Manual;
                media.Position = new TimeSpan(0, 0, 0);
                media.Play();
            }
        }

        /// <summary>
        /// Apparition du media
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void OnOpened(object sender, RoutedEventArgs e)
        {
            // Variables de taille du media
            float MinHeight = 180;
            float MinWidth = 320;

            float FinalHeight = 0;
            float FinalWidth = 0;

            float MaxHeight = 880;
            float MaxWidth = 1720;

            // Récupère le MediaElement
            MediaElement mediaElement = (MediaElement)sender;

            // S'il s'agit d'un MediaElement
            if (mediaElement.Parent is Grid)
            {
                Grid grid = (Grid)mediaElement.Parent;
                mediaElement.Stretch = Stretch.UniformToFill;

                // Recupere le scatterViewItem
                ScatterViewItem scatterViewItem = (ScatterViewItem)grid.Parent;

                // Recuperer la taille du media
                float CurrentWidth = mediaElement.NaturalVideoWidth;
                float CurrentHeight = mediaElement.NaturalVideoHeight;

                // Si la largeur est supérieur à la hauteur => Mode paysage
                if (CurrentWidth >= CurrentHeight)
                {
                    // Limitation de la taille max du media
                    scatterViewItem.MaxHeight = 900;
                    scatterViewItem.MaxWidth = 1600;

                    // Dimension minimal du media
                    MinHeight = 180;
                    MinWidth = 320;

                    float Height = (CurrentHeight / CurrentWidth) * MinWidth;

                    FinalWidth = MinWidth;
                    FinalHeight = Height;

                    if (Height < MinHeight)
                    {
                        float Width = (CurrentWidth / CurrentHeight) * MinHeight;

                        FinalWidth = Width;
                        FinalHeight = MinHeight;
                    }
                }
                // Sinon Mode portrait
                else
                {
                    // Limitation de la taille max du media
                    scatterViewItem.MaxHeight = 1600;
                    scatterViewItem.MaxWidth = 900;

                    // Dimension minimal du media
                    MinHeight = 320;
                    MinWidth = 180;

                    float Width = (CurrentWidth / CurrentHeight) * MinHeight;

                    FinalWidth = Width;
                    FinalHeight = MinHeight;

                    if (Width < MinWidth)
                    {
                        float Height = (CurrentHeight / CurrentWidth) * MinWidth;

                        FinalWidth = MinWidth;
                        FinalHeight = Height;
                    }
                }

                // Limiter la largeur max
                if (FinalWidth > MaxWidth)
                {
                    FinalWidth = MaxWidth;
                }

                if (FinalWidth == float.NaN)
                {
                    FinalWidth = 0;
                }

                // Limiter la hauteur max
                if (FinalHeight > MaxHeight)
                {
                    FinalHeight = MaxHeight;
                }

                if (FinalHeight == float.NaN)
                {
                    FinalHeight = 0;
                }

                // Animation de la largeur
                scatterViewItem.BeginAnimation(ScatterViewItem.WidthProperty, new DoubleAnimation()
                {
                    From = scatterViewItem.ActualWidth,
                    To = FinalWidth,
                    Duration = TimeSpan.FromMilliseconds(500),
                    FillBehavior = FillBehavior.Stop
                });

                // Animation de la hauteur
                scatterViewItem.BeginAnimation(ScatterViewItem.HeightProperty, new DoubleAnimation()
                {
                    From = scatterViewItem.ActualHeight,
                    To = FinalHeight,
                    Duration = TimeSpan.FromMilliseconds(500),
                    FillBehavior = FillBehavior.Stop
                });

                // Permettre la manipulation du media
                scatterViewItem.CanScale = true;
                scatterViewItem.CanMove = true;
                scatterViewItem.CanRotate = true;
                scatterViewItem.IsManipulationEnabled = true;
            }
        }

        /// <summary>
        /// Sélection d'un placeholder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void selectOne(object sender, RoutedEventArgs e)
        {
            PlaceHolder selectedOne = (PlaceHolder)((sender as FrameworkElement)).DataContext;
            FrameworkElement buttonSelected = (sender as FrameworkElement);
            Image Icon = new Image();
            Image IconOpen = new Image();

            Icon.Source = new BitmapImage(new Uri(selectedOne.IconPath, UriKind.RelativeOrAbsolute));
            IconOpen.Source = new BitmapImage(new Uri(selectedOne.IconPathOpen, UriKind.RelativeOrAbsolute));


            if (selectedOnes.Contains(selectedOne))
            {
                Storyboard.SetTarget(sbDefloat, buttonSelected);
                buttonSelected.BeginStoryboard(sbDefloat);
                selectedOnes.Remove(selectedOne);
                HidePlaceHolder(selectedOne);
                if (selectedFramework.Contains(buttonSelected))
                {
                    selectedFramework.Remove(sender);
                    buttonSelected.Opacity = 1;
                    (sender as Button).Content = Icon;
                }
            }
            else
            {
                Storyboard.SetTarget(sbFloat, buttonSelected);
                buttonSelected.BeginStoryboard(sbFloat);
                selectedOnes.Add(selectedOne);
                DisplayPlaceHolder(selectedOne);
                if (!selectedFramework.Contains(buttonSelected))
                {
                    selectedFramework.Add(sender);
                    buttonSelected.Opacity = 0.5;
                    if (!(String.Equals(selectedOne.IconPathOpen, "")))
                    {
                        (sender as Button).Content = IconOpen;
                    }
                }
            }
        }

        #endregion Events

        #region Private Methods

        /// <summary>
        /// Changement de la carte
        /// </summary>
        private void changeMap()
        {
            if (itemsGarbage.Count > 0 || listboxMaps.SelectedItem == null)
            {
                return;
            }

            // On vide les listes
            displayedItems.Clear();
            selectedOnes.Clear();
            itemsGarbage.Clear();
            ScatterView.Items.Clear();

            // Détection du changement de l'index
            if (listboxMaps.SelectedIndex != actualIndex)
            {
                flowCarte.SelectedIndex = listboxMaps.SelectedIndex;
                actualIndex = listboxMaps.SelectedIndex;
            }
            else
            {
                listboxMaps.SelectedIndex = flowCarte.SelectedIndex;
                actualIndex = flowCarte.SelectedIndex;
            }

            // Modèle contenant la carte avec les points
            ViewModel.Selected = null;

            // Délai dans l'affichage des placeholders
            dispatcherTimer.Tick += (s, t) =>
            {
                ViewModel.Selected = listboxMaps.Items[actualIndex] as Map;
                dispatcherTimer.Stop();
            };
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            dispatcherTimer.Start();
        }

        /// <summary>
        /// Supprssion des medias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void clearElements()
        {
            foreach (var el in selectedFramework)
            {
                PlaceHolder ph = (el as FrameworkElement).DataContext as PlaceHolder;
                if (selectedOnes.Contains(ph))
                {
                    PlaceHolder p = (PlaceHolder)((el as FrameworkElement)).DataContext;
                    FrameworkElement buttonSelected = (el as FrameworkElement);

                    if (selectedOnes.Contains(p))
                    {
                        Storyboard.SetTarget(sbDefloat, buttonSelected);
                        buttonSelected.BeginStoryboard(sbDefloat);
                        selectedOnes.Remove(p);

                        /* * * * * * * * * * * * * * *  Retirement des medias  * * * * * * * * * * * * * */
                        if (displayedItems.ContainsKey(p))
                        {
                            foreach (ScatterViewItem svi in displayedItems[p])
                            {
                                PointAnimation anim = new PointAnimation
                                {
                                    From = new Point(svi.ActualCenter.X, svi.ActualCenter.Y),
                                    To = new Point(p.X, p.Y),
                                    Duration = new Duration(TimeSpan.FromMilliseconds(450))
                                };
                                anim.Completed += (a, b) =>
                                {
                                    anim_Completed(null, null);
                                    changeMap();
                                };

                                svi.BeginAnimation(ScatterViewItem.HeightProperty, new DoubleAnimation()
                                {
                                    From = svi.ActualHeight,
                                    To = 0,
                                    Duration = new Duration(TimeSpan.FromMilliseconds(450))
                                });
                                svi.BeginAnimation(ScatterViewItem.WidthProperty, new DoubleAnimation()
                                {
                                    From = svi.ActualWidth,
                                    To = 0,
                                    Duration = new Duration(TimeSpan.FromMilliseconds(450))
                                });
                                svi.BeginAnimation(ScatterViewItem.OpacityProperty, new DoubleAnimation()
                                {
                                    From = 1,
                                    To = 0,
                                    Duration = new Duration(TimeSpan.FromMilliseconds(450))
                                });
                                svi.BeginAnimation(ScatterViewItem.CenterProperty, anim);
                                itemsGarbage.Add(svi);
                            }
                            displayedItems.Remove(p);
                        }
                        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
                    }
                }
            }
            selectedFramework.Clear();
        }

        /// <summary>
        /// Désactivation la sélection via la molette
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void disableSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Force l'index de la carte à celle de la liste
            //flowCarte.SelectedIndex = listboxMaps.SelectedIndex;
        }

        /// <summary>
        /// Display the given media placeholder relative to the original placeholder
        /// </summary>
        private void DisplayPlaceHolder(PlaceHolder placeholder)
        {
            if (displayedItems.ContainsKey(placeholder))
            {
                Console.WriteLine("Trying to display something already displayed...");
                return;
            }
            List<ScatterViewItem> items = new List<ScatterViewItem>();

            int totalMedia = placeholder.Media.Count;
            int currentMedia = 0;
            foreach (Media media in placeholder.Media)
            {
                ScatterViewItem item = new ScatterViewItem();
                item.SetRelativeZIndex(RelativeScatterViewZIndex.Topmost);

                item.ContainerActivated += new RoutedEventHandler(item_ContainerActivated);
                item.ContainerDeactivated += new RoutedEventHandler(item_ContainerDeactivated);
                Grid content = new Grid
                {
                    VerticalAlignment = VerticalAlignment.Stretch,
                    HorizontalAlignment = HorizontalAlignment.Stretch
                };

                MediaElement mediaElement = new MediaElement();
                mediaElement.BeginInit();
                try
                {
                    // Image ou vidéo
                    content.Children.Add(mediaElement);
                    mediaElement.Source = new Uri(media.Path);
                    mediaElement.Stretch = Stretch.Uniform;
                    mediaElement.Volume = 0;
                    mediaElement.HorizontalAlignment = HorizontalAlignment.Stretch;
                    mediaElement.VerticalAlignment = VerticalAlignment.Stretch;
                    mediaElement.MediaOpened += new RoutedEventHandler(OnOpened);
                    mediaElement.MediaEnded += new RoutedEventHandler(Media_Ended);
                    mediaElement.EndInit();

                    // Nom du media
                    Label lblMediaName = new Label
                    {
                        HorizontalAlignment = HorizontalAlignment.Stretch,
                        VerticalAlignment = VerticalAlignment.Bottom,
                        Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#96000000")),
                        Foreground = new SolidColorBrush(Colors.White),
                        FontFamily = new FontFamily(new Uri("pack://application:,,,/"), "./Fonts/#Luciole"),
                        Opacity = 0
                    };
                    lblMediaName.Content = media.Name;
                    switch (MainWindow.selectedLanguage)
                    {
                        case "Catalan":
                            if (media.NameCAT != null & media.NameCAT != "")
                                lblMediaName.Content = media.NameCAT;
                            break;
                        case "English":
                            if (media.NameEN != null & media.NameEN != "")
                                lblMediaName.Content = media.NameEN;
                            break;
                        case "Spanish":
                            if (media.NameES != null & media.NameES != "")
                                lblMediaName.Content = media.NameES;
                            break;
                        case "German":
                            if (media.NameDE != null & media.NameDE != "")
                                lblMediaName.Content = media.NameDE;
                            break;
                    }
                    content.Children.Add(lblMediaName);

                    item.Content = content;

                    items.Add(item);
                    ScatterView sv = ScatterView;

                    item.CanMove = true;
                    item.CanRotate = true;
                    item.CanScale = true;

                    sv.Items.Add(item);

                    //animation
                    double teta = Math.PI * (currentMedia / (float)totalMedia * 360) / 180;
                    double x = 300 * Math.Cos(teta);
                    double y = 300 * Math.Sin(teta);

                    double endX = placeholder.X + x;
                    double endY = placeholder.Y + y;

                    item.BeginAnimation(ScatterViewItem.CenterProperty, new PointAnimation()
                    {
                        From = new Point(placeholder.X, placeholder.Y),
                        To = new Point(endX, endY),
                        Duration = new Duration(TimeSpan.FromMilliseconds(250)),
                        FillBehavior = FillBehavior.Stop
                    });
                    item.BeginAnimation(ScatterViewItem.OpacityProperty, new DoubleAnimation()
                    {
                        From = 0,
                        To = 1,
                        Duration = new Duration(TimeSpan.FromMilliseconds(100)),
                        FillBehavior = FillBehavior.Stop
                    });

                    currentMedia++;
                }
                catch (UriFormatException)
                {
                }
            }
            displayedItems.Add(placeholder, items);
        }

        /// <summary>
        /// Hide media from the given placeholder
        /// </summary>
        private void HidePlaceHolder(PlaceHolder p)
        {
            if (displayedItems.ContainsKey(p))
            {
                foreach (ScatterViewItem svi in displayedItems[p])
                {
                    PointAnimation anim = new PointAnimation
                    {
                        From = new Point(svi.ActualCenter.X, svi.ActualCenter.Y),
                        To = new Point(p.X, p.Y),
                        Duration = new Duration(TimeSpan.FromMilliseconds(450))
                    };
                    anim.Completed += new EventHandler(anim_Completed);

                    svi.BeginAnimation(ScatterViewItem.HeightProperty, new DoubleAnimation()
                    {
                        From = svi.ActualHeight,
                        To = 0,
                        Duration = new Duration(TimeSpan.FromMilliseconds(450))
                    });
                    svi.BeginAnimation(ScatterViewItem.WidthProperty, new DoubleAnimation()
                    {
                        From = svi.ActualWidth,
                        To = 0,
                        Duration = new Duration(TimeSpan.FromMilliseconds(450))
                    });
                    svi.BeginAnimation(ScatterViewItem.OpacityProperty, new DoubleAnimation()
                    {
                        From = 1,
                        To = 0,
                        Duration = new Duration(TimeSpan.FromMilliseconds(450))
                    });
                    svi.BeginAnimation(ScatterViewItem.CenterProperty, anim);
                    itemsGarbage.Add(svi);
                }
                displayedItems.Remove(p);
            }
            else
            {
                Console.WriteLine("Trying to hide something that is not displayed");
            }
        }

        /// <summary>
        /// Change la carte sélectionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void mapSelection(object sender, SelectionChangedEventArgs e)
        {
            if (selectedFramework.Count > 0)
            {
                clearElements();
            }
            else
            {
                changeMap();
            }
        }

        #endregion Private Methods
    }
}