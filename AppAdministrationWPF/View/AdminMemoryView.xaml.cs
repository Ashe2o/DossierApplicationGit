using AppAdministrationWPF.Utils;
using AppAdministrationWPF.ViewModel;
using CommonSurface.Model;
using CommonSurface.Other;
using Microsoft.Win32;
using System;
using System.Configuration;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace AppAdministrationWPF.View
{
    /// <summary>
    /// Logique d'interaction pour AdminMemoryView2.xaml
    /// </summary>
    public partial class AdminMemoryView : UserControl
    {
        #region Private Fields

        private AdminMemoryViewModel _viewModel;
        private string chemin = ConfigurationManager.AppSettings["cheminMemory"];
        private string cheminLibrairie = ConfigurationManager.AppSettings["cheminLibrairieMemory"];

        #endregion Private Fields

        #region Public Constructors

        public AdminMemoryView()
        {
            InitializeComponent();
            _viewModel = ServiceLocator.AdminMemoryViewModel;
            this.DataContext = _viewModel;

            #region Récupération des niveaux Memory

            // Niveau 1
            niveau1Memory.Source = ResourceAccessor.loadImage(ConfigurationManager.AppSettings["cheminNiveau1Memory"]);
            // Niveau 2
            niveau2Memory.Source = ResourceAccessor.loadImage(ConfigurationManager.AppSettings["cheminNiveau2Memory"]);
            // Niveau 3
            niveau3Memory.Source = ResourceAccessor.loadImage(ConfigurationManager.AppSettings["cheminNiveau3Memory"]);

            // Arrière plans
            arrierePlansMemory.Source = ResourceAccessor.loadImage(ConfigurationManager.AppSettings["cheminArrierePlanMemory"]); 

            #endregion Récupération des niveaux Memory
        }

        #endregion Public Constructors

        #region Public Properties

        public AdminMemoryViewModel ViewModel
        {
            get { return _viewModel; }
            set { _viewModel = value; }
        }

        #endregion Public Properties

        #region Private Methods

        /// <summary>
        /// Ajout d'un nouveau Memory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            gridAdministration.Visibility = Visibility.Visible;
            UpdateVisibility(true);

            Picture p = Picture.Blank();
            ViewModel.Pictures.Add(p);
            ListPictures.SelectedItem = ViewModel.Selected = p;
        }

        /// <summary>
        /// Annulation des modifications
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            gridAdministration.Visibility = Visibility.Hidden;
            UpdateVisibility(false);
        }

        /// <summary>
        /// Suppression du Memory sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.Selected != null)
            {
                gridAdministration.Visibility = Visibility.Hidden;
                UpdateVisibility(false);
                ViewModel.Pictures.Remove(ViewModel.Selected);
                ViewModel.Selected = null;
                ViewModel.Save();
            }
        }

        /// <summary>
        /// Sélection de la difficulté
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void DifficultySelection(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ViewModel.filterPictures(button.Tag as string);
            gridAdministration.Visibility = Visibility.Hidden;
            UpdateVisibility(false);
        }

        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            Export export = new Export(chemin, cheminLibrairie);
            export.Show();
        }

        private void ImportButton_Click(object sender, RoutedEventArgs e)
        {
            Import import = new Import(chemin, cheminLibrairie, false, false);
            import.Closing += (s, t) =>
            {
                ViewModel.Refresh();  
            };
            import.Show();
        }

        /// <summary>
        /// Modification d'un Memory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void ModifyButton_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.Selected != null)
            {
                gridAdministration.Visibility = Visibility.Visible;
                UpdateVisibility(true);
            }
        }
        /// <summary>
        /// Sélection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Photos (*.jpg, *.png)|*.jpg;*.png";
            fileDialog.FilterIndex = 0;
            fileDialog.Multiselect = false;
            bool? result = fileDialog.ShowDialog();
            if (result == true)
            {
                txtSource.Text = fileDialog.FileName;
                previewMedia.Source = new Uri(fileDialog.FileName);
            }
        }

        /// <summary>
        /// Mise à jour de la sélection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void updateSelection(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                ViewModel.Selected = e.AddedItems[0] as Picture;
                txtSource.Text = ViewModel.Selected.Source;
                txtName.Text = ViewModel.Selected.Name;
            }
            else
            {
                gridAdministration.Visibility = Visibility.Hidden;
                txtSource.Text = txtName.Text = "";
            }
        }

        /// <summary>
        /// Mise à jour des la visibilité des boutons de configuration
        /// </summary>
        /// <param name="previewVisible">Preview visible ?</param>
        /// <param name="deleteVisible"> Bouton de suppression visible ?</param>
        private void UpdateVisibility(bool editMode)
        {
            AddButton.Visibility = ModifyButton.Visibility = DeleteButton.Visibility = editMode ? Visibility.Collapsed : Visibility.Visible;
            previewMedia.Visibility = editMode ? Visibility.Visible : Visibility.Collapsed;
        }

        /// <summary>
        /// Applications des modifications
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void ValidateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                gridAdministration.Visibility = Visibility.Hidden;
                UpdateVisibility(false);
                ViewModel.Selected.Source = txtSource.Text;
                ViewModel.Selected.Name = txtName.Text;
                ListPictures.Items.Refresh();
                ViewModel.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error AdminMemoryView : " + ex.Message);
            }
        }

        #endregion Private Methods
    }
}