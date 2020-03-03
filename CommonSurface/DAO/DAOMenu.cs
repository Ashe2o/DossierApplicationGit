using CommonSurface.Model;
using CommonSurface.Utils;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Xml.Serialization;

namespace CommonSurface.DAO
{
    public class DAOMenu
    {
        #region Private Fields

        private static DAOMenu _instance;

        private static string defaultPath = ConfigurationManager.AppSettings["cheminMenu"];
        private string _background;
        private Credits _credits;
        private Langue _en_US;
        private Langue _fr_FR;
        private Langue _es_ES;
        private Langue _cat_CAT;
        private Langue _de_DE;
        private ObservableHashSet<Icon> _icons;

        #endregion Private Fields

        #region Private Constructors

        /// <summary>
        /// Construct default DAO Objet
        /// </summary>
        private DAOMenu()
        {
            _icons = new ObservableHashSet<Icon>();
            _icons.CollectionChanged += icons_CollectionChanged;
        }

        /// <summary>
        /// Construct the DAO with data contains in default path
        /// </summary>
        private DAOMenu(string filename)
        {
            Load(filename);
        }

        #endregion Private Constructors

        #region Public Methods

        public static void Refresh()
        {
            DAOMenu.Instance.Load(defaultPath);
            DAOMenu.Instance.Save(defaultPath);
        }

        /// <summary>
        /// Force save data
        /// </summary>
        public static void Save()
        {
            DAOMenu.Instance.Save(defaultPath);
        }

        #endregion Public Methods

        #region Private Methods

        private void icons_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Save(defaultPath);
        }

        /// <summary>
        /// Load data from a file <br /> Create default if the file doesn't exists
        /// </summary>
        /// <param name="filename"></param>
        private void Load(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileLoadException();
            }

            FileStream file = File.OpenRead(filename);
            XmlSerializer serializer = new XmlSerializer(typeof(DAOMenu));
            DAOMenu other = (DAOMenu)serializer.Deserialize(file);
            file.Close();

            // copying items
            UpdateWith(other);
        }

        /// <summary>
        /// Save data to the given filename
        /// </summary>
        /// <param name="filename"></param>
        private void Save(string filename)
        {
            try
            {
                FileStream file = File.Open(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                file.SetLength(0);
                XmlSerializer serializer = new XmlSerializer(typeof(DAOMenu));
                serializer.Serialize(file, this);
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to save: " + e.Message);
                //case of concurrent call, the newt call will write it
            }
        }

        /// <summary>
        /// Update data with an other DAOMemory <br /> Usually called from Load methods
        /// </summary>
        /// <param name="other"></param>
        private void UpdateWith(DAOMenu other)
        {
            _icons = other.Icons;
            _credits = other.Credits;
            _en_US = other.English;
            _fr_FR = other.French;
            _es_ES = other.Spanish;
            _cat_CAT = other.Catalan;
            _de_DE = other.German;
            _background = other.Background;
        }

        #endregion Private Methods

        #region getters and setters

        /// <summary>
        /// Get the single instance
        /// </summary>
        public static DAOMenu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DAOMenu(defaultPath);
                }
                return _instance;
            }
        }

        [XmlElement("Background")]
        public string Background
        {
            get { return _background; }
            set { _background = value; }
        }

        [XmlElement("Credits")]
        public Credits Credits
        {
            get { return _credits; }
            set { _credits = value; }
        }

        [XmlElement("English")]
        public Langue English
        {
            get { return _en_US; }
            set { _en_US = value; }
        }

        [XmlElement("French")]
        public Langue French
        {
            get { return _fr_FR; }
            set { _fr_FR = value; }
        }

        [XmlElement("Spanish")]
        public Langue Spanish
        {
            get { return _es_ES; }
            set { _es_ES = value; }
        }

        [XmlElement("Catalan")]
        public Langue Catalan
        {
            get { return _cat_CAT; }
            set { _cat_CAT = value; }
        }

        [XmlElement("German")]
        public Langue German
        {
            get { return _de_DE; }
            set { _de_DE = value; }
        }

        /// <summary>
        /// Get the place holders collection
        /// </summary>
        [XmlArray("Icons")]
        [XmlArrayItem("Icon")]
        public ObservableHashSet<Icon> Icons
        {
            get { return _icons; }
            set { _icons = value; }
        }

        #endregion getters and setters
    }
}