using AppAdministrationWPF.ViewModel;
using CommonSurface.Model;
using Microsoft.Win32;
using System;
using System.Windows;

namespace AppAdministrationWPF.View
{
    /// <summary>
    /// Logique d'interaction pour MediaDialog.xaml
    /// </summary>
    public partial class MediaDialog : Window
    {
        #region Private Fields

        private MediaDialogModel _viewModel;
        private Media new_media;
        private Media old_media;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Use a COPY
        /// </summary>
        /// <param name="media"></param>
        public MediaDialog(MediaDialogModel viewModel)
        {
            InitializeComponent();

            old_media = viewModel.Selected;
            new_media = new Media(viewModel.Selected);

            txtPathFR.Text = viewModel.Path;
            txtPathCAT.Text = viewModel.PathCAT;
            txtPathEN.Text = viewModel.PathEN;
            txtPathES.Text = viewModel.PathES;
            txtPathDE.Text = viewModel.PathDE;

            txtNameFR.Text = viewModel.Name;
            txtNameCAT.Text = viewModel.NameCAT;
            txtNameEN.Text = viewModel.NameEN;
            txtNameES.Text = viewModel.NameES;
            txtNameDE.Text = viewModel.NameDE;

            if (old_media.Path != null && old_media.Path != "")
                Apercu.Source = new System.Uri(old_media.Path);
            else
                Apercu.Source = null;

            ViewModel = viewModel;
            DataContext = ViewModel;

        }

        #endregion Public Constructors

        #region Public Properties

        public Media Selected
        {
            get { return _viewModel.Selected; }
            set { _viewModel.Selected = value; }
        }

        public MediaDialogModel ViewModel
        {
            get { return _viewModel; }
            set { _viewModel = value; }
        }

        #endregion Public Properties

        #region Private Methods

        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btOK_Click(object sender, RoutedEventArgs e)
        {
            new_media.Name = txtNameFR.Text;
            new_media.NameCAT = txtNameCAT.Text;
            new_media.NameEN = txtNameEN.Text;
            new_media.NameES = txtNameES.Text;
            new_media.NameDE = txtNameDE.Text;

            new_media.Path = txtPathFR.Text;
            new_media.PathCAT = txtPathCAT.Text;
            new_media.PathEN = txtPathEN.Text;
            new_media.PathES = txtPathES.Text;
            new_media.PathDE = txtPathDE.Text;

            if (new_media.Name.Length <= 0 || new_media.Path.Length <= 0)
            {
                MessageBox.Show("Le nom ou l'image n'a pas été définis.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            old_media.Copy(new_media);
            DialogResult = true;
            this.Close();
        }

        private void btOpenFR_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Videos(*.mov, *.wmv, *.mp4)|*.mov;*.wmv;*.mp4|Photos (*.jpg, *.png)|*.jpg;*.png|Photos & Videos|*.mov;*.wmv;*.jpg;*.png; *.mp4; *.*";
            fileDialog.FilterIndex = 4;
            fileDialog.Multiselect = false;
            Nullable<bool> result = fileDialog.ShowDialog();
            if (result == true)
            {
                new_media.Path = fileDialog.FileName;
                txtPathFR.Text = fileDialog.FileName;
                Apercu.Source = new System.Uri(new_media.Path);
            }
        }

        private void btOpenCAT_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Videos(*.mov, *.wmv, *.mp4)|*.mov;*.wmv;*.mp4|Photos (*.jpg, *.png)|*.jpg;*.png|Photos & Videos|*.mov;*.wmv;*.jpg;*.png; *.mp4; *.*";
            fileDialog.FilterIndex = 4;
            fileDialog.Multiselect = false;
            Nullable<bool> result = fileDialog.ShowDialog();
            if (result == true)
            {
                new_media.PathCAT = fileDialog.FileName;
                txtPathCAT.Text = fileDialog.FileName;
                Apercu.Source = new System.Uri(new_media.PathCAT);
            }
        }

        private void btOpenEN_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Videos(*.mov, *.wmv, *.mp4)|*.mov;*.wmv;*.mp4|Photos (*.jpg, *.png)|*.jpg;*.png|Photos & Videos|*.mov;*.wmv;*.jpg;*.png; *.mp4; *.*";
            fileDialog.FilterIndex = 4;
            fileDialog.Multiselect = false;
            Nullable<bool> result = fileDialog.ShowDialog();
            if (result == true)
            {
                new_media.PathEN = fileDialog.FileName;
                txtPathEN.Text = fileDialog.FileName;
                Apercu.Source = new System.Uri(new_media.PathEN);
            }
        }

        private void btOpenES_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Videos(*.mov, *.wmv, *.mp4)|*.mov;*.wmv;*.mp4|Photos (*.jpg, *.png)|*.jpg;*.png|Photos & Videos|*.mov;*.wmv;*.jpg;*.png; *.mp4; *.*";
            fileDialog.FilterIndex = 4;
            fileDialog.Multiselect = false;
            Nullable<bool> result = fileDialog.ShowDialog();
            if (result == true)
            {
                new_media.PathES = fileDialog.FileName;
                txtPathES.Text = fileDialog.FileName;
                Apercu.Source = new System.Uri(new_media.PathES);
            }
        }

        private void btOpenDE_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Videos(*.mov, *.wmv, *.mp4)|*.mov;*.wmv;*.mp4|Photos (*.jpg, *.png)|*.jpg;*.png|Photos & Videos|*.mov;*.wmv;*.jpg;*.png; *.mp4; *.*";
            fileDialog.FilterIndex = 4;
            fileDialog.Multiselect = false;
            Nullable<bool> result = fileDialog.ShowDialog();
            if (result == true)
            {
                new_media.PathDE = fileDialog.FileName;
                txtPathDE.Text = fileDialog.FileName;
                Apercu.Source = new System.Uri(new_media.PathDE);
            }
        }

        #endregion Private Methods

        private void LangageType_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            //On masque toutes les cases et labels de toutes les langues.
            lblcheminFR.Visibility = Visibility.Hidden;
            lblNameFR.Visibility = Visibility.Hidden;
            txtPathFR.Visibility = Visibility.Hidden;
            txtNameFR.Visibility = Visibility.Hidden;
            btOpenFR.Visibility = Visibility.Hidden;

            lblcheminCAT.Visibility = Visibility.Hidden;
            lblNameCAT.Visibility = Visibility.Hidden;
            txtPathCAT.Visibility = Visibility.Hidden;
            txtNameCAT.Visibility = Visibility.Hidden;
            btOpenCAT.Visibility = Visibility.Hidden;

            lblcheminEN.Visibility = Visibility.Hidden;
            lblNameEN.Visibility = Visibility.Hidden;
            txtPathEN.Visibility = Visibility.Hidden;
            txtNameEN.Visibility = Visibility.Hidden;
            btOpenEN.Visibility = Visibility.Hidden;

            lblcheminES.Visibility = Visibility.Hidden;
            lblNameES.Visibility = Visibility.Hidden;
            txtPathES.Visibility = Visibility.Hidden;
            txtNameES.Visibility = Visibility.Hidden;
            btOpenES.Visibility = Visibility.Hidden;

            lblcheminDE.Visibility = Visibility.Hidden;
            lblNameDE.Visibility = Visibility.Hidden;
            txtPathDE.Visibility = Visibility.Hidden;
            txtNameDE.Visibility = Visibility.Hidden;
            btOpenDE.Visibility = Visibility.Hidden;

            switch (((System.Windows.Controls.ContentControl)((System.Windows.Controls.Primitives.Selector)sender).SelectedItem).Content)
            {
                //On affiche les cases et labels correspondants à la langues sélectionné dans le menu déroulant
                case "FR":
                    lblcheminFR.Visibility = Visibility.Visible;
                    lblNameFR.Visibility = Visibility.Visible;
                    txtPathFR.Visibility = Visibility.Visible;
                    txtNameFR.Visibility = Visibility.Visible;
                    btOpenFR.Visibility = Visibility.Visible;
                    Apercu.Source = new System.Uri(old_media.Path);
                    break;
                case "CAT":
                    lblcheminCAT.Visibility = Visibility.Visible;
                    lblNameCAT.Visibility = Visibility.Visible;
                    txtPathCAT.Visibility = Visibility.Visible;
                    txtNameCAT.Visibility = Visibility.Visible;
                    btOpenCAT.Visibility = Visibility.Visible;
                    if (old_media.PathCAT != null && old_media.PathCAT != "")
                        Apercu.Source = new System.Uri(old_media.PathCAT);
                    else
                        Apercu.Source = null;
                    break;
                case "EN":
                    lblcheminEN.Visibility = Visibility.Visible;
                    lblNameEN.Visibility = Visibility.Visible;
                    txtPathEN.Visibility = Visibility.Visible;
                    txtNameEN.Visibility = Visibility.Visible;
                    btOpenEN.Visibility = Visibility.Visible;
                    if (old_media.PathEN != null && old_media.PathEN != "")
                        Apercu.Source = new System.Uri(old_media.PathEN);
                    else
                        Apercu.Source = null;
                    break;
                case "ES":
                    lblcheminES.Visibility = Visibility.Visible;
                    lblNameES.Visibility = Visibility.Visible;
                    txtPathES.Visibility = Visibility.Visible;
                    txtNameES.Visibility = Visibility.Visible;
                    btOpenES.Visibility = Visibility.Visible;
                    if (old_media.PathES != null && old_media.PathES != "")
                        Apercu.Source = new System.Uri(old_media.PathES);
                    else
                        Apercu.Source = null;
                    break;
                case "DE":
                    lblcheminDE.Visibility = Visibility.Visible;
                    lblNameDE.Visibility = Visibility.Visible;
                    txtPathDE.Visibility = Visibility.Visible;
                    txtNameDE.Visibility = Visibility.Visible;
                    btOpenDE.Visibility = Visibility.Visible;
                    if (old_media.PathDE != null && old_media.PathDE != "")
                        Apercu.Source = new System.Uri(old_media.PathDE);
                    else
                        Apercu.Source = null;
                    break;
                case null:
                    lblcheminFR.Visibility = Visibility.Visible;
                    lblNameFR.Visibility = Visibility.Visible;
                    txtPathFR.Visibility = Visibility.Visible;
                    txtNameFR.Visibility = Visibility.Visible;
                    btOpenFR.Visibility = Visibility.Visible;
                    break;
            }
        }
    }
}