using CommonSurface.Model;
using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace AppAdministrationWPF.View
{
    /// <summary>
    /// Logique d'interaction pour VisitePanoramaEditDialog.xaml
    /// </summary>
    public partial class PanoramaEditDialog : Window
    {
        #region Private Fields

        private bool _cancel;
        private Panorama new_panorama;
        private Panorama panorama;

        #endregion Private Fields

        #region Public Constructors

        public PanoramaEditDialog(Panorama panorama)
        {
            InitializeComponent();

            this._cancel = true;
            this.panorama = panorama;
            this.new_panorama = new Panorama(panorama);
            this.DataContext = this.new_panorama;

            // Fond pour le border
            BitmapDecoder decoder = BitmapDecoder.Create(
                    new Uri("pack://application:,,,/CommonSurface;component/Resources/FondTextBoxe.jpg", UriKind.RelativeOrAbsolute),
                    BitmapCreateOptions.PreservePixelFormat,
                    BitmapCacheOption.OnLoad);
            ImageBrush brush = new ImageBrush(decoder.Frames[0]);
            bdrInfoMASK.Background = brush;
        }

        #endregion Public Constructors

        #region Public Methods

        public bool IsCancel()
        {
            return _cancel;
        }

        #endregion Public Methods

        #region Private Methods

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this._cancel = true;
            this.Close();
        }

        /// <summary>
        /// Retire le média assigné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void buttonMediaDelete_Click(object sender, RoutedEventArgs e)
        {
            new_panorama.Media = "";
        }

        private void buttonMediaSearch_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Photos (*.jpg, *.png)|*.jpg;*.png|Vidéos (*.mp4, *.mov)|*.mp4;*.mov|Tous les fichiers|*.*";
            fileDialog.FilterIndex = 0;
            fileDialog.Multiselect = false;
            Nullable<bool> result = fileDialog.ShowDialog();
            if (result == true)
            {
                new_panorama.Media = fileDialog.FileName;
            }
        }

        /// <summary>
        /// Validation des modifications
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {
            string missing = "";

            // Vérification du titre
            if (txtTitle.Text.Length <= 0)
            {
                missing += " - Aucun titre n'est présent.\n";
            }

            if (txtDescription.Text.Length <= 0 && txtMedia.Text.Length <= 0)
            {
                missing += " - Aucune description ou média n'est présent.\n";
            }

            if (txtCopyright.Text.Length <= 0)
            {
                missing += " - Aucun copyright n'est présent.\n";
            }

            if (missing.Length > 0)
            {
                string message = "Certaines données sont manquantes:\n" + missing + "\n\nVoulez-vous quand même sauvegarder ?";
                var result = MessageBox.Show(
                    message,
                    "Donnée(s) manquante(s)",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question,
                    MessageBoxResult.No
                    );

                // Annulation de la sauvegarde
                if (result != MessageBoxResult.Yes)
                {
                    return;
                }
            }

            panorama.Copy(new_panorama);
            this._cancel = false;
            this.Close();
        }

        /// <summary>
        /// Relance le média lorsqu'il est finis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void Media_Ended(object sender, RoutedEventArgs e)
        {
            MediaElement media = (MediaElement)sender;
            media.Position = new TimeSpan(0, 0, 0, 1);
            media.Play();
        }

        /// <summary>
        /// Met à jour le copyright quand le ttexte change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void UpdateCopyright(object sender, EventArgs e)
        {
            new_panorama.Copyright = txtCopyright.Text;
        }

        /// <summary>
        /// Met à jour la description en FRANCAIS lorsque le texte change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void UpdateDescription(object sender, EventArgs e)
        {
            new_panorama.Description = txtDescription.Text;
        }

        /// <summary>
        /// Met à jour la description en CATALAN lorsque le texte change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void UpdateDescriptionCAT(object sender, EventArgs e)
        {
            new_panorama.DescriptionCAT = txtDescriptionCAT.Text;
        }

        /// <summary>
        /// Met à jour la description en ANGLAIS lorsque le texte change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void UpdateDescriptionEN(object sender, EventArgs e)
        {
            new_panorama.DescriptionEN = txtDescriptionEN.Text;
        }

        /// <summary>
        /// Met à jour la description en ESPAGNOL lorsque le texte change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void UpdateDescriptionES(object sender, EventArgs e)
        {
            new_panorama.DescriptionES = txtDescriptionES.Text;
        }

        /// <summary>
        /// Met à jour la description en ALLEMAND lorsque le texte change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void UpdateDescriptionDE(object sender, EventArgs e)
        {
            new_panorama.DescriptionDE = txtDescriptionDE.Text;
        }

        /// <summary>
        /// Met à jour le titre FRANCAIS lorsque le texte change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void UpdateTitle(object sender, EventArgs e)
        {
            new_panorama.Title = txtTitle.Text;
        }

        /// <summary>
        /// Met à jour le titre CATALAN lorsque le texte change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void UpdateTitleCAT(object sender, TextChangedEventArgs e)
        {
            new_panorama.TitleCAT = txtTitleCAT.Text;
        }

        /// <summary>
        /// Met à jour le titre ANGLAIS lorsque le texte change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void UpdateTitleEN(object sender, TextChangedEventArgs e)
        {
            new_panorama.TitleEN = txtTitleEN.Text;
        }

        /// <summary>
        /// Met à jour le titre ESPAGNOL lorsque le texte change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void UpdateTitleES(object sender, TextChangedEventArgs e)
        {
            new_panorama.TitleES = txtTitleES.Text;
        }

        /// <summary>
        /// Met à jour le titre ALLEMAND lorsque le texte change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void UpdateTitleDE(object sender, TextChangedEventArgs e)
        {
            new_panorama.TitleDE = txtTitleDE.Text;
        }

        private void LangageType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //On masque toutes les cases et labels de toutes les langues.
            lblTitleFR.Visibility = Visibility.Hidden;
            lblDescriptionFR.Visibility = Visibility.Hidden;
            txtTitle.Visibility = Visibility.Hidden;
            txtDescription.Visibility = Visibility.Hidden;

            lblTitleCAT.Visibility = Visibility.Hidden;
            lblDescriptionCAT.Visibility = Visibility.Hidden;
            txtTitleCAT.Visibility = Visibility.Hidden;
            txtDescriptionCAT.Visibility = Visibility.Hidden;

            lblTitleEN.Visibility = Visibility.Hidden;
            lblDescriptionEN.Visibility = Visibility.Hidden;
            txtTitleEN.Visibility = Visibility.Hidden;
            txtDescriptionEN.Visibility = Visibility.Hidden;

            lblTitleES.Visibility = Visibility.Hidden;
            lblDescriptionES.Visibility = Visibility.Hidden;
            txtTitleES.Visibility = Visibility.Hidden;
            txtDescriptionES.Visibility = Visibility.Hidden;

            lblTitleDE.Visibility = Visibility.Hidden;
            lblDescriptionDE.Visibility = Visibility.Hidden;
            txtTitleDE.Visibility = Visibility.Hidden;
            txtDescriptionDE.Visibility = Visibility.Hidden;

            switch (((System.Windows.Controls.ContentControl)((System.Windows.Controls.Primitives.Selector)sender).SelectedItem).Content)
            {
                //On affiche les cases et labels correspondants à la langues sélectionné dans le menu déroulant
                case "FR":
                case null:
                    lblTitleFR.Visibility = Visibility.Visible;
                    lblDescriptionFR.Visibility = Visibility.Visible;
                    txtTitle.Visibility = Visibility.Visible;
                    txtDescription.Visibility = Visibility.Visible;
                    break;
                case "CAT":
                    lblTitleCAT.Visibility = Visibility.Visible;
                    lblDescriptionCAT.Visibility = Visibility.Visible;
                    txtTitleCAT.Visibility = Visibility.Visible;
                    txtDescriptionCAT.Visibility = Visibility.Visible;
                    break;
                case "EN":
                    lblTitleEN.Visibility = Visibility.Visible;
                    lblDescriptionEN.Visibility = Visibility.Visible;
                    txtTitleEN.Visibility = Visibility.Visible;
                    txtDescriptionEN.Visibility = Visibility.Visible;
                    break;
                case "ES":
                    lblTitleES.Visibility = Visibility.Visible;
                    lblDescriptionES.Visibility = Visibility.Visible;
                    txtTitleES.Visibility = Visibility.Visible;
                    txtDescriptionES.Visibility = Visibility.Visible;
                    break;
                case "DE":
                    lblTitleDE.Visibility = Visibility.Visible;
                    lblDescriptionDE.Visibility = Visibility.Visible;
                    txtTitleDE.Visibility = Visibility.Visible;
                    txtDescriptionDE.Visibility = Visibility.Visible;
                    break;
            }
        }
    }

        #endregion Private Methods
}