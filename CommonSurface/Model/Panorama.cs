using System;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace CommonSurface.Model
{
    [Serializable]
    public class Panorama : INotifyPropertyChanged, IDisposable
    {
        #region Private Fields

        private string _copyright;

        private string _description;

        private string _descriptionCAT;

        private string _descriptionEN;

        private string _descriptionES;

        private string _media;

        private string _scene;

        private string _title;

        private string _titleCAT;

        private string _titleEN;

        private string _titleES;

        #endregion Private Fields

        #region Public Constructors

        // DO NOT USE
        public Panorama() { }

        public Panorama(string title, string titleCAT, string titleEN, string titleES, string scene, string description, string descriptionCAT, string descriptionEN, string descriptionES, string media, string copyright)
        {
            this._title = title;
            this._titleCAT = titleCAT;
            this._titleEN = titleEN;
            this._titleES = titleES;
            this._scene = scene;
            this._description = description;
            this._descriptionCAT = descriptionCAT;
            this._descriptionEN = descriptionEN;
            this._descriptionES = descriptionES;
            this._media = media;
            this._copyright = copyright;
        }

        public Panorama(Panorama other)
        {
            this._title = other.Title;
            this._titleCAT = other.TitleCAT;
            this._titleEN = other.TitleEN;
            this._titleES = other.TitleES;
            this._scene = other.Scene;
            this._description = other.Description;
            this._descriptionCAT = other.DescriptionCAT;
            this._descriptionEN = other.DescriptionEN;
            this._descriptionES = other.DescriptionES;
            this._media = other.Media;
            this._copyright = other.Copyright;
        }

        #endregion Public Constructors

        #region Public Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Public Events

        #region Public Methods

        public static Panorama Blank()
        {
            return new Panorama("", "", "", "", "","","","","","","");
        }

        public static Panorama Blank(string scene)
        {
            return new Panorama("", scene, "", "", "","","","","","","");
        }

        public void Copy(Panorama copy)
        {
            this.Title = copy.Title;
            this.TitleCAT = copy.TitleCAT;
            this.TitleEN = copy.TitleEN;
            this.TitleES = copy.TitleES;
            this.Scene = copy.Scene;
            this.Description = copy.Description;
            this.DescriptionCAT = copy.DescriptionCAT;
            this.DescriptionEN = copy.DescriptionEN;
            this.DescriptionES = copy.DescriptionES;
            this.Media = copy.Media;
            this.Copyright = copy.Copyright;
        }

        public void Dispose()
        {
            this._title = null;
            this._titleCAT = null;
            this._titleEN = null;
            this._titleES = null;
            this._scene = null;
            this._description = null;
            this._descriptionCAT = null;
            this._descriptionEN = null;
            this._descriptionES = null;
            this._media = null;
            this._copyright = null;
        }

        public override string ToString()
        {
            return $"Panorama [Name: {this.Name}]";
        }

        #endregion Public Methods

        #region Protected Methods

        protected void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }

        #endregion Protected Methods

        #region GETTEUR/SETTEUR

        [XmlElement]
        public string Copyright
        {
            get { return this._copyright; }
            set { this._copyright = value; OnPropertyChanged("Copyright"); }
        }

        [XmlElement]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; OnPropertyChanged("Description"); }
        }

        [XmlElement]
        public string DescriptionCAT
        {
            get { return this._descriptionCAT; }
            set { this._descriptionCAT = value; OnPropertyChanged("DescriptionCAT"); }
        }

        [XmlElement]
        public string DescriptionEN
        {
            get { return this._descriptionEN; }
            set { this._descriptionEN = value; OnPropertyChanged("DescriptionEN"); }
        }

        [XmlElement]
        public string DescriptionES
        {
            get { return this._descriptionES; }
            set { this._descriptionES = value; OnPropertyChanged("DescriptionES"); }
        }

        [XmlElement]
        public string Media
        {
            get { return this._media; }
            set { this._media = value; OnPropertyChanged("Media"); }
        }

        public string Name
        {
            get
            {
                if (this._title != null)
                {
                    if (this._title.Length > 0)
                    {
                        return this._title;
                    }
                }

                return this._scene;
            }
        }

        [XmlAttribute]
        public string Scene
        {
            get { return this._scene; }
            set { this._scene = value; OnPropertyChanged("Scene"); }
        }

        [XmlElement]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; OnPropertyChanged("Title"); }
        }

        [XmlElement]
        public string TitleCAT
        {
            get { return this._titleCAT; }
            set { this._titleCAT = value; OnPropertyChanged("TitleCAT"); }
        }

        [XmlElement]
        public string TitleEN
        {
            get { return this._titleEN; }
            set { this._titleEN = value; OnPropertyChanged("TitleEN"); }
        }

        [XmlElement]
        public string TitleES
        {
            get { return this._titleES; }
            set { this._titleES = value; OnPropertyChanged("TitleES"); }
        }

        #endregion GETTEUR/SETTEUR
    }
}