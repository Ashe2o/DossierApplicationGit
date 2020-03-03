using CommonSurface.DAO;
using CommonSurface.Model;
using CommonSurface.ViewModel;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System;
using System.Configuration;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Shapes;
using System.Xml;

namespace AppAdministrationWPF.ViewModel
{
    public class AdminMenuViewModel : ViewModelBase
    {
        #region Private Fields

        private string _background;
        private Credits _credits;
        private Langue _en_US;
        private Langue _fr_FR;
        private Langue _es_ES;
        private Langue _cat_CAT;
        private Langue _de_DE;

        private ObservableCollection<Icon> _icons;
        private Icon _selected;
        private string cheminImageballError = ConfigurationManager.AppSettings["cheminImageballError"];
        private string cheminDrapeauError = ConfigurationManager.AppSettings["cheminDrapeauError"];

        #endregion Private Fields

        #region Public Constructors

        public AdminMenuViewModel()
        {
            this.Load();

            // On vérifie que les chemins existent
            foreach (Icon icon in _icons)
            {
                if (!File.Exists(icon.Source))
                {
                    // Image d'erreur
                    icon.Source = cheminImageballError;
                }
            }

            // On vérifie pour l'icone des crédits
            if (!File.Exists(_credits.Source))
            {
                _credits.Source = cheminImageballError;
            }

            // On vérifie pour les icônes des Langues
            if (!File.Exists(_en_US.Icon.Source))
            {
                _en_US.Icon.Source = cheminDrapeauError;
            }
            if (!File.Exists(_fr_FR.Icon.Source))
            {
                _fr_FR.Icon.Source = cheminDrapeauError;
            }
            if (!File.Exists(_es_ES.Icon.Source))
            {
                _es_ES.Icon.Source = cheminDrapeauError;
            }
            if (!File.Exists(_cat_CAT.Icon.Source))
            {
                _cat_CAT.Icon.Source = cheminDrapeauError;
            }
            if (!File.Exists(_de_DE.Icon.Source))
            {
                _de_DE.Icon.Source = cheminDrapeauError;
            }
        }

        #endregion Public Constructors

        #region Public Properties

        public string Background
        {
            get { return _background; }
            set { _background = value; }
        }

        public Credits Credits
        {
            get { return _credits; }
            set { _credits = value; }
        }

        public Langue English
        {
            get { return _en_US; }
            set { _en_US = value; }
        }

        public Langue French
        {
            get { return _fr_FR; }
            set { _fr_FR = value; }
        }

        public Langue Spanish
        {
            get { return _es_ES; }
            set { _es_ES = value; }
        }

        public Langue Catalan
        {
            get { return _cat_CAT; }
            set { _cat_CAT = value; }
        }

        public Langue German
        {
            get { return _de_DE; }
            set { _de_DE = value; }
        }

        public ObservableCollection<Icon> Icons
        {
            get { return _icons; }
            set { _icons = value; }
        }

        /// <summary>
        /// The selected place holder Watchout, it could be null...
        /// </summary>
        public Icon Selected
        {
            get { return _selected; }
            set
            {
                // setting value
                _selected = value;
                if (value != null)
                {
                    _selected.PropertyChanged += new PropertyChangedEventHandler(OnPropertyChanged);
                }
                OnPropertyChanged("Selected");
            }
        }

        #endregion Public Properties

        #region Public Methods

        public void Refresh()
        {
            DAOMenu.Refresh();
            this.Load();
        }

        #endregion Public Methods

        #region Private Methods

        private void Load()
        {
            _icons = DAOMenu.Instance.Icons;
            _credits = DAOMenu.Instance.Credits;
            _background = DAOMenu.Instance.Background;
            _en_US = DAOMenu.Instance.English;
            _fr_FR = DAOMenu.Instance.French;
            _es_ES = DAOMenu.Instance.Spanish;
            _cat_CAT = DAOMenu.Instance.Catalan;
            _de_DE = DAOMenu.Instance.German;
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            DAOMenu.Save();
        }

        #endregion Private Methods
    }
}