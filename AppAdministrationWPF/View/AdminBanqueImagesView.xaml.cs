using AppAdministrationWPF.Utils;
using AppAdministrationWPF.ViewModel;
using CommonSurface.DAO;
using CommonSurface.Model;
using CommonSurface.Other;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace AppAdministrationWPF.View
{
    /// <summary>
    /// Logique d'interaction pour AdminBanqueImagesView.xaml
    /// </summary>
    public partial class AdminBanqueImagesView : UserControl 
    {
        #region Private Fields

        private AdminBanqueImagesViewModel _viewModel;
        private string chemin = ConfigurationManager.AppSettings["cheminBanqueImages"];
        private string cheminLibrairie = ConfigurationManager.AppSettings["cheminLibrairieBanqueImages"];
        private ResourceDictionary myresourcedictionary;
        private Button selectedOne;

        #endregion Private Fields

        #region Public Constructors

        public AdminBanqueImagesView()
        {
            InitializeComponent();
            _viewModel = ServiceLocator.AdminBanqueImagesViewModel;
            this.DataContext = _viewModel;

            if (ViewModel.Maps.Count > 0)
            {
                listboxMapsBanqueImages.SelectedIndex = 0;
            }

            myresourcedictionary = new ResourceDictionary();
            myresourcedictionary.Source = new Uri("/CommonSurface;component/XAML/Effects.xaml", UriKind.RelativeOrAbsolute);

            listboxMapsBanqueImages.Items.SortDescriptions.Clear();
            listboxMapsBanqueImages.Items.SortDescriptions.Add(
                new SortDescription("ID", ListSortDirection.Ascending)
                );
        }

        #endregion Public Constructors

        #region Public Properties

        public AdminBanqueImagesViewModel ViewModel
        {
            get { return _viewModel; }
            set { _viewModel = value; }
        }

        #endregion Public Properties

        #region Public Methods

        public void DeletePlace(PlaceHolder place)
        {
            _viewModel.SelectedMap.PlaceHolders.Remove(place);
        }

        public void EditPlace(PlaceHolder place)
        {
            if (place == null)
            {
                MessageBox.Show("Veuillez selectionner un lieu", "Erreur");
                return;
            }
            PlaceHolderWindow cw = new PlaceHolderWindow(place);
            if (cw.ShowDialog() == true)
            {
                _viewModel.SelectedPlaceholder.Name = cw.Selected.Name;
                _viewModel.SelectedPlaceholder.X = cw.Selected.X;
                _viewModel.SelectedPlaceholder.Y = cw.Selected.Y;
                _viewModel.SelectedPlaceholder.Id = cw.Selected.Id;
                _viewModel.SelectedPlaceholder.IconPath = cw.Selected.IconPath;
                _viewModel.SelectedPlaceholder.IconPathOpen = cw.Selected.IconPathOpen;

                _viewModel.SelectedPlaceholder.Media = new System.Collections.ObjectModel.ObservableCollection<Media>(cw.Selected.Media);
            }
        }

        #endregion Public Methods

        #region Private Methods

        private void AddPlace()
        {
            PlaceHolderWindow cw = new PlaceHolderWindow(null);
            if (cw.ShowDialog() == true)
            {
                _viewModel.SelectedMap.PlaceHolders.Add(cw.Selected);
                _viewModel.SelectedPlaceholder = cw.Selected;
            }
        }

        /// <summary>
        /// Ajout d'une nouvelle Banque d'Images
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void btAddMap_Click(object sender, RoutedEventArgs e)
        {
            // Nouvelle Banque d'Image
            ListBox listboxMaps1 = listboxMapsBanqueImages;
            int id = 0;
            if (listboxMapsBanqueImages.Items.Count != 0)
            {
                id = (listboxMaps1.Items[listboxMapsBanqueImages.Items.Count - 1] as Map).ID + 1;
            }

            Map map = Map.Blank(id);
            MapWindow window = new MapWindow(map);

            // On ajoute que si tout est bon
            window.Closing += (s, t) =>
            {
                if (!window.isCancel())
                {
                    _viewModel.Maps.Add(map);
                    listboxMapsBanqueImages.SelectedIndex = _viewModel.Maps.Count - 1;
                }
            };

            window.Show();
        }

        private void btAddPlace_Click(object sender, RoutedEventArgs e)
        {
            AddPlace();
        }

        /// <summary>
        /// Suppresion d'une banque d'images
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void btDeleteMap_Click(object sender, RoutedEventArgs e)
        {
            if (_viewModel.SelectedMap != null) 
            {
                int index = listboxMapsBanqueImages.SelectedIndex;
                _viewModel.Maps.Remove(_viewModel.SelectedMap);
                _viewModel.SelectedMap.PlaceHolders.Clear();

                if (ViewModel.Maps.Count < 1)
                {
                    listboxMapsBanqueImages.SelectedIndex = -1;
                    BanqueImages.Source = null;
                    
                } 
                else if (index > ViewModel.Maps.Count - 1)
                {
                    listboxMapsBanqueImages.SelectedIndex = ViewModel.Maps.Count - 1;
                }
            }
        }

        private void btEditMap_Click(object sender, RoutedEventArgs e)
        {
            Map selected = _viewModel.SelectedMap;
            MapWindow window = new MapWindow(selected);
            window.Closing += (s, t) =>
            {
                if (!window.isCancel())
                {
                    listboxMapsBanqueImages.Items.Refresh();
                    DAOBanqueImages.Save();
                    BanqueImages.Source = ResourceAccessor.loadMedia(_viewModel.SelectedMap.Background).Source;
                }
            };
            window.Show();
        }

        //Action du bouton Exporter
        private void btExporter_Click(object sender, RoutedEventArgs e)
        {
            Export fenetre = new Export(chemin, cheminLibrairie);
            fenetre.Show();
        }

        //Action du bouton Importer
        private void btImporter_Click(object sender, RoutedEventArgs e)
        {
            Import fenetre = new Import(chemin, cheminLibrairie, false, false);
            fenetre.Closing += update_OnClose;
            fenetre.Show();
        }

        private void buttonDown_Click(object sender, RoutedEventArgs e)
        {
            int index = listboxMapsBanqueImages.SelectedIndex;
            if (index < listboxMapsBanqueImages.Items.Count - 1)
            {
                Map map1 = listboxMapsBanqueImages.Items[index] as Map;
                Map map2 = listboxMapsBanqueImages.Items[index + 1] as Map;

                int tmp = map2.ID;
                map2.ID = map1.ID;
                map1.ID = tmp;
            }
            listboxMapsBanqueImages.Items.SortDescriptions.Clear();
            listboxMapsBanqueImages.Items.SortDescriptions.Add(
                new SortDescription("ID", ListSortDirection.Ascending)
                );
        }

        private void buttonUp_Click(object sender, RoutedEventArgs e)
        {
            int index = listboxMapsBanqueImages.SelectedIndex;
            if (index > 0)
            {
                Map map1 = listboxMapsBanqueImages.Items[index] as Map;
                Map map2 = listboxMapsBanqueImages.Items[index - 1] as Map;

                int tmp = map2.ID;
                map2.ID = map1.ID;
                map1.ID = tmp;
            }
            listboxMapsBanqueImages.Items.SortDescriptions.Clear();
            listboxMapsBanqueImages.Items.SortDescriptions.Add(
                new SortDescription("ID", ListSortDirection.Ascending)
                );
        }

        /// <summary>
        /// Sélection de la banque d'images par la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void changeMap(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                _viewModel.SelectedMap = listboxMapsBanqueImages.SelectedItem as Map;
                _viewModel.SelectedPlaceholder = null;

                StackPanel stack = new StackPanel();
                stack.Name = "stackAdmin";
                MediaElement media = ResourceAccessor.loadMedia(_viewModel.SelectedMap.Background);
                stack.Children.Add(media);
                BanqueImages.Source = media.Source;
            }
        }

        private void Map_MouseLeftButtonUp(object sender, MouseEventArgs e)
        {
            // Récupération de la position de la souris par rapport à la banque d'images
            double x = e.GetPosition(canvasBanqueImages).X;
            double y = e.GetPosition(canvasBanqueImages).Y;

            // En dehors de la banque d'images
            if (x < 0 || x > canvasBanqueImages.ActualWidth || y < 0 || y > canvasBanqueImages.ActualHeight)
            {
                return;
            }

            setPlaceHolderPosition(x, y);
        }

        private void Map_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Map_MouseLeftButtonUp(null, e);
            }
        }

        private void miDeletePH_Click(object sender, RoutedEventArgs e)
        {
            if (_viewModel.SelectedPlaceholder == null)
            {
                MessageBox.Show("Veuillez selectionner un lieu", "Erreur");
                return;
            }
            if (MessageBox.Show("Êtes vous sûr de vouloir supprimer ce lieu?", "Suppression d'un lieu", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                DeletePlace(_viewModel.SelectedPlaceholder);
                _viewModel.SelectedPlaceholder = null;
            }
        }

        private void miEditPH_Click(object sender, RoutedEventArgs e)
        {
            if (_viewModel.SelectedPlaceholder == null)
            {
                MessageBox.Show("Veuillez selectionner un lieu", "Erreur");
                return;
            }
            EditPlace(_viewModel.SelectedPlaceholder);
        }

        /// <summary>
        /// Move the selected item to the given position on the map
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void selectOne(object sender, RoutedEventArgs e)
        {
            if (selectedOne != null)
            {
                Storyboard sbDefloating = myresourcedictionary["animDefloat"] as Storyboard;
                Storyboard.SetTarget(sbDefloating, selectedOne);
                selectedOne.BeginStoryboard(sbDefloating);
            }

            selectedOne = (sender as FrameworkElement) as Button;
            _viewModel.SelectedPlaceholder = selectedOne.DataContext as PlaceHolder;

            Storyboard sbFloating = myresourcedictionary["animFloat"] as Storyboard;
            Storyboard.SetTarget(sbFloating, selectedOne);
            selectedOne.BeginStoryboard(sbFloating);
        }

        private void setPlaceHolderPosition(double x, double y)
        {
            if (_viewModel.SelectedPlaceholder != null)
            {
                if (selectedOne != null)
                {
                    _viewModel.SelectedPlaceholder.X = (int)(x - selectedOne.ActualWidth / 2);
                    _viewModel.SelectedPlaceholder.Y = (int)(y - selectedOne.ActualHeight / 2);
                }
            }
        }

        private void update_OnClose(object sender, CancelEventArgs e)
        {
            DAOBanqueImages.Refresh();
            MessageBox.Show("Changer d'onglet et revenez sur celui-ci pour terminer l'importation.");

            if (_viewModel.Maps.Count > 0)
            {
                banqueimagesBackground.ItemsSource = _viewModel.Maps[0].PlaceHolders;
                BanqueImages.Source = ResourceAccessor.loadMedia(_viewModel.SelectedMap.Background).Source;
                listboxMapsBanqueImages.SelectedIndex = 0;
                listboxMapsBanqueImages.Items.Refresh();
                listboxMapsBanqueImages.Items.SortDescriptions.Clear();
                listboxMapsBanqueImages.Items.SortDescriptions.Add(
                    new SortDescription("ID", ListSortDirection.Ascending)
                    );
            }
            else
            {
                banqueimagesBackground.ItemsSource = null;
                BanqueImages.Source = null;
                listboxMapsBanqueImages.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Relance le média lorsque celui-ci se termine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void m_MediaEnded(object sender, RoutedEventArgs e)
        {
            MediaElement media = sender as MediaElement;
            media.Position = TimeSpan.FromSeconds(0);
            media.Play();
        }

        #endregion Private Methods

        #region media actions

        /// <summary>
        /// Add a media
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void btAddMedia_Click(object sender, RoutedEventArgs e)
        {
            if (_viewModel.SelectedPlaceholder == null)
            {
                MessageBox.Show("Veuillez selectionner un lieu", "Erreur");
                return;
            }
            MediaDialog dial = new MediaDialog(new MediaDialogModel(null));
            if (dial.ShowDialog() == true)
            {
                _viewModel.SelectedPlaceholder.Media.Add(dial.Selected);
            }
        }

        #endregion media actions
    }
}