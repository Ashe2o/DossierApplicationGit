using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace CommonSurface.Model
{
    [Serializable]
    public class Map : INotifyPropertyChanged, IDisposable
    {
        #region Private Fields

        private string _backgroundFR;

        private string _backgroundCAT;

        private string _backgroundEN;

        private string _backgroundES;

        private string _thumbnail;

        private int _id;

        private string _name;

        private ObservableCollection<PlaceHolder> _placeholders;

        #endregion Private Fields

        #region Public Constructors

        // DO NOT USE
        public Map()
        {
        }

        public Map(int id, string name, string backgroundFR, string backgroundCAT, string backgroundEN, string backgroundES, string thumbnail)
        {
            this._id = id;
            this._name = name;
            this._backgroundFR = backgroundFR;
            this._backgroundCAT = backgroundCAT;
            this._backgroundEN = backgroundEN;
            this._backgroundES = backgroundES;
            this._thumbnail = thumbnail;
            this._placeholders = new ObservableCollection<PlaceHolder>();
        }

        public Map(Map other)
        {
            this._id = other.ID;
            this._name = other.Name;
            this._thumbnail = other.Thumbnail;
            this._backgroundFR = other.BackgroundFR;
            this._backgroundCAT = other.BackgroundCAT;
            this._backgroundEN = other.BackgroundEN;
            this._backgroundES = other.BackgroundES;
            this._placeholders = new ObservableCollection<PlaceHolder>(other.PlaceHolders);
        }

        #endregion Public Constructors

        #region Private Destructors

        ~Map()
        {
            this._id = 0;
            this._name = null;
            this._backgroundFR = null;
            this._backgroundCAT = null;
            this._backgroundEN = null;
            this._backgroundES = null;
            this._placeholders = null;
        }

        #endregion Private Destructors

        #region Public Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Public Events

        #region Public Methods

        public static Map Blank()
        {
            return new Map(-1, "", "","","","","");
        }

        public static Map Blank(int id)
        {
            return new Map(id, "", "","","","","");
        }

        public void Copy(Map copy)
        {
            this._id = copy.ID;
            this._name = copy.Name;
            this._backgroundFR = copy.BackgroundFR;
            this._backgroundCAT = copy.BackgroundCAT;
            this._backgroundEN = copy.BackgroundEN;
            this._backgroundES = copy.BackgroundES;
            this.Thumbnail = copy.Thumbnail;
            this._placeholders = new ObservableCollection<PlaceHolder>(copy.PlaceHolders);
        }

        public void Dispose()
        {
            this._placeholders.CollectionChanged -= _placeholder_CollectionChanged;
            foreach (PlaceHolder p in this._placeholders)
            {
                p.Dispose();
            }
            this._placeholders = null;
            this._thumbnail = null;
        }

        public override string ToString()
        {
            return "Visite[ID= " + ID + ", " +
                "Name=" + Name + "]";
        }

        #endregion Public Methods

        #region Protected Methods

        protected void OnPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        #endregion Protected Methods

        #region Private Methods

        private void _placeholder_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged("PlaceHolders");
        }

        #endregion Private Methods

        #region GETTEUR/SETTEUR

        [XmlElement]
        public string BackgroundFR
        {
            get { return _backgroundFR; }
            set { _backgroundFR = value; OnPropertyChanged("BackgroundFR"); }
        }

        [XmlElement]
        public string BackgroundCAT
        {
            get { return _backgroundCAT; }
            set { _backgroundCAT = value; OnPropertyChanged("BackgroundCAT"); }
        }

        [XmlElement]
        public string BackgroundEN
        {
            get { return _backgroundEN; }
            set { _backgroundEN = value; OnPropertyChanged("BackgroundEN"); }
        }

        [XmlElement]
        public string BackgroundES
        {
            get { return _backgroundES; }
            set { _backgroundES = value; OnPropertyChanged("BackgroundES"); }
        }

        [XmlAttribute]
        public int ID
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged("ID"); }
        }

        [XmlAttribute]
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged("Name"); }
        }

        [XmlElement]
        public string Thumbnail
        {
            get { return _thumbnail; }
            set { _thumbnail = value; OnPropertyChanged("Thumbnail"); }
        }

        [XmlArray("PlaceHolders")]
        [XmlArrayItem("PlaceHolder")]
        public ObservableCollection<PlaceHolder> PlaceHolders
        {
            get { return _placeholders; }

            set
            {
                _placeholders = value;
                _placeholders.CollectionChanged += _placeholder_CollectionChanged;
                OnPropertyChanged("Panoramas");
            }
        }

        #endregion GETTEUR/SETTEUR
    }
}